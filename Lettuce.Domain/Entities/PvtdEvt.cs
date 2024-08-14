using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pumpkin.Entities;

[Table("PVTD_EVT", Schema = "DB2CDA")]
public class PvtdEvt
{
    [Key] [Column("CD_PVTD")] public int CdPvtd { get; set; }

    [Column("NM_PVTD")] [StringLength(30)] public string NmPvtd { get; set; }

    [Column("CD_FMA_PVTD")] public int CdFmaPvtd { get; set; }
}