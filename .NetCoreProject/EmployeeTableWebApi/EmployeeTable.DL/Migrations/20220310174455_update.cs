using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeTable.DL.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "empmodel",
                columns: table => new
                {
                    EmpID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmpContact = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmpEmailID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmpAddress = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_empmodel", x => x.EmpID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "empmodel");
        }
    }
}
