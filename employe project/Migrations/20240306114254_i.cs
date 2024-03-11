using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace employe_project.Migrations
{
    /// <inheritdoc />
    public partial class i : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeesDetails",
                table: "EmployeesDetails");

            migrationBuilder.RenameTable(
                name: "EmployeesDetails",
                newName: "Employeesdetails");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employeesdetails",
                table: "Employeesdetails",
                column: "EmployeeID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Employeesdetails",
                table: "Employeesdetails");

            migrationBuilder.RenameTable(
                name: "Employeesdetails",
                newName: "EmployeesDetails");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeesDetails",
                table: "EmployeesDetails",
                column: "EmployeeID");
        }
    }
}
