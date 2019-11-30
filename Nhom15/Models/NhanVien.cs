using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Nhom15.Models
{
    public class NhanVien
    {
        [Key]
        [Display(Name ="Mã nhân viên")]
        public int MaNV { get; set; }
        [Display(Name ="Tên nhân viên")]
        [StringLength(70, MinimumLength = 9, ErrorMessage = "Tên từ 9 đến 70 kí tự")]
        public string TenNV { get; set; }
        [Display(Name ="Lương")]
        public double Luong { get; set; }

        [Display(Name ="Mã phòng ban")]
        public int MaPB { get; set; }
        [ForeignKey("MaPB")]
        public PhongBan PhongBan { get; set; } 
    }
}
