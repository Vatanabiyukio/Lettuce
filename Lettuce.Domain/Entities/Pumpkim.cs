using System.ComponentModel.DataAnnotations.Schema;
using Lettuce.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Lettuce.Domain.Entities;

[Keyless]
public partial class Pumpkim
{
    [Column("Uor Instaladora")]
    public int? UorInstaladora { get; set; }

    [Column("Uor Pagadora")]
    public int? UorPagadora { get; set; }

    [Column("Hostname do Circuito", TypeName = "text")]
    public string? HostnameDoCircuito { get; set; }

    [Column("Status no GSTI", TypeName = "text")]
    public string? StatusNoGsti { get; set; }

    [Column("IC do Site", TypeName = "text")]
    public string? IcDoSite { get; set; }

    [Column("IC do Circuito", TypeName = "text")]
    public string? IcDoCircuito { get; set; }

    [Column("Hostname do Site", TypeName = "text")]
    public string? HostnameDoSite { get; set; }

    [Column("Prefixo / Subordinada", TypeName = "text")]
    public string? PrefixoSubordinada { get; set; }

    [Column(TypeName = "text")]
    public string? Prefixo { get; set; }

    [Column(TypeName = "text")]
    public string? Subordinada { get; set; }

    [Column("Nome UOR", TypeName = "text")]
    public string? NomeUor { get; set; }

    [Column(TypeName = "text")]
    public string? Bairro { get; set; }

    [Column(TypeName = "text")]
    public string? Município { get; set; }

    [Column("UF", TypeName = "text")]
    public string? Uf { get; set; }

    [Column("Data de Criação do IC", TypeName = "text")]
    public string? DataDeCriaçãoDoIc { get; set; }

    [Column("Meio Físico de Acesso", TypeName = "text")]
    public string? MeioFísicoDeAcesso { get; set; }

    [Column("CNPJ", TypeName = "text")]
    public string? Cnpj { get; set; }

    [Column("Data de Ativação do Fornecedor", TypeName = "text")]
    public string? DataDeAtivaçãoDoFornecedor { get; set; }

    [Column(TypeName = "text")]
    public string? Mensalidade { get; set; }

    [Column("Autorizado no CDA", TypeName = "text")]
    public string? AutorizadoNoCda { get; set; }
    
    public static implicit operator Pumpkim(PumpkimModel pumpkimModel)
    {
        return new Pumpkim
        {
            UorInstaladora = pumpkimModel.UorInstaladora,
            UorPagadora = pumpkimModel.UorPagadora,
            HostnameDoCircuito = pumpkimModel.HostnameDoCircuito,
            StatusNoGsti = pumpkimModel.StatusNoGsti,
            IcDoSite = pumpkimModel.IcDoSite,
            IcDoCircuito = pumpkimModel.IcDoCircuito,
            HostnameDoSite = pumpkimModel.HostnameDoSite,
            PrefixoSubordinada = pumpkimModel.PrefixoSubordinada,
            Prefixo = pumpkimModel.Prefixo,
            Subordinada = pumpkimModel.Subordinada,
            NomeUor = pumpkimModel.NomeUor,
            Bairro = pumpkimModel.Bairro,
            Município = pumpkimModel.Município,
            Uf = pumpkimModel.Uf,
            DataDeCriaçãoDoIc = pumpkimModel.DataDeCriaçãoDoIc,
            MeioFísicoDeAcesso = pumpkimModel.MeioFísicoDeAcesso,
            Cnpj = pumpkimModel.Cnpj,
            DataDeAtivaçãoDoFornecedor = pumpkimModel.DataDeAtivaçãoDoFornecedor,
            Mensalidade = pumpkimModel.Mensalidade,
            AutorizadoNoCda = pumpkimModel.AutorizadoNoCda
        };
    }

}
