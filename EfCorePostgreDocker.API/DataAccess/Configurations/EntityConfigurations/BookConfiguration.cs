using EfCorePostgreDocker.API.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EfCorePostgreDocker.API.DataAccess.Configurations.EntityConfigurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(x=>x.Id);
            builder.Property(x=>x.Id).UseIdentityColumn();

            builder.Property(x=>x.Name).IsRequired().HasMaxLength(128);
            builder.Property(x=>x.Genre).IsRequired().HasMaxLength(128);
            builder.Property(x=>x.Description).IsRequired();
            builder.Property(x => x.AuthorName).IsRequired();

        }
    }
}
