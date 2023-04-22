using BlazorECommerce.Server.Application.Commands.Products.Interfaces;
using BlazorECommerce.Server.Persistence;
using BlazorECommerce.Shared.Core;
using BlazorECommerce.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Server.Application.Repositories.ProductRepositories;

namespace BlazorECommerce.Server.Application.Commands.Products;

public class GetProductsCommand : IGetProductsCommand
{
  private readonly IProductRepository _productRepository;

  public GetProductsCommand(IProductRepository productRepository)
  {
    _productRepository = productRepository;
  }

  public async Task<Result<List<Product>>> ExecuteCommand()
  {
    var products = await _productRepository.GetAll();

    if (products.Count == 0) return Result<List<Product>>.Failure("No products available.");

    return Result<List<Product>>.Success(products);
  }
}
