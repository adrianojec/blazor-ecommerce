using System.Net.Http.Json;
using BlazorECommerce.Client.Services.Products.Interfaces;
using BlazorECommerce.Shared.Models;

namespace BlazorECommerce.Client.Services.Products;

public class ProductService : IProductService
{
   private readonly HttpClient _httpClient;

   public ProductService(HttpClient httpClient)
   {
      _httpClient = httpClient;
   }

   public async Task<List<Product>> GetAll()
   {
      return await _httpClient.GetFromJsonAsync<List<Product>>("api/Products");
   }

   public async Task<Product> GetById(int id)
   {
      return await _httpClient.GetFromJsonAsync<Product>($"api/Products/{id}");
   }
}
