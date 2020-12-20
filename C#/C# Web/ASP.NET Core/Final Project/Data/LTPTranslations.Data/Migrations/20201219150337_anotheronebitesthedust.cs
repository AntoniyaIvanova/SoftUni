namespace LTPTranslations.Data.Migrations
{
    using System;

    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class anotheronebitesthedust : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Legalizations_Orders_OrderId",
                table: "Legalizations");

            migrationBuilder.DropForeignKey(
                name: "FK_Translations_Orders_OrderId",
                table: "Translations");

            migrationBuilder.DropIndex(
                name: "IX_Translations_OrderId",
                table: "Translations");

            migrationBuilder.DropIndex(
                name: "IX_Legalizations_OrderId",
                table: "Legalizations");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Translations");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Legalizations");

            migrationBuilder.AddColumn<int>(
                name: "DeliveryTypeId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LanguageFromId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LanguageFromTo",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LanguageToId",
                table: "Orders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderTypeId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "DeliveryType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderType", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_DeliveryTypeId",
                table: "Orders",
                column: "DeliveryTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_LanguageFromId",
                table: "Orders",
                column: "LanguageFromId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_LanguageToId",
                table: "Orders",
                column: "LanguageToId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderTypeId",
                table: "Orders",
                column: "OrderTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DeliveryType_IsDeleted",
                table: "DeliveryType",
                column: "IsDeleted");

            migrationBuilder.CreateIndex(
                name: "IX_OrderType_IsDeleted",
                table: "OrderType",
                column: "IsDeleted");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_DeliveryType_DeliveryTypeId",
                table: "Orders",
                column: "DeliveryTypeId",
                principalTable: "DeliveryType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_LanguagesFrom_LanguageFromId",
                table: "Orders",
                column: "LanguageFromId",
                principalTable: "LanguagesFrom",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_LanguagesTo_LanguageToId",
                table: "Orders",
                column: "LanguageToId",
                principalTable: "LanguagesTo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_OrderType_OrderTypeId",
                table: "Orders",
                column: "OrderTypeId",
                principalTable: "OrderType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_DeliveryType_DeliveryTypeId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_LanguagesFrom_LanguageFromId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_LanguagesTo_LanguageToId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_OrderType_OrderTypeId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "DeliveryType");

            migrationBuilder.DropTable(
                name: "OrderType");

            migrationBuilder.DropIndex(
                name: "IX_Orders_DeliveryTypeId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_LanguageFromId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_LanguageToId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_OrderTypeId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "DeliveryTypeId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "LanguageFromId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "LanguageFromTo",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "LanguageToId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrderTypeId",
                table: "Orders");

            migrationBuilder.AddColumn<string>(
                name: "OrderId",
                table: "Translations",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OrderId",
                table: "Legalizations",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Translations_OrderId",
                table: "Translations",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Legalizations_OrderId",
                table: "Legalizations",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Legalizations_Orders_OrderId",
                table: "Legalizations",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Translations_Orders_OrderId",
                table: "Translations",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
