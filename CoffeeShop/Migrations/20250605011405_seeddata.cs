using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeeShop.Migrations
{
    /// <inheritdoc />
    public partial class seeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Detail", "ImageUrl", "Name" },
                values: new object[] { "Name product", "https://insanelygoodrecipes.com/wp-content/uploads/2020/07/Cup-Of-Creamy-Coffee-1024x536.webp", "America" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Detail", "ImageUrl" },
                values: new object[] { "Vietnamese product", "https://insanelygoodrecipes.com/wp-content/uploads/2020/07/Cup-Of-Creamy-Coffee-1024x536.webp" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Detail", "ImageUrl", "Name" },
                values: new object[] { "UK product", "https://insanelygoodrecipes.com/wp-content/uploads/2020/07/Cup-Of-Creamy-Coffee-1024x536.webp", "United Kingdom" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Detail", "ImageUrl", "Name", "Price" },
                values: new object[] { "India product", "https://insanelygoodrecipes.com/wp-content/uploads/2020/07/Cup-Of-Creamy-Coffee-1024x536.webp", "India", 15m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Detail", "ImageUrl", "Name", "Price" },
                values: new object[] { "Russian product", "https://insanelygoodrecipes.com/wp-content/uploads/2020/07/Cup-Of-Creamy-Coffee-1024x536.webp", "Russian", 25m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Detail", "ImageUrl", "Name", "Price" },
                values: new object[] { "France product", "https://insanelygoodrecipes.com/wp-content/uploads/2020/07/Cup-Of-Creamy-Coffee-1024x536.webp", "France", 35m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Detail", "ImageUrl", "Name" },
                values: new object[] { "Cà phê Mỹ", "https://media.istockphoto.com/id/2153935192/vi/anh/cup-of-coffee-isolated-on-white-background-file-contains-clipping-path.jpg?s=612x612&w=0&k=20&c=2KvztiUrbZCfAhdKM93t2Xkzfo_DHadA8CZqkIm-o6E=", "Americano" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Detail", "ImageUrl" },
                values: new object[] { "Cà phê Việt", "https://cubes-asia.com/storage/blogs/2024-12/5-cach-pha-ca-phe-sua-tuoi-khong-duong-co.jpeg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Detail", "ImageUrl", "Name" },
                values: new object[] { "Cà phê Anh", "https://cubes-asia.com/storage/blogs/2024-12/5-cach-pha-ca-phe-sua-tuoi-khong-duong-co.jpeg", "UK" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Detail", "ImageUrl", "Name", "Price" },
                values: new object[] { "Cà phê Mỹ", "https://media.istockphoto.com/id/2153935192/vi/anh/cup-of-coffee-isolated-on-white-background-file-contains-clipping-path.jpg?s=612x612&w=0&k=20&c=2KvztiUrbZCfAhdKM93t2Xkzfo_DHadA8CZqkIm-o6E=", "Americano", 25m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Detail", "ImageUrl", "Name", "Price" },
                values: new object[] { "Cà phê Việt", "https://cubes-asia.com/storage/blogs/2024-12/5-cach-pha-ca-phe-sua-tuoi-khong-duong-co.jpeg", "Vietnam", 20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Detail", "ImageUrl", "Name", "Price" },
                values: new object[] { "Cà phê Anh", "https://cubes-asia.com/storage/blogs/2024-12/5-cach-pha-ca-phe-sua-tuoi-khong-duong-co.jpeg", "UK", 15m });
        }
    }
}
