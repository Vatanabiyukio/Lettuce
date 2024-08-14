using Lettuce.Domain.Entities;

namespace Lettuce.Domain.Models;

public class WarriorModel
{
    public string? StatusCriação { get; set; }
    
    public string? PrefixoSubordinada { get; set; }
    
    public string? Hostname { get; set; }
    
    public string? StatusNoGsti { get; set; }
    
    public string? SiteDeTi { get; set; }
    
    public string? UorInstaladora { get; set; }
    
    public string? Cnpj { get; set; }
    
    public string? Idbb { get; set; }
    
    public string? DataDeCriaçãoDoIc { get; set; }
    
    public string? TipoDoDcz { get; set; }
    
    public string? AutorizadoNoCda2808 { get; set; }
    
    public string? SolicitadoParaOSevero { get; set; }
    
    public string? EnviadaAMensagemParaOOrçamentoDeTi { get; set; }
    
    public string? EnviadaAMensagemParaAAgência { get; set; }
    
    public string? Observação { get; set; }
    
    public static implicit operator PumpkimModel(WarriorModel warrior)
    {
        return new PumpkimModel
        {
            UorInstaladora = int.TryParse(warrior.UorInstaladora, out var uor) ? uor : (int?)null,
            HostnameDoCircuito = warrior.Hostname,
            StatusNoGsti = warrior.StatusNoGsti,
            IcDoSite = warrior.SiteDeTi,
            PrefixoSubordinada = warrior.PrefixoSubordinada,
            Cnpj = warrior.Cnpj,
            DataDeCriaçãoDoIc = warrior.DataDeCriaçãoDoIc,
            AutorizadoNoCda = warrior.AutorizadoNoCda2808
        };
    }
    
    public static implicit operator Warrior(WarriorModel warriorModel)
    {
        return new Warrior
        {
            UorInstaladora = warriorModel.UorInstaladora,
            Hostname = warriorModel.Hostname,
            StatusNoGsti = warriorModel.StatusNoGsti,
            SiteDeTi = warriorModel.SiteDeTi,
            PrefixoSubordinada = warriorModel.PrefixoSubordinada,
            Cnpj = warriorModel.Cnpj,
            DataDeCriaçãoDoIc = warriorModel.DataDeCriaçãoDoIc,
            AutorizadoNoCda2808 = warriorModel.AutorizadoNoCda2808,
            StatusCriação = warriorModel.StatusCriação,
            Idbb = warriorModel.Idbb,
            TipoDoDcz = warriorModel.TipoDoDcz,
            SolicitadoParaOSevero = warriorModel.SolicitadoParaOSevero,
            EnviadaAMensagemParaOOrçamentoDeTi = warriorModel.EnviadaAMensagemParaOOrçamentoDeTi,
            EnviadaAMensagemParaAAgência = warriorModel.EnviadaAMensagemParaAAgência,
            Observação = warriorModel.Observação
        };
    }


}