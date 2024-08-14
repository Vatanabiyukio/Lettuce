using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Pumpkin.Entities;

[Keyless]
[Table("BBMSTF500FM1", Schema = "SMADMIN")]
[Index("Coduor", "Codior", Name = "BBMSTF500FM14ECCA3D8", IsUnique = true)]
public partial class Bbmstf500fm1
{
    [Column("CODUOR", TypeName = "NUMBER")]
    public decimal? Coduor { get; set; }

    [Column("CODIOR", TypeName = "NUMBER")]
    public decimal? Codior { get; set; }

    [Column("NOMEUORREDUZIDO")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Nomeuorreduzido { get; set; }

    [Column("NOMEUOR")]
    [StringLength(300)]
    [Unicode(false)]
    public string? Nomeuor { get; set; }

    [Column("DATACRIACAO", TypeName = "DATE")]
    public DateTime? Datacriacao { get; set; }

    [Column("DATAENCERRAMENTO", TypeName = "DATE")]
    public DateTime? Dataencerramento { get; set; }

    [Column("DATAATUALIZACAO", TypeName = "DATE")]
    public DateTime? Dataatualizacao { get; set; }

    [Column("CODRESPONSAVELATUALIZACAO")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Codresponsavelatualizacao { get; set; }

    [Column("CODTIPOLOGIA", TypeName = "NUMBER")]
    public decimal? Codtipologia { get; set; }

    [Column("MCI", TypeName = "NUMBER")] public decimal? Mci { get; set; }

    [Column("CNPJ")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Cnpj { get; set; }

    [Column("SIGLA")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Sigla { get; set; }

    [Column("INDRESTRICAOACESSO")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Indrestricaoacesso { get; set; }

    [Column("INDPIONEIRAMUNICIPIO")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Indpioneiramunicipio { get; set; }

    [Column("DATAINICIOATIVIDADES", TypeName = "DATE")]
    public DateTime? Datainicioatividades { get; set; }

    [Column("DATAPREVISTAENCERRAMENTO", TypeName = "DATE")]
    public DateTime? Dataprevistaencerramento { get; set; }

    [Column("MCILOCALIZACAO", TypeName = "NUMBER")]
    public decimal? Mcilocalizacao { get; set; }

    [Column("PREFIXO", TypeName = "NUMBER")]
    public decimal? Prefixo { get; set; }

    [Column("SUBORDINADA", TypeName = "NUMBER")]
    public decimal? Subordinada { get; set; }

    [Column("DIGITOVERIFICADORPREFIXO")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Digitoverificadorprefixo { get; set; }

    [Column("CODPAIS", TypeName = "NUMBER")]
    public decimal? Codpais { get; set; }

    [Column("CEP")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Cep { get; set; }

    [Column("LOGRADOURO")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Logradouro { get; set; }

    [Column("COMPLOGRADOURO")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Complogradouro { get; set; }

    [Column("PONTOREFERENCIA")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Pontoreferencia { get; set; }

    [Column("BAIRRO")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Bairro { get; set; }

    [Column("CODMUNICIPIO", TypeName = "NUMBER")]
    public decimal? Codmunicipio { get; set; }

    [Column("NOMEMUNICIPIO")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Nomemunicipio { get; set; }

    [Column("SIGLAUF")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Siglauf { get; set; }

    [Column("INDNACIONALIDADE")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Indnacionalidade { get; set; }

    [Column("LATITUDE")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Latitude { get; set; }

    [Column("LONGITUDE")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Longitude { get; set; }

    [Column("CODTIPOUORVINCULADORA", TypeName = "NUMBER")]
    public decimal? Codtipouorvinculadora { get; set; }

    [Column("UORVINCULADORA", TypeName = "NUMBER")]
    public decimal? Uorvinculadora { get; set; }

    [Column("CODOUTORGA", TypeName = "NUMBER")]
    public decimal? Codoutorga { get; set; }

    [Column("CODSITUACAOOUTORGA", TypeName = "NUMBER")]
    public decimal? Codsituacaooutorga { get; set; }

    [Column("DATAAUTORIZACAOOUTORGA", TypeName = "DATE")]
    public DateTime? Dataautorizacaooutorga { get; set; }

    [Column("DATAVENCIMENTOOUTORGA", TypeName = "DATE")]
    public DateTime? Datavencimentooutorga { get; set; }

    [Column("CODTIPOAGRUPAMENTO", TypeName = "NUMBER")]
    public decimal? Codtipoagrupamento { get; set; }

    [Column("CODNATUREZAAGRUPAMENTO", TypeName = "NUMBER")]
    public decimal? Codnaturezaagrupamento { get; set; }

    [Column("CODNIVEL", TypeName = "NUMBER")]
    public decimal? Codnivel { get; set; }

    [Column("DATANIVEL", TypeName = "DATE")]
    public DateTime? Datanivel { get; set; }

    [Column("CODPILAR", TypeName = "NUMBER")]
    public decimal? Codpilar { get; set; }

    [Column("CODPERFIL", TypeName = "NUMBER")]
    public decimal? Codperfil { get; set; }

    [Column("DATAINICIOAUTONOMIACONTABIL", TypeName = "DATE")]
    public DateTime? Datainicioautonomiacontabil { get; set; }

    [Column("DATAFIMAUTONOMIACONTABIL", TypeName = "DATE")]
    public DateTime? Datafimautonomiacontabil { get; set; }

    [Column("CODCAMARACOMPENSACAO", TypeName = "NUMBER")]
    public decimal? Codcamaracompensacao { get; set; }

    [Column("CODCOMPE", TypeName = "NUMBER")]
    public decimal? Codcompe { get; set; }

    [Column("INDESPACOESTILO")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Indespacoestilo { get; set; }

    [Column("NOMENIVEL")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Nomenivel { get; set; }

    [Column("NOMETIPOLOGIA")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Nometipologia { get; set; }

    [Column("EMAIL")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Email { get; set; }

    [Column("QTDFUNCIONARIOS", TypeName = "NUMBER")]
    public decimal? Qtdfuncionarios { get; set; }
}