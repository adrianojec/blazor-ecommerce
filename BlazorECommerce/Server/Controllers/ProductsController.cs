using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers
{
   [ApiController]
   [Route("api/[controller]")]
   public class ProductsController : ControllerBase
   {
      private readonly DataContext _context;
      public ProductsController(DataContext context)
      {
         _context = context;
      }

      [HttpGet]
      public async Task<ActionResult<List<Product>>> GetAll()
      {
         var products = await _context.Products.ToListAsync();
         return Ok(products);
      }
   }
}