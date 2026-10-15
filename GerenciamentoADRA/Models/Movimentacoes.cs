using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GerenciamentoADRA.Models
{
    [Table("movimentacoes")]
public class Movimentacoes
{
    [Key] //Marca a chave primária
    [Column("movimentacoes_id")] //Liga a propriedade a coluna com o nome no Banco
    public int MovimentacoesId { get; set; }

    [ForeignKey(nameof(ProdutosId))] //Liga a propriedade a coluna com o nome no Banco
    public Produtos? Produto { get; set; }
    [Column("produtos_id")]
    public int ProdutosId { get; set; }

    [Column("movimentacoes_tipo")]
    public string MovimentacoesTipo { get; set; } = string.Empty;

    [Column("movimentacoes_quantidade")]
    public int MovimentacoesQuantidade { get; set; }

    [Column("movimentacoes_data")]
    public DateTime MovimentacoesData { get; set; }
}
}