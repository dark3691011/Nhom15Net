using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Nhom15.Migrations
{
    public partial class FirstMi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "phongBans",
                columns: table => new
                {
                    MaPB = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TenPB = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_phongBans", x => x.MaPB);
                });

            migrationBuilder.CreateTable(
                name: "nhanViens",
                columns: table => new
                {
                    MaNV = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TenNV = table.Column<string>(nullable: true),
                    Luong = table.Column<string>(nullable: true),
                    MaPB = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nhanViens", x => x.MaNV);
                    table.ForeignKey(
                        name: "FK_nhanViens_phongBans_MaPB",
                        column: x => x.MaPB,
                        principalTable: "phongBans",
                        principalColumn: "MaPB",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "bangChamCongs",
                columns: table => new
                {
                    MaBCC = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SoNgayLam = table.Column<int>(nullable: false),
                    Thang = table.Column<int>(nullable: false),
                    Luong = table.Column<string>(nullable: true),
                    MaNV = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bangChamCongs", x => x.MaBCC);
                    table.ForeignKey(
                        name: "FK_bangChamCongs_nhanViens_MaNV",
                        column: x => x.MaNV,
                        principalTable: "nhanViens",
                        principalColumn: "MaNV",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_bangChamCongs_MaNV",
                table: "bangChamCongs",
                column: "MaNV");

            migrationBuilder.CreateIndex(
                name: "IX_nhanViens_MaPB",
                table: "nhanViens",
                column: "MaPB");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bangChamCongs");

            migrationBuilder.DropTable(
                name: "nhanViens");

            migrationBuilder.DropTable(
                name: "phongBans");
        }
    }
}
