using System.ComponentModel.DataAnnotations;
namespace GerenciamentoADRA.Dtos
{
    public class CategoriaInputDto
    {
        [Required]
        [StringLength(100)]
        public string CategoriaNome { get; set; } = string.Empty;
    }
}