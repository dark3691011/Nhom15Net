using Microsoft.EntityFrameworkCore.Migrations;

namespace Nhom15.Migrations
{
    public partial class updatePhongBan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TenPB",
                table: "phongBans",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TenPB",
                table: "phongBans",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
