using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nhom15.Models
{
    public class MyDbContext : DbContext
    {

        public DbSet<PhongBan> phongBans { get; set; }
        public DbSet<NhanVien> nhanViens { get; set; }
        public DbSet<BangChamCong> bangChamCongs { get; set; }


        public MyDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
