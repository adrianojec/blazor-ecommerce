using BlazorECommerce.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorECommerce.Server.Application.Context;

public interface IDataContext
{
   public DbSet<Product> Products { get; set; }
   Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
