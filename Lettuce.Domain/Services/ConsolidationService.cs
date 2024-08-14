using Lettuce.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OfficeOpenXml;
using Pumpkin.Contexts;

namespace Lettuce.Domain.Services;

public class ConsolidationService : IConsolidationService
{
    private readonly IConfiguration _config;
    private readonly IServiceProvider _serviceProvider;

    public ConsolidationService(IConfiguration config, IServiceProvider serviceProvider)
    {
        _config = config;
        _serviceProvider = serviceProvider;
    }

    public IEnumerable<WarriorModel> ObterPlanilhaWarrior()
    {
        var warriorPath = _config.GetSection("FilePaths:Warrior").Value;
        ArgumentException.ThrowIfNullOrWhiteSpace(warriorPath, nameof(warriorPath));
        using var ep = new ExcelPackage(warriorPath);
        var ws = ep.Workbook.Worksheets["Dados"];
        var excelTable = ws.Tables.FirstOrDefault();
        ArgumentException.ThrowIfNullOrWhiteSpace(excelTable?.ToString(), nameof(excelTable));
        return Enumerable.Range(excelTable.Address.Start.Row + 1,
                excelTable.Address.End.Row - excelTable.Address.Start.Row - 4)
            .Select(row => new WarriorModel
            {
                StatusCriação = ws.Cells[row, 1].Value.ToString(),
                PrefixoSubordinada = ws.Cells[row, 2].Value.ToString(),
                Hostname = ws.Cells[row, 3].Value.ToString(),
                StatusNoGsti = ws.Cells[row, 4].Value.ToString(),
                SiteDeTi = ws.Cells[row, 5].Value.ToString(),
                UorInstaladora = ws.Cells[row, 6].Value.ToString(),
                Cnpj = ws.Cells[row, 7].Value.ToString(),
                Idbb = ws.Cells[row, 8].Value.ToString(),
                DataDeCriaçãoDoIc = ws.Cells[row, 9].Value.ToString(),
                TipoDoDcz = ws.Cells[row, 10].Value.ToString(),
                AutorizadoNoCda2808 = ws.Cells[row, 11].Value.ToString(),
                SolicitadoParaOSevero = ws.Cells[row, 12].Value.ToString(),
                EnviadaAMensagemParaOOrçamentoDeTi = ws.Cells[row, 13].Value.ToString(),
                EnviadaAMensagemParaAAgência = ws.Cells[row, 14].Value.ToString(),
                Observação = ws.Cells[row, 15].Value.ToString()
            });
    }

