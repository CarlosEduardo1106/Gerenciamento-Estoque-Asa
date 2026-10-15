using GerenciamentoADRA.Data;
using GerenciamentoADRA.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
 
namespace GerenciamentoADRA.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class MovimentacoesController : ControllerBase
    {
        private readonly AdraContext _context;

        public MovimentacoesController(AdraContext context)
        {
            _context = context;
        }
    [HttpGet]
    public async Task<IActionResult> Listar()
        {
            var movimentacoes = await _context.Movimentacoes.ToListAsync();

            return Ok(movimentacoes);
        }    
    }
}