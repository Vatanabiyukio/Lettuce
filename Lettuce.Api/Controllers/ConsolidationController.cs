using System.Text.RegularExpressions;
using Lettuce.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace Lettuce.Api.Controllers;

[ApiController]
[Route("[controller]")]
public partial class ConsolidationController : ControllerBase
{
    private readonly ILogger<ConsolidationController> _logger;
    private readonly IServiceProvider _serviceProvider;

    public ConsolidationController(ILogger<ConsolidationController> logger, IServiceProvider serviceProvider)
    {
        _logger = logger;
        _serviceProvider = serviceProvider;
    }

    [HttpPut]
    public async Task<IActionResult> UpdateConsolidation()
    {
        var consolidationService = _serviceProvider.GetService<ConsolidationService>();
        var warriorList = consolidationService?.ObterPlanilhaWarrior();
        /*using var scope = _serviceProvider.CreateScope();
        var mysqlContext = scope.ServiceProvider.GetService<MysqlContext>();

        // Obtem as duas tabelas de forma lazy
        var pumpkim = mysqlContext?.Pumpkim ?? throw new InvalidOperationException();
        var warrior = mysqlContext.Warrior ?? throw new InvalidOperationException();

        // obtem de pumpkin as linhas que não existem em warrior
        var linhasAusentes = pumpkim
            .Where(p => !warrior
                .Any(w => w.Hostname == p.HostnameDoCircuito))
                    .ToArray();

        // Converte as linhas ausentes em um objeto compatível com warrior
        var novosWarriors = linhasAusentes
            .Select(la => (PumpkimModel)la)
            .Select(nw => (WarriorModel)nw);

        // Insere as linhas ausentes em warrior
        var localWarriors = await warrior.ToListAsync();
        localWarriors.AddRange(novosWarriors.Select(x => (Warrior)x));

        var regex = MyRegex();
        localWarriors.Sort((x, y) =>
        {
            // Extrai os 4 últimos dígitos numéricos de Hostname
            var xDigits = regex.Match(x.Hostname ?? "0000").Value;
            var yDigits = regex.Match(y.Hostname ?? "0000").Value;

            // Convertendo para inteiros para comparação numérica
            if (int.TryParse(xDigits, out var xNumber) && int.TryParse(yDigits, out var yNumber))
            {
                // Inverter a comparação para obter ordem decrescente
                return yNumber.CompareTo(xNumber);
            }

            return 0; // Se não conseguir converter, considera como iguais
        });

        // Atualiza warrior a partir de pumpkin
        var localPumpkins = await pumpkim.ToArrayAsync();

        var uorsPagadorasSolicitadosParaSevero = new List<int>();
        var uorsPagadorasEnviadosParaOrçamento = new List<int>();

        localWarriors.ForEach(lw =>
        {
            var selectedPumpkin = localPumpkins.FirstOrDefault(lp => lp.HostnameDoCircuito == lw.Hostname);
            if (selectedPumpkin is null) return;
            // Atualiza os dados
            lw.Hostname = selectedPumpkin.HostnameDoCircuito;
            lw.UorInstaladora = selectedPumpkin.UorInstaladora?.ToString();
            lw.Hostname = selectedPumpkin.HostnameDoCircuito;
            lw.StatusNoGsti = selectedPumpkin.StatusNoGsti;
            lw.SiteDeTi = selectedPumpkin.HostnameDoSite;
            lw.PrefixoSubordinada = selectedPumpkin.PrefixoSubordinada;
            lw.Cnpj = selectedPumpkin.Cnpj;
            lw.DataDeCriaçãoDoIc = selectedPumpkin.DataDeCriaçãoDoIc;
            lw.Idbb = MyRegex1().Match(selectedPumpkin.HostnameDoCircuito ?? "").Value;
            lw.StatusCriação ??= "OK";
            lw.AutorizadoNoCda2808 = selectedPumpkin.AutorizadoNoCda == "VERDADEIRO" ? "SIM" : "NÃO";
            if (lw.EnviadaAMensagemParaAAgência != "SIM")
                lw.EnviadaAMensagemParaAAgência = "NÃO";

            // Salva os dados para consumo posterior
            if (lw.SolicitadoParaOSevero == "SIM")
                uorsPagadorasSolicitadosParaSevero.Add(selectedPumpkin.UorPagadora ?? -1);
            if (lw.EnviadaAMensagemParaOOrçamentoDeTi == "SIM")
                uorsPagadorasEnviadosParaOrçamento.Add(selectedPumpkin.UorPagadora ?? -1);
        });

        uorsPagadorasSolicitadosParaSevero.RemoveAll(int.IsNegative);
        uorsPagadorasEnviadosParaOrçamento.RemoveAll(int.IsNegative);

        localWarriors.ForEach(lw =>
        {
            var selectedPumpkin = localPumpkins.FirstOrDefault(lp => lp.HostnameDoCircuito == lw.Hostname);
            if (selectedPumpkin is null) return;
            lw.SolicitadoParaOSevero =
                uorsPagadorasSolicitadosParaSevero.Contains(selectedPumpkin.UorPagadora ?? -1) ? "SIM" : "NÃO";
            lw.EnviadaAMensagemParaOOrçamentoDeTi =
                uorsPagadorasEnviadosParaOrçamento.Contains(selectedPumpkin.UorPagadora ?? -1) ? "SIM" : "NÃO";
        });

        ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

        using (var ep = new ExcelPackage(@"/Users/viniciusvatanabi/Downloads/Consolidação_Warrior.xlsx"))
        {
            var ws = ep.Workbook.Worksheets["Dados"];
            var excelTable = ws.Tables.FirstOrDefault();
            var firstAddress = excelTable?.Address.Start ?? throw new InvalidDataException();
            var lastAddress = excelTable.Address.End ?? throw new InvalidDataException();

            excelTable.DeleteRow(int.Parse(firstAddress.Row.ToString()) + 1, int.Parse(lastAddress.Row.ToString()) - int.Parse(firstAddress.Row.ToString()) - 4);

            foreach (var localWarrior in localWarriors)
            {
                var rowRange = excelTable.AddRow();
                var newRowIx = rowRange.Start.Row;

                ws.Cells[newRowIx, 1].Value = localWarrior.StatusCriação;
                ws.Cells[newRowIx, 2].Value = localWarrior.PrefixoSubordinada;
                ws.Cells[newRowIx, 3].Value = localWarrior.Hostname;
                ws.Cells[newRowIx, 4].Value = localWarrior.StatusNoGsti;
                ws.Cells[newRowIx, 5].Value = localWarrior.SiteDeTi;
                ws.Cells[newRowIx, 6].Value = localWarrior.UorInstaladora;
                ws.Cells[newRowIx, 7].Value = localWarrior.Cnpj;
                ws.Cells[newRowIx, 8].Value = localWarrior.Idbb;
                ws.Cells[newRowIx, 9].Value = localWarrior.TipoDoDcz;
                ws.Cells[newRowIx, 10].Value = localWarrior.AutorizadoNoCda2808;
                ws.Cells[newRowIx, 11].Value = localWarrior.SolicitadoParaOSevero;
                ws.Cells[newRowIx, 12].Value = localWarrior.EnviadaAMensagemParaOOrçamentoDeTi;
                ws.Cells[newRowIx, 13].Value = localWarrior.EnviadaAMensagemParaAAgência;
                ws.Cells[newRowIx, 14].Value = localWarrior.Observação;
            }

            await ep.SaveAsync();
        }*/

        return Ok();
    }

    [GeneratedRegex(@"\d{4}$")]
    private static partial Regex MyRegex();

    [GeneratedRegex(@"DCZ\d+")]
    private static partial Regex MyRegex1();
}