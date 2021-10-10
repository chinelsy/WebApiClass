using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiClass.Api.Migrations
{
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Balance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Balance", "CustomerId", "Number" },
                values: new object[] { new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"), 1000000m, new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), "3071977856" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Balance", "CustomerId", "Number" },
                values: new object[] { new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), 2000000m, new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), "3071988856" });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "Balance", "CustomerId", "Number" },
                values: new object[] { new Guid("87cdbca8-924d-43c0-e8de-024705846f7b"), 5000000m, new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"), "3079977856" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "AccountId", "Address", "DateOfBirth", "Email", "FullName", "Phone" },
                values: new object[] { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"), "United State Of Abakpa", new DateTime(1995, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "chikki@gmail.domain", "Chikki Dike", "08036777722" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "AccountId", "Address", "DateOfBirth", "Email", "FullName", "Phone" },
                values: new object[] { new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"), new Guid("80abbca8-664d-4b20-b5de-024705497d4a"), "10 College Road", new DateTime(1994, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "lucy@gmail.domain", "Lucy Dike", "07036777722" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "AccountId", "Address", "DateOfBirth", "Email", "FullName", "Phone" },
                values: new object[] { new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"), new Guid("87cdbca8-924d-43c0-e8de-024705846f7b"), "United State Of Olo", new DateTime(1993, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "nana@gmail.domain", "Nana Dike", "08136777722" });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_AccountId",
                table: "Customers",
                column: "AccountId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Accounts");
        }
    }
}
