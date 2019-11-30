using Microsoft.EntityFrameworkCore.Migrations;

namespace Nhom15.Migrations
{
    public partial class updatemodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Luong",
                table: "bangChamCongs");

            migrationBuilder.AlterColumn<double>(
                name: "Luong",
                table: "nhanViens",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Luong",
                table: "nhanViens",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AddColumn<string>(
                name: "Luong",
                table: "bangChamCongs",
                nullable: true);
        }
    }
}
