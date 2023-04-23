using System;
using BlazorECommerce.Shared.Core;
using BlazorECommerce.Shared.Models;

namespace BlazorECommerce.Server.Application.Commands.Products.Interfaces
{
  public interface IGetProductCommand
  {
    Task<Result<Product>> ExecuteCommand(int id);
  }
}