    public async Task<IEnumerable<PumpkimModel>> ObterBancoPumpkin()
    {
        var gstiOracleContext = _serviceProvider.GetService<GstiOracleContext>();

        FormattableString sqlQuery = $$"""
                                       WITH pa AS (SELECT LPAD(BBMSTF500FM1.PREFIXO, 4, '0') || '/' || LPAD(BBMSTF500FM1.SUBORDINADA, 2, '0') AS pc,
                                                          BBMSTF500FM1.PREFIXO                                                                AS p,
                                                          BBMSTF500FM1.SUBORDINADA                                                            AS s,
                                                          BBMSTF500FM1.CODUOR                                                                 AS u,
                                                          BBMSTF500FM1.NOMEUORREDUZIDO                                                        AS nr,
                                                          BBMSTF500FM1.BAIRRO,
                                                          BBMSTF500FM1.NOMEMUNICIPIO,
                                                          BBMSTF500FM1.SIGLAUF
                                                   FROM SMADMIN.BBMSTF500FM1),
                                            dm1 AS (SELECT SMADMIN.DESCENTRALIZADOM1.LOGICAL_NAME,
                                                           DEVICE2M1.HOSTNAME,
                                                           DEVICE2M1.ISTATUS,
                                                           DESCENTRALIZADOM1.MEIO_FISICO_ACESSO,
                                                           DESCENTRALIZADOM1.CNPJ,
                                                           DESCENTRALIZADOM1.DATA_ATIVACAO_FORNECEDOR,
                                                           DESCENTRALIZADOM1.SITE,
                                                           CASE
                                                               WHEN DESCENTRALIZADOM1.MENSALIDADE_FORNECEDOR IS NULL THEN NULL
                                                               -- Padrão brasileiro: ponto antes da vírgula
                                                               WHEN INSTR(DESCENTRALIZADOM1.MENSALIDADE_FORNECEDOR, '.') > 0 AND
                                                                    INSTR(DESCENTRALIZADOM1.MENSALIDADE_FORNECEDOR, '.') <
                                                                    INSTR(DESCENTRALIZADOM1.MENSALIDADE_FORNECEDOR, ',')
                                                                   THEN
                                                                   TO_NUMBER(REPLACE(
                                                                                     REGEXP_REPLACE(DESCENTRALIZADOM1.MENSALIDADE_FORNECEDOR, '[^0-9.,]', ''),
                                                                                     '.',
                                                                                     '') DEFAULT 0 ON CONVERSION ERROR)
                                                               -- Padrão americano: vírgula antes do ponto
                                                               WHEN INSTR(DESCENTRALIZADOM1.MENSALIDADE_FORNECEDOR, ',') > 0 AND
                                                                    INSTR(DESCENTRALIZADOM1.MENSALIDADE_FORNECEDOR, ',') <
                                                                    INSTR(DESCENTRALIZADOM1.MENSALIDADE_FORNECEDOR, '.')
                                                                   THEN
                                                                   TO_NUMBER(REPLACE(REGEXP_REPLACE(DESCENTRALIZADOM1.MENSALIDADE_FORNECEDOR, '[^0-9.]', ''),
                                                                                     '.', ',') DEFAULT 0 ON CONVERSION ERROR)
                                                               -- Caso ambíguo tratado como mil
                                                               WHEN LENGTH(REGEXP_SUBSTR(DESCENTRALIZADOM1.MENSALIDADE_FORNECEDOR, '[,.]([0-9]){3,}')) > 0
                                                                   THEN
                                                                   TO_NUMBER(REPLACE(REGEXP_REPLACE(DESCENTRALIZADOM1.MENSALIDADE_FORNECEDOR, '[^0-9.]', ''),
                                                                                     '.', '') DEFAULT 0 ON CONVERSION ERROR)
                                                               -- Apenas vírgula e não ambíguo
                                                               WHEN INSTR(DESCENTRALIZADOM1.MENSALIDADE_FORNECEDOR, ',') > 0 THEN
                                                                   TO_NUMBER(REGEXP_REPLACE(DESCENTRALIZADOM1.MENSALIDADE_FORNECEDOR, '[^0-9.,]', '') DEFAULT 0
                                                                             ON
                                                                             CONVERSION ERROR)
                                                               -- Apenas ponto e não ambíguo
                                                               WHEN INSTR(DESCENTRALIZADOM1.MENSALIDADE_FORNECEDOR, '.') > 0 THEN
                                                                   TO_NUMBER(REPLACE(REGEXP_REPLACE(DESCENTRALIZADOM1.MENSALIDADE_FORNECEDOR, '[^0-9.]', ''),
                                                                                     '.', ',') DEFAULT 0 ON CONVERSION ERROR)
                                                               -- Sem ponto nem vírgula
                                                               WHEN INSTR(DESCENTRALIZADOM1.MENSALIDADE_FORNECEDOR, '.') = 0 AND
                                                                    INSTR(DESCENTRALIZADOM1.MENSALIDADE_FORNECEDOR, ',') = 0
                                                                   THEN
                                                                   TO_NUMBER(REGEXP_REPLACE(DESCENTRALIZADOM1.MENSALIDADE_FORNECEDOR, '[^0-9.]', '') DEFAULT 0
                                                                             ON
                                                                             CONVERSION ERROR)
                                                               END AS MENSALIDADE_NORMALIZADA,
                                                           CREATED_BY_DATE
                                                    FROM SMADMIN.DEVICE2M1
                                                             LEFT JOIN SMADMIN.DESCENTRALIZADOM1
                                                                       ON SMADMIN.DEVICE2M1.LOGICAL_NAME = SMADMIN.DESCENTRALIZADOM1.LOGICAL_NAME
                                                    WHERE DEVICE2M1.BB_TIPO LIKE 'INTERNET DESCENTRALIZADA'
                                                      AND DESCENTRALIZADOM1.IDBB LIKE 'DCZ%'),
                                            st1 AS (SELECT DEVICE2M1.LOGICAL_NAME,
                                                           DEVICE2M1.HOSTNAME,
                                                           SMADMIN.DESCENTRALIZADOM1.ID_PAGADOR
                                                    FROM SMADMIN.DEVICE2M1
                                                             LEFT JOIN SMADMIN.DESCENTRALIZADOM1
                                                                       ON DEVICE2M1.LOGICAL_NAME = SMADMIN.DESCENTRALIZADOM1.LOGICAL_NAME
                                                    WHERE SUBTYPE LIKE 'SITES DE TI')
                                       SELECT pa.u                         AS "UorInstaladora",
                                              st1.ID_PAGADOR               AS "UorPagadora",
                                              dm1.HOSTNAME                 AS "HostnameCircuito",
                                              dm1.ISTATUS                  AS "Status",
                                              dm1.MENSALIDADE_NORMALIZADA  AS "Mensalidade",
                                              AI.SITE                      AS "SiteIc",
                                              DM1.LOGICAL_NAME             AS "CircuitoIc",
                                              st1.HOSTNAME                 AS "HostnameSite",
                                              pa.pc                        AS "PrefixoComposto",
                                              pa.p                         AS "Prefixo",
                                              pa.s                         AS "Subordinada",
                                              pa.nr                        AS "NomeReduzido",
                                              pa.BAIRRO                    AS "Bairro",
                                              pa.NOMEMUNICIPIO             AS "Municipio",
                                              pa.SIGLAUF                   AS "Uf",
                                              DM1.CREATED_BY_DATE          AS "DataCriacaoIc",
                                              dm1.MEIO_FISICO_ACESSO       AS "MeioFisicoAcesso",
                                              dm1.CNPJ                     AS "Cnpj",
                                              dm1.DATA_ATIVACAO_FORNECEDOR AS "DataAtivacaoFornecedor"
                                       FROM pa
                                                LEFT JOIN SMADMIN.BBAMBIENTESITEM1 AI ON AI.IDENTIFICADOR = pa.pc
                                                LEFT JOIN st1 ON st1.LOGICAL_NAME = AI.SITE
                                                RIGHT JOIN dm1 ON dm1.SITE LIKE st1.HOSTNAME
                                       WHERE AI.TIPO LIKE 'Autoban'
                                       ORDER BY dm1.HOSTNAME DESC
                                       """;

        if (gstiOracleContext is not null)
        {
            var pumpkinDb = await gstiOracleContext.Database.SqlQuery<PumpkimModel>(sqlQuery)
                .ToListAsync()
                .ConfigureAwait(false);

            return pumpkinDb;
        }

        ArgumentNullException.ThrowIfNull(gstiOracleContext, nameof(gstiOracleContext));
        throw new Exception();
    }
}