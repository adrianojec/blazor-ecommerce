namespace BlazorECommerce.Client.Shared.ProductList
{
   public partial class ProductList
   {
      protected override async Task OnInitializedAsync()
      {
         await ProductService.GetAll();
      }
   }
}

