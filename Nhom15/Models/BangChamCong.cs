using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Nhom15.Models
{
    public class BangChamCong
    {
        [Key]
        [Display(Name="Mã bảng chấm công")]
        public int MaBCC { get; set; }
        [Display(Name ="Số ngày làm")]
        public int SoNgayLam { get; set; }
        [Display(Name ="Tháng")]
        public int Thang { get; set; }
        [Display(Name ="Lương")]
        public string Luong { get; set; }


        public int MaNV { get; set; }
        [ForeignKey("MaNV")]
        public NhanVien NhanVien { get; set; }
    }
}
