using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Pumpkin.Entities;

[Keyless]
[Table("EVT_PVTD_EVT", Schema = "DB2CDA")]
public class EvtPvtdEvt
{
    [Column("CD_PVTD")] public int CdPvtd { get; set; }

    [Column("CD_EVT")] public int CdEvt { get; set; }
}