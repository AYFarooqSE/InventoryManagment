using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Inventory_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet("GetProductsAll")]
        public IActionResult GetProductsAll()
        {
            return Ok();
        }

        [HttpGet("GetProductByProductID/{ProductID:int}")]
        public IActionResult GetProductByProductID([FromRoute] int ProductID)
        {
            return Ok();
        }
    }
}
