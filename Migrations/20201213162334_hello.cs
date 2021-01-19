using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VacationDBASPDesignPattern.Migrations
{
    public partial class hello : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    DeptId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeptName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.DeptId);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmpId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    StartingDate = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    DeptID = table.Column<int>(nullable: false),
                    DepartmentsDeptId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmpId);
                    table.ForeignKey(
                        name: "FK_Employee_Department_DepartmentsDeptId",
                        column: x => x.DepartmentsDeptId,
                        principalTable: "Department",
                        principalColumn: "DeptId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DaysTaken",
                columns: table => new
                {
                    DTId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpId = table.Column<int>(nullable: false),
                    EmployeesEmpId = table.Column<int>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    VacationType = table.Column<string>(nullable: true),
                    CDay = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DaysTaken", x => x.DTId);
                    table.ForeignKey(
                        name: "FK_DaysTaken_Employee_EmployeesEmpId",
                        column: x => x.EmployeesEmpId,
                        principalTable: "Employee",
                        principalColumn: "EmpId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RequestDate",
                columns: table => new
                {
                    RDId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpId = table.Column<int>(nullable: false),
                    EmployeesEmpId = table.Column<int>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    VacationType = table.Column<string>(nullable: true),
                    CDay = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestDate", x => x.RDId);
                    table.ForeignKey(
                        name: "FK_RequestDate_Employee_EmployeesEmpId",
                        column: x => x.EmployeesEmpId,
                        principalTable: "Employee",
                        principalColumn: "EmpId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DaysTaken_EmployeesEmpId",
                table: "DaysTaken",
                column: "EmployeesEmpId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_DepartmentsDeptId",
                table: "Employee",
                column: "DepartmentsDeptId");

            migrationBuilder.CreateIndex(
                name: "IX_RequestDate_EmployeesEmpId",
                table: "RequestDate",
                column: "EmployeesEmpId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DaysTaken");

            migrationBuilder.DropTable(
                name: "RequestDate");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Department");
        }
    }
}
