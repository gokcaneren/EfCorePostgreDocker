using EfCorePostgreDocker.API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EfCorePostgreDocker.API.DataAccess.Configurations.Seeds
{
    public class BookSeed : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData(
                new Book("The Shining", "Jack and his family move into an isolated hotel with a violent past. Living in isolation, Jack begins to lose his sanity, which affects his family members.", "Horror/Mystery", "Stephen King"),

                new Book("The Da Vinci Code", "The Da Vinci Code is a 2003 mystery thriller novel by Dan Brown. It is Brown's second novel to include the character Robert Langdon: the first was his 2000 novel Angels & Demons.", "Mystery", "Dan Brown"),
                
                new Book("Diplomacy", "Diplomacy is a 1994 book written by former United States National Security Advisor and Secretary of State Henry Kissinger.", "History", "Henry Kissinger"));
        }
    }
}
