using BlazorECommerce.Shared.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorECommerce.Client.Pages.ProductDetails
{
   public partial class ProductDetails
   {
      private Product? Product = null;
      private string message { get; set; } = string.Empty;

      [Parameter]
      public int Id { get; set; }

      protected override async Task OnParametersSetAsync()
      {
         Product = await ProductService.GetById(Id);
         if (Product == null) message = "Product not found.";
      }
   }
}