namespace EfCorePostgreDocker.API.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Genre { get; set; }
        public string AuthorName { get; set; }

        public Book(string name, string description, string genre, string authorName)
        {
            Name = name;
            Description = description;
            Genre = genre;
            AuthorName = authorName;
        }
    }
}
