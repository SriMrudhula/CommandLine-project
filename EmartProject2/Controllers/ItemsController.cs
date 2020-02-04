using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EmartProject2.Models;
namespace EmartProject2.Controllers
{
    public class ItemsController : Controller
    {
        private readonly EmartItemContext _context;

        public ItemsController(EmartItemContext context,EmartItemContext context1,EmartItemContext context2)
        {
            _context = context;
        }
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AddItems()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddItems(Item i)
        {
            try
            {
                if(_context.Item==null)
                    i.Cid = 1;
                else
                   i.Cid =_context.SubCategory.Max(m => m.Cid) + 1;
                _context.Item.Add(i);
                _context.SaveChanges();
                SubCategory sc = new SubCategory(i.Scid, i.Scname, i.Cid, i.Cname);
                _context.SubCategory.Add(sc);
                _context.SaveChanges();
                return RedirectToAction("CreateDashboard","Sellers");
            }
            catch (Exception e)
            {
                ViewBag.message = "Could Not Add Item ";
            }
            return View();
        }
        public IActionResult MyProfile()
        {
            return View();
        }

    }
}