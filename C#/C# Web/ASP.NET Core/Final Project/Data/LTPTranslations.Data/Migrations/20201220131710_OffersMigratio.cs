namespace LTPTranslations.Data.Migrations
{
    using System;

    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class OffersMigratio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_DeliveryType_DeliveryTypeId",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DeliveryType",
                table: "DeliveryType");

            migrationBuilder.DropColumn(
                name: "AssignedOn",
                table: "TimeForFullfillments");

            migrationBuilder.DropColumn(
                name: "ReadyBy",
                table: "TimeForFullfillments");

            migrationBuilder.RenameTable(
                name: "DeliveryType",
                newName: "DeliveryTypes");

            migrationBuilder.RenameIndex(
                name: "IX_DeliveryType_IsDeleted",
                table: "DeliveryTypes",
                newName: "IX_DeliveryTypes_IsDeleted");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "TimeForFullfillments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "DeliveryTypes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DeliveryTypes",
                table: "DeliveryTypes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_DeliveryTypes_DeliveryTypeId",
                table: "Orders",
                column: "DeliveryTypeId",
                principalTable: "DeliveryTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_DeliveryTypes_DeliveryTypeId",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DeliveryTypes",
                table: "DeliveryTypes");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "TimeForFullfillments");

            migrationBuilder.RenameTable(
                name: "DeliveryTypes",
                newName: "DeliveryType");

            migrationBuilder.RenameIndex(
                name: "IX_DeliveryTypes_IsDeleted",
                table: "DeliveryType",
                newName: "IX_DeliveryType_IsDeleted");

            migrationBuilder.AddColumn<DateTime>(
                name: "AssignedOn",
                table: "TimeForFullfillments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ReadyBy",
                table: "TimeForFullfillments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<int>(
                name: "Name",
                table: "DeliveryType",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_DeliveryType",
                table: "DeliveryType",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_DeliveryType_DeliveryTypeId",
                table: "Orders",
                column: "DeliveryTypeId",
                principalTable: "DeliveryType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
