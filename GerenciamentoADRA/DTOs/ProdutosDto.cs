namespace GerenciamentoADRA.Dtos
{
    public class ProdutosDto
    {
        public int Id { get; set; }
        public int CategoriaId { get; set; }
        public string CategoriaNome { get; set; } = string.Empty;
        public string ProdutoNome { get; set; } = string.Empty;
        public int ProdutoQuantidade { get; set; }
    }
}