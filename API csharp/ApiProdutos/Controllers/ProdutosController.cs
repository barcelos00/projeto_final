using Microsoft.AspNetCore.Mvc;

namespace ApiProdutos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutosController : ControllerBase
    {

        private static List<object> produtos = new List<object>()
        {
            new { id = 1, nome = "Notebook", preco = 3500 },
            new { id = 2, nome = "Mouse", preco = 80 },
            new { id = 3, nome = "Teclado", preco = 150 }
        };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(produtos);
        }
    }
}