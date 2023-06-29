using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EfCorePostgreDocker.API.Migrations
{
    /// <inheritdoc />
    public partial class DbInitialize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Genre = table.Column<string>(type: "character varying(128)", maxLength: 128, nullable: false),
                    AuthorName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorName", "Description", "Genre", "Name" },
                values: new object[,]
                {
                    { 1, "Stephen King", "Jack and his family move into an isolated hotel with a violent past. Living in isolation, Jack begins to lose his sanity, which affects his family members.", "Horror/Mystery", "The Shining" },
                    { 2, "Dan Brown", "The Da Vinci Code is a 2003 mystery thriller novel by Dan Brown. It is Brown's second novel to include the character Robert Langdon: the first was his 2000 novel Angels & Demons.", "Mystery", "The Da Vinci Code" },
                    { 3, "Henry Kissinger", "Diplomacy is a 1994 book written by former United States National Security Advisor and Secretary of State Henry Kissinger.", "History", "Diplomacy" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
