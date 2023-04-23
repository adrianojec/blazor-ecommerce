using BlazorECommerce.Server.Application.Context;
using BlazorECommerce.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Server.Application.Repositories.ProductRepositories;

public class ProductRepository : IProductRepository
{
  private readonly IDataContext _context;

  public ProductRepository(IDataContext context)
  {
    _context = context;
  }

  public async Task<List<Product>> GetAll()
  {
    return await _context.Products.ToListAsync();
  }

  public async Task<Product> GetById(int id)
  {
    return await _context.Products.FirstOrDefaultAsync(product => product.Id == id);
  }
}
