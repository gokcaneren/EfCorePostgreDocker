using EfCorePostgreDocker.API.Entities.Abstract;

namespace EfCorePostgreDocker.API.Entities.Concrete
{
    public class Book : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
