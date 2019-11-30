using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        public IActionResult XemChamCong(int id)
        {
            var chamcong = _context.bangChamCongs.Where(p => p.MaNV == id);
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