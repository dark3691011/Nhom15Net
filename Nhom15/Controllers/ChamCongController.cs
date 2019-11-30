using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
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
        public async Task<IActionResult> Index()
        {
            var myDbContext = _context.bangChamCongs.Include(n => n.NhanVien);
            return View(await myDbContext.ToListAsync());
        }

        public IActionResult XemChamCong(int id)
        {
            var chamcong = _context.bangChamCongs.Include(p =>p.NhanVien).Where(p => p.MaNV == id);
            return View(chamcong);
        }
        public IActionResult XemChamCongThang(int thang)
        {
            var chamcong = _context.bangChamCongs.Include(p => p.NhanVien).Where(p => p.Thang == thang);
            return View(chamcong);
        }
        public IActionResult ThemMoi()
        {
            ViewData["MaNV"] = new SelectList(_context.nhanViens, "MaNV", "TenNV");
            return View();
        }

        [HttpPost]
        public IActionResult ThemMoi(BangChamCong chamCong)
        {
            if (ModelState.IsValid)
            {
                _context.Add(chamCong);
                _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            ViewData["MaNV"] = new SelectList(_context.nhanViens, "MaNV", "TenNV",chamCong.MaNV);
            return View(chamCong);
        }

    }
}