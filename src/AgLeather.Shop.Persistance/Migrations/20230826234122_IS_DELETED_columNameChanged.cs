using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgLeather.Shop.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class IS_DELETED_columNameChanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IS_DALETED",
                table: "CITIES",
                newName: "IS_DELETED");

            migrationBuilder.RenameColumn(
                name: "IS_DALETED",
                table: "ADDRESSES",
                newName: "IS_DELETED");

            migrationBuilder.RenameColumn(
                name: "IS_DALETED",
                table: "ACCOUNTS",
                newName: "IS_DELETED");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IS_DELETED",
                table: "CITIES",
                newName: "IS_DALETED");

            migrationBuilder.RenameColumn(
                name: "IS_DELETED",
                table: "ADDRESSES",
                newName: "IS_DALETED");

            migrationBuilder.RenameColumn(
                name: "IS_DELETED",
                table: "ACCOUNTS",
                newName: "IS_DALETED");
        }
    }
}
