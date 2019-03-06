using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentApplication.Migrations
{
    public partial class updatedb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "lastname",
                table: "students",
                newName: "surname");

            migrationBuilder.RenameColumn(
                name: "classname",
                table: "students",
                newName: "schoolname");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "surname",
                table: "students",
                newName: "lastname");

            migrationBuilder.RenameColumn(
                name: "schoolname",
                table: "students",
                newName: "classname");
        }
    }
}
