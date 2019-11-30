using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Nhom15.Models
{
    public class PhongBan
    {
        [Key]
        [Display (Name ="Mã Phòng ban")]
        public int MaPB { get; set; }
        [Display (Name ="Tên Phòng ban")]
        public string TenPB { get; set; }


    }
}
