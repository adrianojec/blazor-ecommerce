using System;
using BlazorECommerce.Server.Application.Commands.Products.Interfaces;
using BlazorECommerce.Shared.Core;
using BlazorECommerce.Shared.Models;
using Server.Application.Repositories.ProductRepositories;

namespace BlazorECommerce.Server.Application.Commands.Products
{
  public class GetProductCommand : IGetProductCommand
  {
    private readonly IProductRepository _productRepository;

    public GetProductCommand(IProductRepository productRepository)
    {
      _productRepository = productRepository;
    }

    public async Task<Result<Product>> ExecuteCommand(int id)
    {
      var product = await _productRepository.GetById(id);
      if (product == null) return Result<Product>.Failure("Product not found.");
      return Result<Product>.Success(product);
    }
  }
}

