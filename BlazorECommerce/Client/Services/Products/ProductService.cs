using System.Net.Http.Json;
using BlazorECommerce.Client.Services.Products.Interfaces;
using BlazorECommerce.Shared.Core;
using BlazorECommerce.Shared.Models;

namespace BlazorECommerce.Client.Services.Products;

public class ProductService : IProductService
{
   private readonly HttpClient _httpClient;
   public ProductService(HttpClient httpClient)
   {
      _httpClient = httpClient;
   }
   public List<Product> Products { get; set; } = new List<Product>();
   public async Task GetAll()
   {
      var result = await _httpClient.GetFromJsonAsync<Result<List<Product>>>("api/Products");
      if (result != null && result.Value != null)
         Products = result.Value;
   }
}
