using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EmartProject2.Models;
using Microsoft.AspNetCore.Hosting;

namespace EmartProject2.Controllers
{
    public class SellersController : Controller
    {
        private readonly EmartSellerContext _context;
   
        //private readonly IWebHostEnvironment hostEnvironment;

        public SellersController(EmartSellerContext context)
        {
            _context = context;
        }
        //public SellersController(EmartSellerContext context, IWebHostEnvironment hostEnvironment)
        //{
        //    _context = context;
        //}
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Seller s)
        {
            try
            {
                _context.Add(s);
                _context.SaveChanges();
                ViewBag.message = s.Name + " has got succesfully registered";
                return RedirectToAction("Login");
            }
            catch (Exception)
            {
                ViewBag.message = s.Name + "Registration failed";
            }
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Seller s)
        {
            var l = _context.Seller.Where(e => e.Name==s.Name && e.Pwd == s.Pwd).ToList();
            if (l.Count == 0)
            {
                ViewBag.message = "Not a Valid User";
                return View();
            }
            else
            {
                HttpContext.Session.SetString("Uname", s.Name);
                return RedirectToAction("CreateDashboard");
            }
        }
        public IActionResult CreateDashboard()
        {
            return View();
        }
        public bool IsExist(string email)
        {
            var res = _context.Seller.Where(r => r.Email == email).ToList();
            if (res.Count == 0) return true;
            else return false;
        }
      

    }
}
