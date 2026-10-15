using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GerenciamentoADRA.Models
{
    [Table("produtos")]
public class Produtos
{
    [Key] //Marca a chave primária
    [Column("produtos_id")] //Liga a propriedade a coluna com o nome no Banco
    public int ProdutosId { get; set; }
    
    [ForeignKey(nameof(CategoriasId))] //Liga a propriedade a coluna com o nome no Banco 
    public Categorias? Categorias { get; set; }
    [Column("categorias_id")]
    public int CategoriasId { get; set; }

    [Column("produtos_nome")]
    public string ProdutosNome { get; set; } = string.Empty;

    [Column("produtos_quantidade")]
    public int ProdutosQuantidade { get; set; }
}
}