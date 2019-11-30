using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Nhom15.Models;

namespace Nhom15.Controllers
{
    public class ChamCongController : Controller
    {
        private readonly MyDbContext _context;

        public ChamCongController(MyDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int? id)
        {
            var chamcong = _context.bangChamCongs.SingleOrDefault(p => p.MaNV == id);
            return View();
        }


    }
}