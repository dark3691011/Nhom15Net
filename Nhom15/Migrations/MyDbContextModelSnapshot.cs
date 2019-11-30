﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nhom15.Models;

namespace Nhom15.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Nhom15.Models.BangChamCong", b =>
                {
                    b.Property<int>("MaBCC")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MaNV");

                    b.Property<int>("SoNgayLam");

                    b.Property<int>("Thang");

                    b.HasKey("MaBCC");

                    b.HasIndex("MaNV");

                    b.ToTable("bangChamCongs");
                });

            modelBuilder.Entity("Nhom15.Models.NhanVien", b =>
                {
                    b.Property<int>("MaNV")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Luong");

                    b.Property<int>("MaPB");

                    b.Property<string>("TenNV")
                        .HasMaxLength(70);

                    b.HasKey("MaNV");

                    b.HasIndex("MaPB");

                    b.ToTable("nhanViens");
                });

            modelBuilder.Entity("Nhom15.Models.PhongBan", b =>
                {
                    b.Property<int>("MaPB")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TenPB")
                        .HasMaxLength(70);

                    b.HasKey("MaPB");

                    b.ToTable("phongBans");
                });

            modelBuilder.Entity("Nhom15.Models.BangChamCong", b =>
                {
                    b.HasOne("Nhom15.Models.NhanVien", "NhanVien")
                        .WithMany()
                        .HasForeignKey("MaNV")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Nhom15.Models.NhanVien", b =>
                {
                    b.HasOne("Nhom15.Models.PhongBan", "PhongBan")
                        .WithMany()
                        .HasForeignKey("MaPB")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
