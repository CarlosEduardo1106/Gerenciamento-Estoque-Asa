using System.ComponentModel.DataAnnotations;
namespace GerenciamentoADRA.Dtos
{
    public class MovimentacoesInputDto
    {
        [Required]
        public int ProdutosId { get; set; }

        [Required]
        [RegularExpression("^(Entrada|Saída)$", ErrorMessage = "O tipo deve ser Entrada ou Saída.")]
        public string MovimentacoesTipo { get; set; } = string.Empty;

        [Range(1, int.MaxValue, ErrorMessage = "A quantidade deve ser maior que zero.")]
        public int MovimentacoesQuantidade { get; set; }
    }
}