using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace ProductsAPI.Controllers
{
    [ApiController]
    [Route("api/v1/products")]
    public class ProductsController : ControllerBase
    {
        [HttpGet("get/{id:int}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public IActionResult Get(int id)
        {
            if(id > 0)
                return Ok(new {
                    Id = id,
                    Descricao = $"Produto: {id}"
                });

            return NotFound();
        }
    }
}
