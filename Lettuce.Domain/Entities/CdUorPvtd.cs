using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Pumpkin.Entities;

[Keyless]
[Table("CD_UOR_PVTD", Schema = "DB2CDA")]
public class CdUorPvtd
{
    [Column("CD_PVTD")] public int CdPvtd { get; set; }

    [Column("CD_UOR")] public int CdUor { get; set; }
}