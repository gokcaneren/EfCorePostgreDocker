using EfCorePostgreDocker.API.Entities.Abstract;

namespace EfCorePostgreDocker.API.Entities.Concrete
{
    public class Author : BaseEntity
    {
        public string Name { get; set; }
        public string Bio { get; set; }
        public int Age { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
