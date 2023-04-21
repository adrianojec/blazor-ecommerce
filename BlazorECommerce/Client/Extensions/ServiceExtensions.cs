using BlazorECommerce.Client.Services.Products;
using BlazorECommerce.Client.Services.Products.Interfaces;

namespace BlazorECommerce.Client.Extensions;

public static class ServiceExtensions
{
   public static IServiceCollection AddServices(this IServiceCollection services)
   {
      // Product Commands
      services.AddScoped<IProductService, ProductService>();

      return services;
   }
}
