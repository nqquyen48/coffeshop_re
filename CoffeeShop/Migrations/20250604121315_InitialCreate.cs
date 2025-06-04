using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CoffeeShop.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Detail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsTrendingProduct = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Detail", "ImageUrl", "IsTrendingProduct", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Cà phê Mỹ", "https://media.istockphoto.com/id/2153935192/vi/anh/cup-of-coffee-isolated-on-white-background-file-contains-clipping-path.jpg?s=612x612&w=0&k=20&c=2KvztiUrbZCfAhdKM93t2Xkzfo_DHadA8CZqkIm-o6E=", true, "Americano", 25m },
                    { 2, "Cà phê Việt", "https://media.istockphoto.com/id/2153935192/vi/anh/cup-of-coffee-isolated-on-white-background-file-contains-clipping-path.jpg?s=612x612&w=0&k=20&c=2KvztiUrbZCfAhdKM93t2Xkzfo_DHadA8CZqkIm-o6E=", false, "Vietnam", 20m },
                    { 3, "Cà phê Anh", "https://media.istockphoto.com/id/2153935192/vi/anh/cup-of-coffee-isolated-on-white-background-file-contains-clipping-path.jpg?s=612x612&w=0&k=20&c=2KvztiUrbZCfAhdKM93t2Xkzfo_DHadA8CZqkIm-o6E=", false, "UK", 15m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
