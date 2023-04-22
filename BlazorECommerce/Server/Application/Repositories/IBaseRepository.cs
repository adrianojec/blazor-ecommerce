namespace Server.Application.Repositories;

public interface IBaseRepository<T> where T : class
{
   Task<List<T>> GetAll();
}
