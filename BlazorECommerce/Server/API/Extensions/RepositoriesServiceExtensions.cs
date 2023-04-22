using System;
using Server.Application.Repositories.ProductRepositories;

namespace BlazorECommerce.Server.API.Extensions
{
  public static class RepositoriesServiceExtensions
  {
    public static IServiceCollection AddRepositoryServices(this IServiceCollection services)
    {
      // Dependency Injection - Repository
      services.AddScoped<IProductRepository, ProductRepository>();

      return services;
    }
  }
}

