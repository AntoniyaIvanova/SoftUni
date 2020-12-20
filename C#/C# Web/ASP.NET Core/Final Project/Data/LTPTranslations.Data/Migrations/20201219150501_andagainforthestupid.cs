namespace LTPTranslations.Data.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class andagainforthestupid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_OrderType_OrderTypeId",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderType",
                table: "OrderType");

            migrationBuilder.RenameTable(
                name: "OrderType",
                newName: "OrderTypes");

            migrationBuilder.RenameIndex(
                name: "IX_OrderType_IsDeleted",
                table: "OrderTypes",
                newName: "IX_OrderTypes_IsDeleted");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderTypes",
                table: "OrderTypes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_OrderTypes_OrderTypeId",
                table: "Orders",
                column: "OrderTypeId",
                principalTable: "OrderTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_OrderTypes_OrderTypeId",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderTypes",
                table: "OrderTypes");

            migrationBuilder.RenameTable(
                name: "OrderTypes",
                newName: "OrderType");

            migrationBuilder.RenameIndex(
                name: "IX_OrderTypes_IsDeleted",
                table: "OrderType",
                newName: "IX_OrderType_IsDeleted");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderType",
                table: "OrderType",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_OrderType_OrderTypeId",
                table: "Orders",
                column: "OrderTypeId",
                principalTable: "OrderType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
