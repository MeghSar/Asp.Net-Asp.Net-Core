using Microsoft.EntityFrameworkCore.Migrations;

namespace TimeSheetManagement.DAL.Migrations
{
    public partial class UpdatedModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "employee",
                columns: table => new
                {
                    EmpID = table.Column<int>(type: "int", nullable: false),
                    EmpName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpDesig = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpEmailID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpPsw = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmpDOJ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MgrID = table.Column<int>(type: "int", nullable: false),
                    CurrentProjectID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employee", x => x.EmpID);
                });

            migrationBuilder.CreateTable(
                name: "project",
                columns: table => new
                {
                    ProjectID = table.Column<int>(type: "int", nullable: false),
                    ProjectName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectDesc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_project", x => x.ProjectID);
                });

            migrationBuilder.CreateTable(
                name: "timesheet",
                columns: table => new
                {
                    TimeSheetID = table.Column<int>(type: "int", nullable: false),
                    ProjectID = table.Column<int>(type: "int", nullable: false),
                    EmpID = table.Column<int>(type: "int", nullable: false),
                    TimeFrom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimeTo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hours = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_timesheet", x => x.TimeSheetID);
                    table.ForeignKey(
                        name: "FK_timesheet_employee_EmpID",
                        column: x => x.EmpID,
                        principalTable: "employee",
                        principalColumn: "EmpID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_timesheet_project_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "project",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_timesheet_EmpID",
                table: "timesheet",
                column: "EmpID");

            migrationBuilder.CreateIndex(
                name: "IX_timesheet_ProjectID",
                table: "timesheet",
                column: "ProjectID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "timesheet");

            migrationBuilder.DropTable(
                name: "employee");

            migrationBuilder.DropTable(
                name: "project");
        }
    }
}
