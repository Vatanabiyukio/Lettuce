using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Pumpkin.Entities;

[Keyless]
[Table("DESCENTRALIZADOM1", Schema = "SMADMIN")]
public partial class Descentralizadom1
{
    [Column("LOGICAL_NAME")]
    [StringLength(60)]
    [Unicode(false)]
    public string? LogicalName { get; set; }

    [Column("TEMPORARIO")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Temporario { get; set; }

    [Column("SINISTRADO")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Sinistrado { get; set; }

    [Column("CONTRATO")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Contrato { get; set; }

    [Column("IDBB")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Idbb { get; set; }

    [Column("CIRCUITO_PRINCIPAL")]
    [StringLength(60)]
    [Unicode(false)]
    public string? CircuitoPrincipal { get; set; }

    [Column("CIRCUITO_CONTINGENCIA")]
    [StringLength(60)]
    [Unicode(false)]
    public string? CircuitoContingencia { get; set; }

    [Column("TIPO_CIRCUITO")]
    [StringLength(60)]
    [Unicode(false)]
    public string? TipoCircuito { get; set; }

    [Column("CONDICAO_ATUAL")]
    [StringLength(60)]
    [Unicode(false)]
    public string? CondicaoAtual { get; set; }

    [Column("UOR_SIGLA_PREDIO")]
    [StringLength(60)]
    [Unicode(false)]
    public string? UorSiglaPredio { get; set; }

    [Column("CATEGORIA_VELOCIDADE")]
    [StringLength(60)]
    [Unicode(false)]
    public string? CategoriaVelocidade { get; set; }

    [Column("TIPO_ACESSO_PRINCIPAL")]
    [StringLength(60)]
    [Unicode(false)]
    public string? TipoAcessoPrincipal { get; set; }

    [Column("TIPO_ACESSO_CONTINGENCIA")]
    [StringLength(60)]
    [Unicode(false)]
    public string? TipoAcessoContingencia { get; set; }

    [Column("IP_WAN_ROTEADOR_BB")]
    [StringLength(60)]
    [Unicode(false)]
    public string? IpWanRoteadorBb { get; set; }

    [Column("MASC_REDE_BB_OP")]
    [StringLength(60)]
    [Unicode(false)]
    public string? MascRedeBbOp { get; set; }

    [Column("IP_LAN_ROT_OP")]
    [StringLength(60)]
    [Unicode(false)]
    public string? IpLanRotOp { get; set; }

    [Column("MASC_LAN_ROT_OP")]
    [StringLength(60)]
    [Unicode(false)]
    public string? MascLanRotOp { get; set; }

    [Column("VLAN")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Vlan { get; set; }

    [Column("ENDERECO")]
    [StringLength(300)]
    [Unicode(false)]
    public string? Endereco { get; set; }

    [Column("MUNICIPIO")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Municipio { get; set; }

    [Column("ID_EQ_REDE")]
    [StringLength(60)]
    [Unicode(false)]
    public string? IdEqRede { get; set; }

    [Column("SITE")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Site { get; set; }

    [Column("IPV6")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Ipv6 { get; set; }

    [Column("DT_FIM_GARANTIA", TypeName = "DATE")]
    public DateTime? DtFimGarantia { get; set; }

    [Column("DT_FIM_DEPRECIACAO", TypeName = "DATE")]
    public DateTime? DtFimDepreciacao { get; set; }

    [Column("PAIS")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Pais { get; set; }

    [Column("VALOR_DEPRECIACAO")]
    [StringLength(60)]
    [Unicode(false)]
    public string? ValorDepreciacao { get; set; }

    [Column("ID_PAGADOR")]
    [StringLength(60)]
    [Unicode(false)]
    public string? IdPagador { get; set; }

    [Column("DT_CRIACAO", TypeName = "DATE")]
    public DateTime? DtCriacao { get; set; }

    [Column("DT_ALTERACAO", TypeName = "DATE")]
    public DateTime? DtAlteracao { get; set; }

    [Column("TIPO_ALTERACAO_FUNC_SITE", TypeName = "NUMBER")]
    public decimal? TipoAlteracaoFuncSite { get; set; }

    [Column("SYSMODCOUNT", TypeName = "FLOAT")]
    public decimal? Sysmodcount { get; set; }

    [Column("SYSMODUSER")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Sysmoduser { get; set; }

    [Column("SYSMODTIME", TypeName = "DATE")]
    public DateTime? Sysmodtime { get; set; }

    [Column("NOME")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Nome { get; set; }

    [Column("TIPO_SITE")]
    [StringLength(60)]
    [Unicode(false)]
    public string? TipoSite { get; set; }

    [Column("IP_LOOPBACK", TypeName = "CLOB")]
    public string? IpLoopback { get; set; }

    [Column("CNPJ")]
    [StringLength(30)]
    [Unicode(false)]
    public string? Cnpj { get; set; }

    [Column("MEIO_FISICO_ACESSO")]
    [StringLength(100)]
    [Unicode(false)]
    public string? MeioFisicoAcesso { get; set; }

    [Column("IPV4")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Ipv4 { get; set; }

    [Column("MASCARA_REDE_IPV4")]
    [StringLength(60)]
    [Unicode(false)]
    public string? MascaraRedeIpv4 { get; set; }

    [Column("GATEWAY_IPV4")]
    [StringLength(60)]
    [Unicode(false)]
    public string? GatewayIpv4 { get; set; }

    [Column("MASCARA_REDE_IPV6")]
    [StringLength(60)]
    [Unicode(false)]
    public string? MascaraRedeIpv6 { get; set; }

    [Column("GATEWAY_IPV6")]
    [StringLength(60)]
    [Unicode(false)]
    public string? GatewayIpv6 { get; set; }

    [Column("TIPO_CANAL")]
    [StringLength(100)]
    [Unicode(false)]
    public string? TipoCanal { get; set; }

    [Column("IP_GERENCIAMENTO")]
    [StringLength(60)]
    [Unicode(false)]
    public string? IpGerenciamento { get; set; }

    [Column("IP_INTERFACE_FORNECEDOR")]
    [StringLength(60)]
    [Unicode(false)]
    public string? IpInterfaceFornecedor { get; set; }

    [Column("NR_SERIE_ROTEADOR")]
    [StringLength(60)]
    [Unicode(false)]
    public string? NrSerieRoteador { get; set; }

    [Column("NOME_CONTRATO")]
    [StringLength(300)]
    [Unicode(false)]
    public string? NomeContrato { get; set; }

    [Column("FUNCIONARIO", TypeName = "BLOB")]
    public byte[]? Funcionario { get; set; }

    [Column("SITE_PONTA_A")]
    [StringLength(100)]
    [Unicode(false)]
    public string? SitePontaA { get; set; }

    [Column("SITE_PONTA_B")]
    [StringLength(100)]
    [Unicode(false)]
    public string? SitePontaB { get; set; }

    [Column("TIPO_TECNOLOGIA")]
    [StringLength(100)]
    [Unicode(false)]
    public string? TipoTecnologia { get; set; }

    [Column("ACAO")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Acao { get; set; }

    [Column("TRO", TypeName = "NUMBER")] public decimal? Tro { get; set; }

    [Column("SUBORDINADA")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Subordinada { get; set; }

    [Column("GRUPO")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Grupo { get; set; }

    [Column("PREFIXO_SOP")]
    [StringLength(60)]
    [Unicode(false)]
    public string? PrefixoSop { get; set; }

    [Column("SUBORDINADA_SOP")]
    [StringLength(60)]
    [Unicode(false)]
    public string? SubordinadaSop { get; set; }

    [Column("AMBIENTEMATRIZ", TypeName = "BLOB")]
    public byte[]? Ambientematriz { get; set; }

    [Column("TIPO_ALTERA_AMBIENTE", TypeName = "NUMBER")]
    public decimal? TipoAlteraAmbiente { get; set; }

    [Column("BB_VIRTUAL")]
    [StringLength(100)]
    [Unicode(false)]
    public string? BbVirtual { get; set; }

    [Column("MEIO_FISICO_ACES_CONT")]
    [StringLength(100)]
    [Unicode(false)]
    public string? MeioFisicoAcesCont { get; set; }

    [Column("BAIRRO")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Bairro { get; set; }

    [Column("PENDENCIAS")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Pendencias { get; set; }

    [Column("TIPO_CONEXAO")]
    [StringLength(60)]
    [Unicode(false)]
    public string? TipoConexao { get; set; }

    [Column("FUNC_SITE", TypeName = "CLOB")]
    public string? FuncSite { get; set; }

    [Column("BB_DESC_STATUS")]
    [StringLength(60)]
    [Unicode(false)]
    public string? BbDescStatus { get; set; }

    [Column("LOOPBACK")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Loopback { get; set; }

    [Column("DOMINIO")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Dominio { get; set; }

    [Column("VERSAO_SO")]
    [StringLength(60)]
    [Unicode(false)]
    public string? VersaoSo { get; set; }

    [Column("VERSAO_MATRIZ")]
    [StringLength(60)]
    [Unicode(false)]
    public string? VersaoMatriz { get; set; }

    [Column("USUARIOS")]
    [StringLength(300)]
    [Unicode(false)]
    public string? Usuarios { get; set; }

    [Column("HOSTNAME_USUARIO")]
    [StringLength(60)]
    [Unicode(false)]
    public string? HostnameUsuario { get; set; }

    [Column("IPV4_CONT")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Ipv4Cont { get; set; }

    [Column("GATEWAY_IPV4_CONT")]
    [StringLength(60)]
    [Unicode(false)]
    public string? GatewayIpv4Cont { get; set; }

    [Column("MASCARA_REDE_IPV4_CONT")]
    [StringLength(60)]
    [Unicode(false)]
    public string? MascaraRedeIpv4Cont { get; set; }

    [Column("LOOPBACK_CONT")]
    [StringLength(60)]
    [Unicode(false)]
    public string? LoopbackCont { get; set; }

    [Column("EMAIL_FORNECEDOR")]
    [StringLength(60)]
    [Unicode(false)]
    public string? EmailFornecedor { get; set; }

    [Column("TELEFONE_FORNECEDOR")]
    [StringLength(60)]
    [Unicode(false)]
    public string? TelefoneFornecedor { get; set; }

    [Column("MENSALIDADE_FORNECEDOR")]
    [StringLength(60)]
    [Unicode(false)]
    public string? MensalidadeFornecedor { get; set; }

    [Column("DATA_ATIVACAO_FORNECEDOR", TypeName = "DATE")]
    public DateTime? DataAtivacaoFornecedor { get; set; }

    [Column("DATA_ALTERACAO_FORNECEDOR", TypeName = "DATE")]
    public DateTime? DataAlteracaoFornecedor { get; set; }

    [Column("CONTRATANTE")]
    [StringLength(60)]
    [Unicode(false)]
    public string? Contratante { get; set; }

    [Column("FORNECEDOR_INTERNET")]
    [StringLength(100)]
    [Unicode(false)]
    public string? FornecedorInternet { get; set; }

    [Column("VALOR_MENSAL")]
    [StringLength(60)]
    [Unicode(false)]
    public string? ValorMensal { get; set; }

    [Column("TAXA_INSTALACAO")]
    [StringLength(60)]
    [Unicode(false)]
    public string? TaxaInstalacao { get; set; }

    [Column("TERCEIRIZADO")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Terceirizado { get; set; }

    [Column("COMPONENTE")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Componente { get; set; }

    [Column("FINALIDADE")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Finalidade { get; set; }

    [Column("FORNECEDOR")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Fornecedor { get; set; }

    [Column("QUANTIDADE_TRONCOS")]
    [StringLength(60)]
    [Unicode(false)]
    public string? QuantidadeTroncos { get; set; }

    [Column("UOR_FISCAL_SERVICO")]
    [StringLength(60)]
    [Unicode(false)]
    public string? UorFiscalServico { get; set; }
}