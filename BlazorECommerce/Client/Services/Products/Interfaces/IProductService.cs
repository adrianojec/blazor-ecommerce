using BlazorECommerce.Shared.Models;

namespace BlazorECommerce.Client.Services.Products.Interfaces;

public interface IProductService
{
   List<Product> Products { get; set; }
   Task GetAll();
}
