using BlazorECommerce.Server.Application.Context;

namespace BlazorECommerce.Server.Application.Repositories;

public class BaseRepository
{
   private readonly IDataContext _context;
   public BaseRepository(IDataContext context)
   {
      _context = context;
   }

   public async Task SaveChangesAsync()
   {
      await _context.SaveChangesAsync();
   }
}
