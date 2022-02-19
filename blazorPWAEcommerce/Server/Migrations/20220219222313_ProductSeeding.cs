using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace blazorPWAEcommerce.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "ProductDescription", "ProductName", "ProductPrice", "ProductUrl" },
                values: new object[] { 1, "The Hitchhiker's Guide to the Galaxy", "The Hitchhiker's Guide to the Galaxy", 9.99m, "/images/H2G2_UK_front_cover.jpg" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "ProductDescription", "ProductName", "ProductPrice", "ProductUrl" },
                values: new object[] { 2, "Ready Player One is a 2018 American science fiction adventure film based on Ernest Cline's novel of the same name. Directed by Steven Spielberg.", "Ready Player One", 19.99m, "/images/Ready_Player_One_(film).png" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "ProductDescription", "ProductName", "ProductPrice", "ProductUrl" },
                values: new object[] { 3, "Nineteen Eighty-Four (also stylised as 1984) is a dystopian social science fiction novel and cautionary tale written by English writer George Orwell", "", 29.99m, "/images/1984first.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3);
        }
    }
}
