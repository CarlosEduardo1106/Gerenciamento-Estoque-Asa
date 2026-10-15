using System.ComponentModel.DataAnnotations;
namespace GerenciamentoADRA.Dtos
{
    public class ProdutosInputDto
    {
        [Required]
        public int CategoriaId { get; set; }

        [Required]
        [StringLength(100)]
        public string ProdutosNome { get; set; } = string.Empty;

        [Range(0, int.MaxValue, ErrorMessage = "A quantidade não pode ser negativa.")]
        public int ProdutosQuantidade { get; set; }
    }
}