using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Pumpkin.Entities;

[Table("BBAMBIENTESITEM1", Schema = "SMADMIN")]
public partial class Bbambientesitem1
{
    [Key]
    [Column("RECORD_KEY")]
    [StringLength(255)]
    [Unicode(false)]
    public string RecordKey { get; set; } = null!;

    [Column("SITE")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Site { get; set; }

    [Column("TIPO")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Tipo { get; set; }

    [Column("IDENTIFICADOR")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Identificador { get; set; }
}