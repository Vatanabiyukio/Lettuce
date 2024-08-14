using System.ComponentModel.DataAnnotations.Schema;
using Lettuce.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Lettuce.Domain.Entities;

[Keyless]
public partial class Warrior
{
    [Column("Status Criação", TypeName = "text")]
    public string? StatusCriação { get; set; }

    [Column("Prefixo/Subordinada", TypeName = "text")]
    public string? PrefixoSubordinada { get; set; }

    [Column(TypeName = "text")]
    public string? Hostname { get; set; }

    [Column("Status no Gsti", TypeName = "text")]
    public string? StatusNoGsti { get; set; }

    [Column("Site de Ti", TypeName = "text")]
    public string? SiteDeTi { get; set; }

    [Column("Uor Instaladora", TypeName = "text")]
    public string? UorInstaladora { get; set; }

    [Column("CNPJ", TypeName = "text")]
    public string? Cnpj { get; set; }

    [Column("IDBB", TypeName = "text")]
    public string? Idbb { get; set; }

    [Column("Data de Criação do IC", TypeName = "text")]
    public string? DataDeCriaçãoDoIc { get; set; }

    [Column("Tipo do DCZ", TypeName = "text")]
    public string? TipoDoDcz { get; set; }

    [Column("Autorizado no CDA 2808?", TypeName = "text")]
    public string? AutorizadoNoCda2808 { get; set; }

    [Column("Solicitado para o Severo?", TypeName = "text")]
    public string? SolicitadoParaOSevero { get; set; }

    [Column("Enviada a mensagem para o orçamento de TI?", TypeName = "text")]
    public string? EnviadaAMensagemParaOOrçamentoDeTi { get; set; }

    [Column("Enviada a mensagem para a agência?", TypeName = "text")]
    public string? EnviadaAMensagemParaAAgência { get; set; }

    [Column(TypeName = "text")]
    public string? Observação { get; set; }
    
    public static implicit operator WarriorModel(Warrior warrior)
    {
        return new WarriorModel
        {
            UorInstaladora = warrior.UorInstaladora,
            Hostname = warrior.Hostname,
            StatusNoGsti = warrior.StatusNoGsti,
            SiteDeTi = warrior.SiteDeTi,
            PrefixoSubordinada = warrior.PrefixoSubordinada,
            Cnpj = warrior.Cnpj,
            DataDeCriaçãoDoIc = warrior.DataDeCriaçãoDoIc,
            AutorizadoNoCda2808 = warrior.AutorizadoNoCda2808,
            StatusCriação = warrior.StatusCriação,
            Idbb = warrior.Idbb,
            TipoDoDcz = warrior.TipoDoDcz,
            SolicitadoParaOSevero = warrior.SolicitadoParaOSevero,
            EnviadaAMensagemParaOOrçamentoDeTi = warrior.EnviadaAMensagemParaOOrçamentoDeTi,
            EnviadaAMensagemParaAAgência = warrior.EnviadaAMensagemParaAAgência,
            Observação = warrior.Observação
        };
    }

}
