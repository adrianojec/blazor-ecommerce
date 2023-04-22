using BlazorECommerce.Server.Application.Commands.Products.Interfaces;
using BlazorECommerce.Server.Persistence.Data;
using BlazorECommerce.Shared.Core;
using BlazorECommerce.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorECommerce.Server.Application.Commands.Products;

public class GetProductsCommand : IGetProductsCommand
{
   private readonly DataContext _context;
   public GetProductsCommand(DataContext context)
   {
      _context = context;
   }
   public async Task<Result<List<Product>>> ExecuteCommand()
   {
      var products = await _context.Products.ToListAsync();

      if (products.Count == 0) return Result<List<Product>>.Failure("No products available.");

      return Result<List<Product>>.Success(products);
   }
}
