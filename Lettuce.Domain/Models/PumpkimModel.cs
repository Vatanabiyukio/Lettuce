using Lettuce.Domain.Entities;

namespace Lettuce.Domain.Models;

public class PumpkimModel
{
    public int? UorInstaladora { get; set; }
    
    public int? UorPagadora { get; set; }
    
    public string? HostnameDoCircuito { get; set; }
    
    public string? StatusNoGsti { get; set; }
    
    public string? IcDoSite { get; set; }
    
    public string? IcDoCircuito { get; set; }
    
    public string? HostnameDoSite { get; set; }
    
    public string? PrefixoSubordinada { get; set; }

    public string? Prefixo { get; set; }

    public string? Subordinada { get; set; }
    
    public string? NomeUor { get; set; }

    public string? Bairro { get; set; }

    public string? Município { get; set; }
    
    public string? Uf { get; set; }
    
    public string? DataDeCriaçãoDoIc { get; set; }
    
    public string? MeioFísicoDeAcesso { get; set; }
    
    public string? Cnpj { get; set; }
    
    public string? DataDeAtivaçãoDoFornecedor { get; set; }

    public string? Mensalidade { get; set; }
    
    public string? AutorizadoNoCda { get; set; }
    
    public static implicit operator WarriorModel(PumpkimModel pumpkim)
    {
        return new WarriorModel
        {
            UorInstaladora = pumpkim.UorInstaladora?.ToString(),
            Hostname = pumpkim.HostnameDoCircuito,
            StatusNoGsti = pumpkim.StatusNoGsti,
            SiteDeTi = pumpkim.IcDoSite,
            PrefixoSubordinada = pumpkim.PrefixoSubordinada,
            Cnpj = pumpkim.Cnpj,
            DataDeCriaçãoDoIc = pumpkim.DataDeCriaçãoDoIc,
            AutorizadoNoCda2808 = pumpkim.AutorizadoNoCda
        };
    }
    
    public static implicit operator PumpkimModel(Pumpkim pumpkin)
    {
        return new PumpkimModel
        {
            UorInstaladora = pumpkin.UorInstaladora,
            UorPagadora = pumpkin.UorPagadora,
            HostnameDoCircuito = pumpkin.HostnameDoCircuito,
            StatusNoGsti = pumpkin.StatusNoGsti,
            IcDoSite = pumpkin.IcDoSite,
            IcDoCircuito = pumpkin.IcDoCircuito,
            HostnameDoSite = pumpkin.HostnameDoSite,
            PrefixoSubordinada = pumpkin.PrefixoSubordinada,
            Prefixo = pumpkin.Prefixo,
            Subordinada = pumpkin.Subordinada,
            NomeUor = pumpkin.NomeUor,
            Bairro = pumpkin.Bairro,
            Município = pumpkin.Município,
            Uf = pumpkin.Uf,
            DataDeCriaçãoDoIc = pumpkin.DataDeCriaçãoDoIc,
            MeioFísicoDeAcesso = pumpkin.MeioFísicoDeAcesso,
            Cnpj = pumpkin.Cnpj,
            DataDeAtivaçãoDoFornecedor = pumpkin.DataDeAtivaçãoDoFornecedor,
            Mensalidade = pumpkin.Mensalidade,
            AutorizadoNoCda = pumpkin.AutorizadoNoCda
        };
    }

}