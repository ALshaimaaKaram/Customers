using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Customers.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomersType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Insert_Date = table.Column<DateTime>(nullable: false),
                    User_ID = table.Column<int>(nullable: false),
                    User_Name = table.Column<string>(nullable: true),
                    Machine_IP = table.Column<string>(nullable: true),
                    Machine_Name = table.Column<string>(nullable: true),
                    User_ID_Update = table.Column<int>(nullable: false),
                    Update_Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomersType", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomersType");
        }
    }
}
