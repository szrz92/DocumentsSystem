using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using DocumentManagement.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace DocumentManagement.Controllers
{
    public class AccountController : Controller
    {
        DocumentManagementContext _context;
        public AccountController(DocumentManagementContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(User user)
        {
            if (ModelState.IsValid)
            {
                bool CheckCredentials = IsAuthenticated(user.UserName, user.Password);
                string userrole = GetRole(user.UserName);
                if (CheckCredentials)
                {
                    ClaimsIdentity identity = new ClaimsIdentity(new[] {
                                    new Claim(ClaimTypes.Name, user.UserName),
                                    new Claim(ClaimTypes.Role, userrole)
                                }, CookieAuthenticationDefaults.AuthenticationScheme);

                    var principal = new ClaimsPrincipal(identity);
                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                    if (userrole == "SuperAdmin")
                    {
                        return RedirectToAction("Drive", "Admin");
                        //return RedirectToAction("Companies", "Admin");
                    }
                    else
                    if (userrole == "CompanyAdmin")
                    {
                        return RedirectToAction("Drive", "Company");
                        //return RedirectToAction("Departments", "Company" , new { companyID = (from usr in _context.Users where usr.UserName == user.UserName select usr.Company_ID).FirstOrDefault()  });
                    }
                    else
                    if (userrole == "DepartmentHead")
                    {
                        return RedirectToAction("Drive", "Department");
                        //return RedirectToAction("Employees", "Department" , new { companyID = (from usr in _context.Users where usr.UserName == user.UserName select usr.Company_ID).FirstOrDefault(), departmentID  = (from usr in _context.Users where usr.UserName == user.UserName select usr.Department_ID).FirstOrDefault() });
                    }
                    else
                    if (userrole == "Employee")
                    {
                        return RedirectToAction("Drive", "Employee");
                    }
                    else
                    {
                        return RedirectToAction("Logout", "Account");
                    }
                }
                else
                {
                    return View();
                }
            }
            else
            {
                return View();
            }
        }
        public string GetRole(string username)
        {
            string role = (from party in _context.Parties
                           join user in _context.Users on party.ID equals user.Party_ID
                           join partyrole in _context.PartyRoles on party.PartyRole_Id equals partyrole.ID
                           where user.UserName == username
                           select partyrole.Name).FirstOrDefault();
            return role;
        }
        private bool IsAuthenticated(string username, string password)
        {
            bool Auth = false;
            try
            {
                var user = from u in _context.Users
                           where u.UserName == username
                           && u.Password == password
                           select u;
                int i = user.Count();

                if (i > 0)
                {
                    Auth = true;
                    return Auth;
                }
                else
                {
                    return Auth;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace.ToString());
                return Auth;
            }
        }
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction("Index", "Home");
        }
        public ActionResult AccessDenied()
        {
            return View();
        }
        public ActionResult Test()
        {
            return View();
        }
    }
}
