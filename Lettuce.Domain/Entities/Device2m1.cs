using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Pumpkin.Entities;

[Keyless]
[Table("DEVICE2M1", Schema = "SMADMIN")]
[Index("LastUpdate", Name = "DEVICE2M1D6B01D2D")]
[Index("LogicalName", "Type", Name = "DEVIND_LT")]
[Index("Type", "LogicalName", Name = "IDX_DEVICE01")]
public partial class Device2m1
{
    [Column("LOGICAL_NAME")]
    [StringLength(200)]
    [Unicode(false)]
    public string LogicalName { get; set; } = null!;

    [Column("VENDOR")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Vendor { get; set; }

    [Column("PARENT")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Parent { get; set; }

    [Column("MODEL")]
    [StringLength(70)]
    [Unicode(false)]
    public string? Model { get; set; }

    [Column("NETWORK_NAME")]
    [StringLength(80)]
    [Unicode(false)]
    public string? NetworkName { get; set; }

    [Column("SERIAL_NO_")]
    [StringLength(60)]
    [Unicode(false)]
    public string? SerialNo { get; set; }

    [Column("LOCATION")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Location { get; set; }

    [Column("GROUP")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Group { get; set; }

    [Column("TYPE")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Type { get; set; }

    [Column("ESTATUS")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Estatus { get; set; }

    [Column("PSTATUS")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Pstatus { get; set; }

    [Column("ID")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Id { get; set; }

    [Column("LAST_UPDATE", TypeName = "DATE")]
    public DateTime? LastUpdate { get; set; }

    [Column("UPDATED_BY")]
    [StringLength(60)]
    [Unicode(false)]
    public string? UpdatedBy { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(80)]
    [Unicode(false)]
    public string? Description { get; set; }

    [Column("CONTAINER")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Container { get; set; }

    [Column("PCOUNT", TypeName = "FLOAT")] public decimal? Pcount { get; set; }

    [Column("NONDEVICE")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Nondevice { get; set; }

    [Column("PROBLEM_CATEGORY")]
    [StringLength(60)]
    [Unicode(false)]
    public string? ProblemCategory { get; set; }

    [Column("NETWORK_ADDRESS")]
    [StringLength(80)]
    [Unicode(false)]
    public string? NetworkAddress { get; set; }

    [Column("DOMAIN")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Domain { get; set; }

    [Column("PROTOCOL")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Protocol { get; set; }

    [Column("PROTOCOL_ADDR")]
    [StringLength(60)]
    [Unicode(false)]
    public string? ProtocolAddr { get; set; }

    [Column("CONTACT_NAME")]
    [StringLength(140)]
    [Unicode(false)]
    public string? ContactName { get; set; }

    [Column("PART_NO")]
    [StringLength(60)]
    [Unicode(false)]
    public string? PartNo { get; set; }

    [Column("ISTATUS")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Istatus { get; set; }

    [Column("VERSION")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Version { get; set; }

    [Column("ICOUNT", TypeName = "FLOAT")] public decimal? Icount { get; set; }

    [Column("SUBTYPE")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Subtype { get; set; }

    [Column("USER_ID")]
    [StringLength(60)]
    [Unicode(false)]
    public string? UserId { get; set; }

    [Column("LOCATION_CODE")]
    [StringLength(60)]
    [Unicode(false)]
    public string? LocationCode { get; set; }

    [Column("VENDOR_ID")]
    [StringLength(60)]
    [Unicode(false)]
    public string? VendorId { get; set; }

    [Column("COMMENTS", TypeName = "CLOB")]
    public string? Comments { get; set; }

    [Column("BUILDING")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Building { get; set; }

    [Column("FLOOR")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Floor { get; set; }

    [Column("ROOM")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Room { get; set; }

    [Column("CONTRACT_NO")]
    [StringLength(60)]
    [Unicode(false)]
    public string? ContractNo { get; set; }

    [Column("IS_DOWN")]
    [StringLength(1)]
    [Unicode(false)]
    public string? IsDown { get; set; }

    [Column("EVENT_UPDATED")]
    [StringLength(1)]
    [Unicode(false)]
    public string? EventUpdated { get; set; }

    [Column("SYSMODTIME", TypeName = "DATE")]
    public DateTime? Sysmodtime { get; set; }

    [Column("ASSET_TAG")]
    [StringLength(255)]
    [Unicode(false)]
    public string? AssetTag { get; set; }

    [Column("SYSMODCOUNT", TypeName = "FLOAT")]
    public decimal? Sysmodcount { get; set; }

    [Column("SYSMODUSER")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Sysmoduser { get; set; }

    [Column("CONTRACT_ID", TypeName = "FLOAT")]
    public decimal? ContractId { get; set; }

    [Column("PROBLEM_PRIORITY")]
    [StringLength(60)]
    [Unicode(false)]
    public string? ProblemPriority { get; set; }

    [Column("OPERATING_SYSTEM")]
    [StringLength(250)]
    [Unicode(false)]
    public string? OperatingSystem { get; set; }

    [Column("MTBF", TypeName = "FLOAT")] public decimal? Mtbf { get; set; }

    [Column("TOTAL_DOWNTIME", TypeName = "FLOAT")]
    public decimal? TotalDowntime { get; set; }

    [Column("INSTALL_DATE", TypeName = "DATE")]
    public DateTime? InstallDate { get; set; }

    [Column("SERVER_ID")]
    [StringLength(60)]
    [Unicode(false)]
    public string? ServerId { get; set; }

    [Column("BREAKS", TypeName = "FLOAT")] public decimal? Breaks { get; set; }

    [Column("DEVICE_SEVERITY")]
    [StringLength(1)]
    [Unicode(false)]
    public string? DeviceSeverity { get; set; }

    [Column("MANUFACTURER")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Manufacturer { get; set; }

    [Column("COST_CENTER")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CostCenter { get; set; }

    [Column("SITE_CATEGORY")]
    [StringLength(60)]
    [Unicode(false)]
    public string? SiteCategory { get; set; }

    [Column("COMPANY")]
    [StringLength(70)]
    [Unicode(false)]
    public string? Company { get; set; }

    [Column("PENDING_CHANGE")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PendingChange { get; set; }

    [Column("DEPT")]
    [StringLength(300)]
    [Unicode(false)]
    public string? Dept { get; set; }

    [Column("ORDER_NUMBER")]
    [StringLength(60)]
    [Unicode(false)]
    public string? OrderNumber { get; set; }

    [Column("ORDER_LINE_ITEM")]
    [StringLength(60)]
    [Unicode(false)]
    public string? OrderLineItem { get; set; }

    [Column("AC_CATEGORY")]
    [StringLength(60)]
    [Unicode(false)]
    public string? AcCategory { get; set; }

    [Column("NM_ID", TypeName = "FLOAT")] public decimal? NmId { get; set; }

    [Column("WMI_LASTSCAN", TypeName = "DATE")]
    public DateTime? WmiLastscan { get; set; }

    [Column("WMI_SCANDATE", TypeName = "DATE")]
    public DateTime? WmiScandate { get; set; }

    [Column("WMI_SCANRESULT")]
    [StringLength(40)]
    [Unicode(false)]
    public string? WmiScanresult { get; set; }

    [Column("WMI_TARGETNAME")]
    [StringLength(40)]
    [Unicode(false)]
    public string? WmiTargetname { get; set; }

    [Column("WMI_PROTOCOL_ADDR", TypeName = "CLOB")]
    public string? WmiProtocolAddr { get; set; }

    [Column("WMI_SCANNED")]
    [StringLength(1)]
    [Unicode(false)]
    public string? WmiScanned { get; set; }

    [Column("ASSIGNMENT")]
    [StringLength(2000)]
    [Unicode(false)]
    public string? Assignment { get; set; }

    [Column("SCANNER_DESCRIPTION")]
    [StringLength(40)]
    [Unicode(false)]
    public string? ScannerDescription { get; set; }

    [Column("SCANNER_VERSION")]
    [StringLength(40)]
    [Unicode(false)]
    public string? ScannerVersion { get; set; }

    [Column("LAST_SCAN", TypeName = "DATE")]
    public DateTime? LastScan { get; set; }

    [Column("LOCATION_COMMENTS", TypeName = "CLOB")]
    public string? LocationComments { get; set; }

    [Column("CONTACT_PHONE")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ContactPhone { get; set; }

    [Column("FIRST_NAME")]
    [StringLength(80)]
    [Unicode(false)]
    public string? FirstName { get; set; }

    [Column("TITLE")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Title { get; set; }

    [Column("EMAIL")]
    [StringLength(140)]
    [Unicode(false)]
    public string? Email { get; set; }

    [Column("SHIFT")]
    [StringLength(40)]
    [Unicode(false)]
    public string? Shift { get; set; }

    [Column("EXTENSION")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Extension { get; set; }

    [Column("SYSTEM_NAME")]
    [StringLength(50)]
    [Unicode(false)]
    public string? SystemName { get; set; }

    [Column("CORP_STRUCTURE")]
    [StringLength(300)]
    [Unicode(false)]
    public string? CorpStructure { get; set; }

    [Column("VIEW_NAME")]
    [StringLength(60)]
    [Unicode(false)]
    public string? ViewName { get; set; }

    [Column("END_POINT_1")]
    [StringLength(60)]
    [Unicode(false)]
    public string? EndPoint1 { get; set; }

    [Column("END_POINT_2")]
    [StringLength(60)]
    [Unicode(false)]
    public string? EndPoint2 { get; set; }

    [Column("TABLE_NAME")]
    [StringLength(60)]
    [Unicode(false)]
    public string? TableName { get; set; }

    [Column("OBJID")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Objid { get; set; }

    [Column("OUTAGE_ID", TypeName = "FLOAT")]
    public decimal? OutageId { get; set; }

    [Column("IP_ADDRESS")]
    [StringLength(250)]
    [Unicode(false)]
    public string? IpAddress { get; set; }

    [Column("MAC_ADDRESS")]
    [StringLength(40)]
    [Unicode(false)]
    public string? MacAddress { get; set; }

    [Column("SUBNET_MASK")]
    [StringLength(64)]
    [Unicode(false)]
    public string? SubnetMask { get; set; }

    [Column("ADDL", TypeName = "BLOB")] public byte[]? Addl { get; set; }

    [Column("DEFAULT_GATEWAY")]
    [StringLength(64)]
    [Unicode(false)]
    public string? DefaultGateway { get; set; }

    [Column("DOMAIN_SUFFIX")]
    [StringLength(30)]
    [Unicode(false)]
    public string? DomainSuffix { get; set; }

    [Column("TCPIP_NAME")]
    [StringLength(30)]
    [Unicode(false)]
    public string? TcpipName { get; set; }

    [Column("SCANS", TypeName = "BLOB")] public byte[]? Scans { get; set; }

    [Column("SUPPORT_CONTACTS", TypeName = "BLOB")]
    public byte[]? SupportContacts { get; set; }

    [Column("FEATURES", TypeName = "BLOB")]
    public byte[]? Features { get; set; }

    [Column("QUOTE")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Quote { get; set; }

    [Column("QUOTE_LINE_ITEM")]
    [StringLength(30)]
    [Unicode(false)]
    public string? QuoteLineItem { get; set; }

    [Column("TIME_ZONE")]
    [StringLength(90)]
    [Unicode(false)]
    public string? TimeZone { get; set; }

    [Column("JOINFILE_NAME")]
    [StringLength(50)]
    [Unicode(false)]
    public string? JoinfileName { get; set; }

    [Column("TEMP_TYPE")]
    [StringLength(40)]
    [Unicode(false)]
    public string? TempType { get; set; }

    [Column("CI_NAME")]
    [StringLength(200)]
    [Unicode(false)]
    public string? CiName { get; set; }

    [Column("FOLDER")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Folder { get; set; }

    [Column("ENVIRONMENT")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Environment { get; set; }

    [Column("SECURITYCLASSIFICATION")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Securityclassification { get; set; }

    [Column("SOXCLASSIFICATION")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Soxclassification { get; set; }

    [Column("EXPCCLASSIFICATION")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Expcclassification { get; set; }

    [Column("AUDITEDBY")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Auditedby { get; set; }

    [Column("AUDITPOLICY")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Auditpolicy { get; set; }

    [Column("AUDITSTATUS")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Auditstatus { get; set; }

    [Column("AUDITDESCREPENCY")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Auditdescrepency { get; set; }

    [Column("AUDITDATE", TypeName = "DATE")]
    public DateTime? Auditdate { get; set; }

    [Column("SCHEDULEDAUDIT", TypeName = "DATE")]
    public DateTime? Scheduledaudit { get; set; }

    [Column("OWNER")]
    [StringLength(2000)]
    [Unicode(false)]
    public string? Owner { get; set; }

    [Column("UCMDB_ID")]
    [StringLength(60)]
    [Unicode(false)]
    public string? UcmdbId { get; set; }

    [Column("BASELINE")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Baseline { get; set; }

    [Column("SUPPORT_GROUPS", TypeName = "CLOB")]
    public string? SupportGroups { get; set; }

    [Column("MONITORED")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Monitored { get; set; }

    [Column("SUPPORT_REMARKS", TypeName = "CLOB")]
    public string? SupportRemarks { get; set; }

    [Column("DEFAULT_IMPACT", TypeName = "FLOAT")]
    public decimal? DefaultImpact { get; set; }

    [Column("ALLOW_SUBSCRIPTION")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AllowSubscription { get; set; }

    [Column("CREATED_BY")]
    [StringLength(60)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    [Column("CREATED_BY_DATE", TypeName = "DATE")]
    public DateTime? CreatedByDate { get; set; }

    [Column("ADMIN_URLPORT")]
    [StringLength(60)]
    [Unicode(false)]
    public string? AdminUrlport { get; set; }

    [Column("CONFIG_FILE")]
    [StringLength(60)]
    [Unicode(false)]
    public string? ConfigFile { get; set; }

    [Column("BUSINESS_IMPORT_LEVEL")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BusinessImportLevel { get; set; }

    [Column("USEBASE", TypeName = "FLOAT")]
    public decimal? Usebase { get; set; }

    [Column("DISASTER_COVERAGE")]
    [StringLength(1)]
    [Unicode(false)]
    public string? DisasterCoverage { get; set; }

    [Column("RECORVERY_TIER")]
    [StringLength(60)]
    [Unicode(false)]
    public string? RecorveryTier { get; set; }

    [Column("PRIMARY_PATH")]
    [StringLength(60)]
    [Unicode(false)]
    public string? PrimaryPath { get; set; }

    [Column("DATA_CLASSIFICATION")]
    [StringLength(60)]
    [Unicode(false)]
    public string? DataClassification { get; set; }

    [Column("PRODUCT_VERSION")]
    [StringLength(60)]
    [Unicode(false)]
    public string? ProductVersion { get; set; }

    [Column("LICENSE_TYPE")]
    [StringLength(60)]
    [Unicode(false)]
    public string? LicenseType { get; set; }

    [Column("SERVICE_HOURS", TypeName = "FLOAT")]
    public decimal? ServiceHours { get; set; }

    [Column("NOTIFICATION_GROUPS", TypeName = "CLOB")]
    public string? NotificationGroups { get; set; }

    [Column("GRID")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Grid { get; set; }

    [Column("LISTENER_PORT")]
    [StringLength(60)]
    [Unicode(false)]
    public string? ListenerPort { get; set; }

    [Column("DATA_PRIVACY")]
    [StringLength(1)]
    [Unicode(false)]
    public string? DataPrivacy { get; set; }

    [Column("ADMIN_ID")]
    [StringLength(60)]
    [Unicode(false)]
    public string? AdminId { get; set; }

    [Column("ADMIN_PASSWORD")]
    [StringLength(60)]
    [Unicode(false)]
    public string? AdminPassword { get; set; }

    [Column("ITSERVICE")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Itservice { get; set; }

    [Column("BASELINE_VERSION")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BaselineVersion { get; set; }

    [Column("BASELINE_NONCOMPLIANT")]
    [StringLength(1)]
    [Unicode(false)]
    public string? BaselineNoncompliant { get; set; }

    [Column("BB_TIPO")]
    [StringLength(250)]
    [Unicode(false)]
    public string? BbTipo { get; set; }

    [Column("BB_NOME_APLICATIVO")]
    [StringLength(250)]
    [Unicode(false)]
    public string? BbNomeAplicativo { get; set; }

    [Column("BB_NOME_IC")]
    [StringLength(250)]
    [Unicode(false)]
    public string? BbNomeIc { get; set; }

    [Column("BB_RP_OPERACAO")]
    [StringLength(250)]
    [Unicode(false)]
    public string? BbRpOperacao { get; set; }

    [Column("BB_APELIDO", TypeName = "CLOB")]
    public string? BbApelido { get; set; }

    [Column("BB_SGDB")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbSgdb { get; set; }

    [Column("BB_OBJETO")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? BbObjeto { get; set; }

    [Column("BB_VIGENCIA")]
    [StringLength(250)]
    [Unicode(false)]
    public string? BbVigencia { get; set; }

    [Column("BB_GT_SERVICO")]
    [StringLength(250)]
    [Unicode(false)]
    public string? BbGtServico { get; set; }

    [Column("BB_FC_SERVICO")]
    [StringLength(250)]
    [Unicode(false)]
    public string? BbFcServico { get; set; }

    [Column("BB_CACHE_NVS")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbCacheNvs { get; set; }

    [Column("BB_CAP_ADQUIRIDA")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbCapAdquirida { get; set; }

    [Column("BB_DATA_AQUISICAO")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbDataAquisicao { get; set; }

    [Column("BB_NR_DEVICES")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbNrDevices { get; set; }

    [Column("BB_RFID")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbRfid { get; set; }

    [Column("BB_TIPO_DISCO")]
    [StringLength(250)]
    [Unicode(false)]
    public string? BbTipoDisco { get; set; }

    [Column("BB_TIPO_PLATAFORMA")]
    [StringLength(250)]
    [Unicode(false)]
    public string? BbTipoPlataforma { get; set; }

    [Column("BB_VALOR_AQUISICAO")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbValorAquisicao { get; set; }

    [Column("BB_CL_RESPONSAVEL")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbClResponsavel { get; set; }

    [Column("BB_USUARIO")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbUsuario { get; set; }

    [Column("BB_OPERADORA")]
    [StringLength(250)]
    [Unicode(false)]
    public string? BbOperadora { get; set; }

    [Column("BB_ASSISTENCIA_TECNICA")]
    [StringLength(250)]
    [Unicode(false)]
    public string? BbAssistenciaTecnica { get; set; }

    [Column("BB_CONEXAO")]
    [StringLength(250)]
    [Unicode(false)]
    public string? BbConexao { get; set; }

    [Column("BB_NR_PORTAS")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbNrPortas { get; set; }

    [Column("BB_VELOCIDADE")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbVelocidade { get; set; }

    [Column("BB_SERVICO")]
    [StringLength(250)]
    [Unicode(false)]
    public string? BbServico { get; set; }

    [Column("BB_EQ_OPERADORA")]
    [StringLength(250)]
    [Unicode(false)]
    public string? BbEqOperadora { get; set; }

    [Column("BB_EQ_USUARIO")]
    [StringLength(250)]
    [Unicode(false)]
    public string? BbEqUsuario { get; set; }

    [Column("BB_PT_EQ_DESTINO")]
    [StringLength(250)]
    [Unicode(false)]
    public string? BbPtEqDestino { get; set; }

    [Column("BB_CPU_TOTAL")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbCpuTotal { get; set; }

    [Column("BB_HMC")]
    [StringLength(250)]
    [Unicode(false)]
    public string? BbHmc { get; set; }

    [Column("BB_INT_ETHERNET")]
    [StringLength(250)]
    [Unicode(false)]
    public string? BbIntEthernet { get; set; }

    [Column("BB_INT_HBA")]
    [StringLength(250)]
    [Unicode(false)]
    public string? BbIntHba { get; set; }

    [Column("BB_INT_SCSI")]
    [StringLength(250)]
    [Unicode(false)]
    public string? BbIntScsi { get; set; }

    [Column("BB_NR_LPARS_TOTAL")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbNrLparsTotal { get; set; }

    [Column("PHYSICAL_MEM_TOTAL")]
    [StringLength(60)]
    [Unicode(false)]
    public string? PhysicalMemTotal { get; set; }

    [Column("BB_QTDE_ETHERNET")]
    [StringLength(260)]
    [Unicode(false)]
    public string? BbQtdeEthernet { get; set; }

    [Column("BB_QTDE_HBA")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbQtdeHba { get; set; }

    [Column("BB_QTDE_SCSI_SAS")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbQtdeScsiSas { get; set; }

    [Column("BB_QTDE_PROCESSADOR")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbQtdeProcessador { get; set; }

    [Column("OS_VERSION")]
    [StringLength(60)]
    [Unicode(false)]
    public string? OsVersion { get; set; }

    [Column("BB_SYSPLEX")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbSysplex { get; set; }

    [Column("BB_QTDE_PROC_LOGICOS")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbQtdeProcLogicos { get; set; }

    [Column("BB_NUCLEOS")]
    [StringLength(250)]
    [Unicode(false)]
    public string? BbNucleos { get; set; }

    [Column("BB_DATA_ATUALIZACAO_PCN")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbDataAtualizacaoPcn { get; set; }

    [Column("BB_NOME_PCN")]
    [StringLength(250)]
    [Unicode(false)]
    public string? BbNomePcn { get; set; }

    [Column("BB_RFID_TAG")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbRfidTag { get; set; }

    [Column("BB_FW_SERVICO")]
    [StringLength(250)]
    [Unicode(false)]
    public string? BbFwServico { get; set; }

    [Column("BB_NUMERO_SIGLA")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbNumeroSigla { get; set; }

    [Column("BB_GESTOR")]
    [StringLength(250)]
    [Unicode(false)]
    public string? BbGestor { get; set; }

    [Column("BB_CHAVE_FUNCIONARIO")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbChaveFuncionario { get; set; }

    [Column("BB_NUMERO_DEMANDA")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbNumeroDemanda { get; set; }

    [Column("BB_NUMERO_ACAO")]
    [StringLength(250)]
    [Unicode(false)]
    public string? BbNumeroAcao { get; set; }

    [Column("BB_NOME_BIBLIOTECA")]
    [StringLength(250)]
    [Unicode(false)]
    public string? BbNomeBiblioteca { get; set; }

    [Column("BB_LINGUAGEM")]
    [StringLength(250)]
    [Unicode(false)]
    public string? BbLinguagem { get; set; }

    [Column("BB_VERSAO")]
    [StringLength(250)]
    [Unicode(false)]
    public string? BbVersao { get; set; }

    [Column("BB_DATA_LIBERACAO")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbDataLiberacao { get; set; }

    [Column("BB_HORA_LIBERACAO")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbHoraLiberacao { get; set; }

    [Column("BB_NUMERO_REQUISICAO")]
    [StringLength(200)]
    [Unicode(false)]
    public string? BbNumeroRequisicao { get; set; }

    [Column("BB_NOME_SIGLA")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbNomeSigla { get; set; }

    [Column("BB_CPS_ATIVOS")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbCpsAtivos { get; set; }

    [Column("BB_ESCON")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbEscon { get; set; }

    [Column("BB_FICON")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbFicon { get; set; }

    [Column("BB_ICB")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbIcb { get; set; }

    [Column("BB_ICF")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbIcf { get; set; }

    [Column("BB_IFL")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbIfl { get; set; }

    [Column("BB_ISC")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbIsc { get; set; }

    [Column("BB_MIPS")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbMips { get; set; }

    [Column("BB_MSU")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbMsu { get; set; }

    [Column("BB_OSA")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbOsa { get; set; }

    [Column("BB_TKE")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbTke { get; set; }

    [Column("BB_ZAAP")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbZaap { get; set; }

    [Column("BB_ZIIP")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbZiip { get; set; }

    [Column("BB_PCI_CRYPTO")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbPciCrypto { get; set; }

    [Column("BB_DESCRICAO")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbDescricao { get; set; }

    [Column("BB_SER_PLATAFORMA")]
    [StringLength(2000)]
    [Unicode(false)]
    public string? BbSerPlataforma { get; set; }

    [Column("BB_SER_FONTE_SERVICO")]
    [StringLength(2000)]
    [Unicode(false)]
    public string? BbSerFonteServico { get; set; }

    [Column("BB_SER_CRITICIDADE")]
    [StringLength(2000)]
    [Unicode(false)]
    public string? BbSerCriticidade { get; set; }

    [Column("BB_SER_UNID_MEDIDA")]
    [StringLength(2000)]
    [Unicode(false)]
    public string? BbSerUnidMedida { get; set; }

    [Column("BB_SER_CUSTO_SERVICO")]
    [StringLength(2000)]
    [Unicode(false)]
    public string? BbSerCustoServico { get; set; }

    [Column("BB_SER_DISP_HORARIO")]
    [StringLength(2000)]
    [Unicode(false)]
    public string? BbSerDispHorario { get; set; }

    [Column("BB_SER_DISP_META")]
    [StringLength(2000)]
    [Unicode(false)]
    public string? BbSerDispMeta { get; set; }

    [Column("BB_SER_DISP_ESTIMADA")]
    [StringLength(2000)]
    [Unicode(false)]
    public string? BbSerDispEstimada { get; set; }

    [Column("BB_SER_TRO")]
    [StringLength(2000)]
    [Unicode(false)]
    public string? BbSerTro { get; set; }

    [Column("BB_SER_JANELA_MANUTENCAO")]
    [StringLength(2000)]
    [Unicode(false)]
    public string? BbSerJanelaManutencao { get; set; }

    [Column("BB_SER_SUPORTE_MEIO")]
    [StringLength(2000)]
    [Unicode(false)]
    public string? BbSerSuporteMeio { get; set; }

    [Column("BB_SER_SUPORTE_HORARIO")]
    [StringLength(2000)]
    [Unicode(false)]
    public string? BbSerSuporteHorario { get; set; }

    [Column("BB_SER_TEMPO_ATENDIMENTO")]
    [StringLength(2000)]
    [Unicode(false)]
    public string? BbSerTempoAtendimento { get; set; }

    [Column("BB_SER_CAPACIDADE")]
    [StringLength(2000)]
    [Unicode(false)]
    public string? BbSerCapacidade { get; set; }

    [Column("BB_SER_CAPACIDADE_ARMAZENAMEN")]
    [StringLength(2000)]
    [Unicode(false)]
    public string? BbSerCapacidadeArmazenamen { get; set; }

    [Column("BB_SER_PLANO_CONTINUIDADE")]
    [StringLength(2000)]
    [Unicode(false)]
    public string? BbSerPlanoContinuidade { get; set; }

    [Column("BB_SER_SEGURANCA")]
    [StringLength(2000)]
    [Unicode(false)]
    public string? BbSerSeguranca { get; set; }

    [Column("BB_SER_PERIODO_CRITICIDADE", TypeName = "CLOB")]
    public string? BbSerPeriodoCriticidade { get; set; }

    [Column("BB_SER_PROCESSO_REQUISICAO", TypeName = "CLOB")]
    public string? BbSerProcessoRequisicao { get; set; }

    [Column("BB_SER_SUBTIPO")]
    [StringLength(2000)]
    [Unicode(false)]
    public string? BbSerSubtipo { get; set; }

    [Column("BB_SER_AREAS_UTILIZAM_SERVICO", TypeName = "CLOB")]
    public string? BbSerAreasUtilizamServico { get; set; }

    [Column("BB_SER_CLIENTE_RESPO_SERVICO")]
    [StringLength(2000)]
    [Unicode(false)]
    public string? BbSerClienteRespoServico { get; set; }

    [Column("BB_SER_USUARIO")]
    [StringLength(2000)]
    [Unicode(false)]
    public string? BbSerUsuario { get; set; }

    [Column("BB_SER_NOME_ORIGINAL_SERVICO")]
    [StringLength(2000)]
    [Unicode(false)]
    public string? BbSerNomeOriginalServico { get; set; }

    [Column("BB_SYSNAME")]
    [StringLength(2000)]
    [Unicode(false)]
    public string? BbSysname { get; set; }

    [Column("BB_NR_ACAO_DEMANDA_EXECUTIVA")]
    [StringLength(2000)]
    [Unicode(false)]
    public string? BbNrAcaoDemandaExecutiva { get; set; }

    [Column("BB_AUT_CERTIFICADORA")]
    [StringLength(2000)]
    [Unicode(false)]
    public string? BbAutCertificadora { get; set; }

    [Column("BB_PLATAFORMA")]
    [StringLength(2000)]
    [Unicode(false)]
    public string? BbPlataforma { get; set; }

    [Column("BB_CODIFICACAO")]
    [StringLength(2000)]
    [Unicode(false)]
    public string? BbCodificacao { get; set; }

    [Column("BB_DATA_REQUISICAO", TypeName = "DATE")]
    public DateTime? BbDataRequisicao { get; set; }

    [Column("BB_DATA_VENCIMENTO", TypeName = "DATE")]
    public DateTime? BbDataVencimento { get; set; }

    [Column("BB_DATA_EMISSAO_RENOVACAO", TypeName = "DATE")]
    public DateTime? BbDataEmissaoRenovacao { get; set; }

    [Column("BB_GER_NUCLEO_RESP")]
    [StringLength(2000)]
    [Unicode(false)]
    public string? BbGerNucleoResp { get; set; }

    [Column("BB_MATRICULA_RESPONSAVEL")]
    [StringLength(2000)]
    [Unicode(false)]
    public string? BbMatriculaResponsavel { get; set; }

    [Column("BB_OBS", TypeName = "CLOB")] public string? BbObs { get; set; }

    [Column("BB_PERIODO_VALIDADE")]
    [StringLength(2000)]
    [Unicode(false)]
    public string? BbPeriodoValidade { get; set; }

    [Column("BB_TIPO_CERTIFICADO")]
    [StringLength(2000)]
    [Unicode(false)]
    public string? BbTipoCertificado { get; set; }

    [Column("BB_URL")]
    [StringLength(2000)]
    [Unicode(false)]
    public string? BbUrl { get; set; }

    [Column("BB_CAP_INSTALADA")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbCapInstalada { get; set; }

    [Column("BB_DATE_VIGENCIA", TypeName = "DATE")]
    public DateTime? BbDateVigencia { get; set; }

    [Column("BB_QTD_CONEXOES", TypeName = "NUMBER")]
    public decimal? BbQtdConexoes { get; set; }

    [Column("BB_PARTITION")]
    [StringLength(80)]
    [Unicode(false)]
    public string? BbPartition { get; set; }

    [Column("BB_FORMA_ENTREGA")]
    [StringLength(100)]
    [Unicode(false)]
    public string? BbFormaEntrega { get; set; }

    [Column("BB_ID_CIRCUITO")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbIdCircuito { get; set; }

    [Column("BB_SER_USUARIOS")]
    [StringLength(100)]
    [Unicode(false)]
    public string? BbSerUsuarios { get; set; }

    [Column("BB_CATEGORIA")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbCategoria { get; set; }

    [Column("BB_PREFIXO")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbPrefixo { get; set; }

    [Column("BB_SB")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbSb { get; set; }

    [Column("BB_NOMEDEPENDENCIA")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbNomedependencia { get; set; }

    [Column("BB_UF")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbUf { get; set; }

    [Column("BB_TIPOLOGIA")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbTipologia { get; set; }

    [Column("BB_SUBTIPO_REDE")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbSubtipoRede { get; set; }

    [Column("BB_OPERADORA_REMUS")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbOperadoraRemus { get; set; }

    [Column("BB_IP_ROTEADOR")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbIpRoteador { get; set; }

    [Column("BB_END_LOOPBACK")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbEndLoopback { get; set; }

    [Column("BB_NM_NUM")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbNmNum { get; set; }

    [Column("BB_CIRCUITO_ATIVO")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbCircuitoAtivo { get; set; }

    [Column("BB_TIPO_SERVICO")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbTipoServico { get; set; }

    [Column("BB_CONTRATO_REMUS")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbContratoRemus { get; set; }

    [Column("BB_TIPO_AGENCIA")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbTipoAgencia { get; set; }

    [Column("BB_SHELFS", TypeName = "NUMBER")]
    public decimal? BbShelfs { get; set; }

    [Column("BB_FILTROS_BANDA_C", TypeName = "NUMBER")]
    public decimal? BbFiltrosBandaC { get; set; }

    [Column("BB_FILTROS_BANDA_L", TypeName = "NUMBER")]
    public decimal? BbFiltrosBandaL { get; set; }

    [Column("BB_TRANSPONDER_2WCA", TypeName = "NUMBER")]
    public decimal? BbTransponder2wca { get; set; }

    [Column("BB_TRANSPONDER_5TCE", TypeName = "NUMBER")]
    public decimal? BbTransponder5tce { get; set; }

    [Column("BB_META_DISP_REQUERIDA")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbMetaDispRequerida { get; set; }

    [Column("BB_DISP_CALCULADA")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbDispCalculada { get; set; }

    [Column("BB_METO_CALCULO")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbMetoCalculo { get; set; }

    [Column("BB_TIPO_INFRAESTRUTURA")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbTipoInfraestrutura { get; set; }

    [Column("BB_AMBIENTE_OLD")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbAmbienteOld { get; set; }

    [Column("BB_MES_REFERENCIA")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbMesReferencia { get; set; }

    [Column("BB_POOL_GERENCIAMENTO")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbPoolGerenciamento { get; set; }

    [Column("BB_AUTOMATIC_RECOVERY")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbAutomaticRecovery { get; set; }

    [Column("BB_PRIORITY_RECOVERY", TypeName = "NUMBER")]
    public decimal? BbPriorityRecovery { get; set; }

    [Column("DEVICEMODTIME", TypeName = "DATE")]
    public DateTime? Devicemodtime { get; set; }

    [Column("HOSTNAME")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Hostname { get; set; }

    [Column("BB_CLASSE_CLUSTER")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbClasseCluster { get; set; }

    [Column("BB_PERFIL_IC", TypeName = "NUMBER")]
    public decimal? BbPerfilIc { get; set; }

    [Column("BB_MUDANCA_PROCESSADA")]
    [StringLength(1)]
    [Unicode(false)]
    public string? BbMudancaProcessada { get; set; }

    [Column("BB_ENVIO_CTL")]
    [StringLength(1)]
    [Unicode(false)]
    public string? BbEnvioCtl { get; set; }

    [Column("BB_DT_ENVIO_CTL", TypeName = "DATE")]
    public DateTime? BbDtEnvioCtl { get; set; }

    [Column("BB_ARQUITETURA")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbArquitetura { get; set; }

    [Column("SERVICE_STATUS_NAME")]
    [StringLength(60)]
    [Unicode(false)]
    public string? ServiceStatusName { get; set; }

    [Column("DISPLAY_NAME")]
    [StringLength(200)]
    [Unicode(false)]
    public string? DisplayName { get; set; }

    [Column("SERVICE_LIFECYCLE")]
    [StringLength(60)]
    public string? ServiceLifecycle { get; set; }

    [Column("COSTPERHOUR", TypeName = "FLOAT")]
    public decimal? Costperhour { get; set; }

    [Column("CURRENCY")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Currency { get; set; }

    [Column("DML_LINK")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? DmlLink { get; set; }

    [Column("BB_ENDERECO")]
    [StringLength(2000)]
    [Unicode(false)]
    public string? BbEndereco { get; set; }

    [Column("BB_CONDICAO_ATUAL")]
    [StringLength(200)]
    [Unicode(false)]
    public string? BbCondicaoAtual { get; set; }

    [Column("BB_TIPO_CIRCUITO")]
    [StringLength(200)]
    [Unicode(false)]
    public string? BbTipoCircuito { get; set; }

    [Column("BB_OBJETO_IC")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? BbObjetoIc { get; set; }

    [Column("BB_VIGENCIA_INICIO_IC", TypeName = "DATE")]
    public DateTime? BbVigenciaInicioIc { get; set; }

    [Column("BB_VIGENCIA_FIM_IC", TypeName = "DATE")]
    public DateTime? BbVigenciaFimIc { get; set; }

    [Column("BB_NUMERO_CONTRATO", TypeName = "NUMBER")]
    public decimal? BbNumeroContrato { get; set; }

    [Column("BB_FISC_SERVICO")]
    [StringLength(100)]
    [Unicode(false)]
    public string? BbFiscServico { get; set; }

    [Column("BB_GEST_SERVICO")]
    [StringLength(100)]
    [Unicode(false)]
    public string? BbGestServico { get; set; }

    [Column("BB_SOLUCAO")]
    [StringLength(200)]
    [Unicode(false)]
    public string? BbSolucao { get; set; }

    [Column("BB_EQ_SUPORTE_NIVEL2")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbEqSuporteNivel2 { get; set; }

    [Column("BB_EQ_SUPORTE_NIVEL3")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbEqSuporteNivel3 { get; set; }

    [Column("BB_CAMADA")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbCamada { get; set; }

    [Column("BB_DISCO")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbDisco { get; set; }

    [Column("BB_MEMORIA")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbMemoria { get; set; }

    [Column("BB_PROCESSADOR")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbProcessador { get; set; }

    [Column("BB_TAGS", TypeName = "CLOB")] public string? BbTags { get; set; }

    [Column("BB_ULTIMO_DISCOVERY")]
    [Precision(6)]
    public DateTime? BbUltimoDiscovery { get; set; }

    [Column("BB_FIRMWARE")]
    [StringLength(100)]
    [Unicode(false)]
    public string? BbFirmware { get; set; }

    [Column("CURRENT_PHASE")]
    [StringLength(60)]
    [Unicode(false)]
    public string? CurrentPhase { get; set; }

    [Column("BB_HOST_FISICO")]
    [StringLength(100)]
    [Unicode(false)]
    public string? BbHostFisico { get; set; }

    [Column("BB_EMAIL_SUPORTE", TypeName = "CLOB")]
    public string? BbEmailSuporte { get; set; }

    [Column("SERVICO_VINCULADO")]
    [StringLength(60)]
    [Unicode(false)]
    public string? ServicoVinculado { get; set; }

    [Column("SERVICO_NEGOCIO")]
    [StringLength(60)]
    [Unicode(false)]
    public string? ServicoNegocio { get; set; }

    [Column("SERVICO_IIB")]
    [StringLength(300)]
    [Unicode(false)]
    public string? ServicoIib { get; set; }

    [Column("SERVICO_DESCRICAO")]
    [StringLength(2000)]
    [Unicode(false)]
    public string? ServicoDescricao { get; set; }
}