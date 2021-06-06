using NguyenThiNgoc_36.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace NguyenThiNgoc_36.Controllers
{
    public class AccountController : Controller
    {
        Encrytion encry = new Encrytion();
        LTQLDb db = new LTQLDb();
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        //Nhận DL từ client gửi lên
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Account acc)
        {
            if (ModelState.IsValid)
            {
                string encrytionpass = encry.PasswordEncrytion(acc.Password);
                var model = db.Accounts.Where(m => m.Username == acc.Username && m.Password == encrytionpass).ToList().Count();
                //Thong tin dang nhap chinh xac
                if (model == 1)
                {
                    //Luu cookie dang nhap thanh cong
                    FormsAuthentication.SetAuthCookie(acc.Username, true);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Thong tin dang nhap khong chinh xac");
                }
            }
            return View(acc);
        }

    }
}