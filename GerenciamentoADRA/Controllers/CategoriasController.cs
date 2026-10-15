using GerenciamentoADRA.Data;
using GerenciamentoADRA.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GerenciamentoADRA.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    
        public class CategoriasController : ControllerBase
    {
        private readonly AdraContext _context;
        
        public CategoriasController(AdraContext context)
        {
            _context = context;
        }
    [HttpGet]
        public async Task<IActionResult> Listar()
        {
            var categorias = await _context.Categorias.ToListAsync();

            return Ok(categorias);
        }
    }
}