using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GerenciamentoADRA.Models
{   
    [Table("categorias")]
public class Categorias 
{
    [Key] //Marca a chave primária
    [Column("categorias_id")] //Liga a propriedade a coluna com o nome no Banco 
    public int CategoriasId { get; set; }

    [Column("categorias_nome")]
    public string CategoriasNome { get; set; } = string.Empty;
}
}