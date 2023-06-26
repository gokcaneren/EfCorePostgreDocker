using EfCorePostgreDocker.API.Entities;

namespace EfCorePostgreDocker.API.DataAccess.Repositories.Abstract
{
    public interface IBookRepository
    {
        List<Book> GetAll();
        Book? Get(int id);
        Book Add(Book entity);
        void Update(Book entity);
        void Delete(int id);
    }
}
