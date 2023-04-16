using System.Net.Http.Json;
using BlazorECommerce.Shared.Models;

namespace BlazorECommerce.Client.Shared
{
   public partial class ProductList
   {
      private static List<Product> Products = new List<Product>();

      protected override async Task OnInitializedAsync()
      {
         var result = await Http.GetFromJsonAsync<List<Product>>("api/Products");
         if (result != null)
            Products = result;
      }
   }
}

