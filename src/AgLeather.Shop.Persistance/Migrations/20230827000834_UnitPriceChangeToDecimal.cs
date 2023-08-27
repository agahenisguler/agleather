using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgLeather.Shop.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class UnitPriceChangeToDecimal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "UNIT_PRICE",
                table: "PRODUCTS",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UNIT_PRICE",
                table: "PRODUCTS",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");
        }
    }
}
