using BlazorECommerce.Server.Application.Commands.Products.Interfaces;
using BlazorECommerce.Shared.Core;
using BlazorECommerce.Shared.Models;

using Microsoft.AspNetCore.Mvc;

namespace BlazorECommerce.Server.API.Controllers
{
   [ApiController]
   [Route("api/[controller]")]
   public class ProductsController : ControllerBase
   {
      private readonly IGetProductsCommand _getProductsCommand;
      public ProductsController(IGetProductsCommand getProductsCommand)
      {
         _getProductsCommand = getProductsCommand;
      }

      [HttpGet]
      public async Task<ActionResult<Result<List<Product>>>> GetAll()
      {
         var products = await _getProductsCommand.ExecuteCommand();

         if (!products.isSuccess) return BadRequest(products.Error);

         return Ok(products);
      }
   }
}