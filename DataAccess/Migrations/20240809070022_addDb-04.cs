using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addDb04 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderaDetails",
                table: "OrderaDetails");

            migrationBuilder.RenameTable(
                name: "OrderaDetails",
                newName: "OrderDetails");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "OrderDetails",
                newName: "TravelId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderDetails",
                table: "OrderDetails");

            migrationBuilder.RenameTable(
                name: "OrderDetails",
                newName: "OrderaDetails");

            migrationBuilder.RenameColumn(
                name: "TravelId",
                table: "OrderaDetails",
                newName: "ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderaDetails",
                table: "OrderaDetails",
                column: "Id");
        }
    }
}
