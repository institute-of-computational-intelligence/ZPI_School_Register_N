using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolRegister.DAL.Migrations
{
    public partial class Interfaces : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Group",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Group",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
