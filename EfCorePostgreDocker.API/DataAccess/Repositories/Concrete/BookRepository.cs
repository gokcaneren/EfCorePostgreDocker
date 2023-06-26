using EfCorePostgreDocker.API.DataAccess.Context;
using EfCorePostgreDocker.API.DataAccess.Repositories.Abstract;
using EfCorePostgreDocker.API.Entities;

namespace EfCorePostgreDocker.API.DataAccess.Repositories.Concrete
{
    public class BookRepository : IBookRepository
    {
        private readonly AppDbContext _context;

        public BookRepository(AppDbContext context)
        {
            _context = context;
        }

        public Book Add(Book entity)
        {
            _context.Books.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public void Delete(int id)
        {
            Book? book = _context.Books.Find(id);

            if (book == null) { return; }

            _context.Books.Remove(book);
            _context.SaveChanges();
        }

        public Book? Get(int id)
        {
            Book? book = _context.Books.Find(id);

            if(book == null) { return null; }

            return book;
        }

        public List<Book> GetAll()
        {
            List<Book> books = _context.Books.ToList();

            return books;
        }

        public void Update(Book entity)
        {
            _context.Books.Update(entity);
            _context.SaveChanges();
        }
    }
}
