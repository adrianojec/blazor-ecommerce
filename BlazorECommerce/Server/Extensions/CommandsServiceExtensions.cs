using BlazorECommerce.Server.Commands.Products;
using BlazorECommerce.Server.Commands.Products.Interfaces;

namespace BlazorECommerce.Server.Extensions;

public static class CommandsServiceExtensions
{
   public static IServiceCollection AddCommandServices(this IServiceCollection services)
   {
      // Product Commands
      services.AddScoped<IGetProductsCommand, GetProductsCommand>();

      return services;
   }
}
