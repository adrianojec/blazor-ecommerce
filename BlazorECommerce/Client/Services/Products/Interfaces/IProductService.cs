using BlazorECommerce.Shared.Models;

namespace BlazorECommerce.Client.Services.Products.Interfaces;

public interface IProductService
{
   Task<List<Product>> GetAll();
   Task<Product> GetById(int id);
}
