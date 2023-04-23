using BlazorECommerce.Shared.Models;

namespace BlazorECommerce.Client.Shared.ProductList
{
   public partial class ProductList
   {
      List<Product> Products { get; set; } = new List<Product>();
      string message { get; set; } = string.Empty;

      protected override async Task OnInitializedAsync()
      {
         Products = await ProductService.GetAll();
         if (Products.Count == 0) message = "No products available.";
      }
   }
}

