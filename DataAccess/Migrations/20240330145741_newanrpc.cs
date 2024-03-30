using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class newanrpc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AnrpcTable1",
                columns: new[] { "Id", "Balance", "Production", "RawMaterial", "Receipts" },
                values: new object[,]
                {
                    { 1, 1, "عام", "نافتا", 3 },
                    { 2, 1, "عام", "نافتا", 3 },
                    { 3, 1, "خاص", "مازوت", 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AnrpcTable1",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AnrpcTable1",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AnrpcTable1",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
