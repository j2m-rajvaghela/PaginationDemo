using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PaginationDemo.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "employee_pagination",
                columns: table => new
                {
                    employeeid = table.Column<long>(name: "employee_id", type: "Bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    employeename = table.Column<string>(name: "employee_name", type: "varchar(50)", nullable: false),
                    employeeage = table.Column<long>(name: "employee_age", type: "Bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employee_pagination", x => x.employeeid);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "employee_pagination");
        }
    }
}
