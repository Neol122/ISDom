using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication1.ViewModels;
namespace WebApplication1.Controllers
{
    public class AccountController : Controller
    {

        public ActionResult AddUserToRole()
        {
            AddToRoleModel model = new AddToRoleModel();
            model.Roles = new List<string>() { "Admin", "Editor", "User" };
            return View(model);

        }

    }
}


