using BlazorECommerce.Server.Application.Commands.Products;
using BlazorECommerce.Server.Application.Commands.Products.Interfaces;

namespace BlazorECommerce.Server.API.Extensions;

public static class CommandsServiceExtensions
{
  public static IServiceCollection AddCommandServices(this IServiceCollection services)
  {
    // Product Commands
    services.AddScoped<IGetProductsCommand, GetProductsCommand>();
    services.AddScoped<IGetProductCommand, GetProductCommand>();

    return services;
  }
}
