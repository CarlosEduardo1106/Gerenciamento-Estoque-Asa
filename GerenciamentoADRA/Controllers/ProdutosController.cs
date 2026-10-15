using GerenciamentoADRA.Data;
using GerenciamentoADRA.Dtos;
using GerenciamentoADRA.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GerenciamentoADRA.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class ProdutosController : ControllerBase
    {
        private readonly AdraContext _context;

        public ProdutosController(AdraContext context)
        {
            _context = context;
        }
    //Retorna todos os produtos
    [HttpGet]
    public async Task<IActionResult> Listar()
        {
            var produtos = await _context.Produtos.ToListAsync();
            
            return Ok(produtos);
        }    
    //Buscar produto por ID    
    [HttpGet("{id}")]
    public async Task<IActionResult> Buscar(int id)
        {
            var produto = await _context.Produtos.FindAsync(id);

            if (produto == null)
            {
                return NotFound();
            }
        
        return Ok(produto);

        }
    //Cadastrar um Produto
    [HttpPost]
    public async Task<IActionResult> Criar(ProdutosInputDto dto)
        {
            var categoria = await _context.Categorias.FindAsync(dto.CategoriaId);

            if (categoria == null)
            {
                return BadRequest("Categoria Não Encontrada!");
            }
            var produto = new Produtos
            {
                CategoriasId = dto.CategoriaId,
                ProdutosNome = dto.ProdutosNome,
                ProdutosQuantidade = dto.ProdutosQuantidade 
            };

        _context.Produtos.Add(produto);

        await _context.SaveChangesAsync();

        return Ok(produto);
        }
    //Editar um produto


    }
}