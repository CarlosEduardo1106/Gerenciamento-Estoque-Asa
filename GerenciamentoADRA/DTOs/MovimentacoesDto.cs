namespace GerenciamentoADRA.Dtos
{
    public class MovimentacoesDto
    {
        public int Id { get; set; }
        public int ProdutosId { get; set; }
        public string MovimentacoesTipo { get; set; } = string.Empty;
        public int MovimentacoesQuantidade { get; set; }
        public DateTime MovimentacoesData { get; set; }
    }
}