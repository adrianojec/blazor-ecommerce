using BlazorECommerce.Shared.Core;
using BlazorECommerce.Shared.Models;

namespace BlazorECommerce.Server.Application.Commands.Products.Interfaces;

public interface IGetProductsCommand
{
   Task<Result<List<Product>>> ExecuteCommand();
}
