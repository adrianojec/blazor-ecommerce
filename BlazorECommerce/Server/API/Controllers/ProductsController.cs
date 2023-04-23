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
      private readonly IGetProductCommand _getProductCommand;

      public ProductsController
      (
        IGetProductsCommand getProductsCommand,
        IGetProductCommand getProductCommand
      )
      {
         _getProductsCommand = getProductsCommand;
         _getProductCommand = getProductCommand;
      }

      [HttpGet]
      public async Task<ActionResult<Result<List<Product>>>> GetAll()
      {
         var products = await _getProductsCommand.ExecuteCommand();

         if (!products.isSuccess) return BadRequest(products.Error);

         return Ok(products.Value);
      }

      [HttpGet("{id}")]
      public async Task<ActionResult<Result<Product>>> GetById([FromRoute] int id)
      {
         var product = await _getProductCommand.ExecuteCommand(id);
         if (!product.isSuccess) return BadRequest(product.Error);

         return Ok(product.Value);
      }
   }
}