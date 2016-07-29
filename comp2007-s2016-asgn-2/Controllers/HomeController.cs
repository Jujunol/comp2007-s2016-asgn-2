using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace comp2007_s2016_asgn_2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(ManageController.ManageMessageId? message)
        {
            ViewBag.StatusMessage =
                message == ManageController.ManageMessageId.ChangePasswordSuccess ? "Your password has been changed."
                : message == ManageController.ManageMessageId.SetPasswordSuccess ? "Your password has been set."
                : message == ManageController.ManageMessageId.SetTwoFactorSuccess ? "Your two-factor authentication provider has been set."
                : message == ManageController.ManageMessageId.Error ? "An error has occurred."
                : message == ManageController.ManageMessageId.AddPhoneSuccess ? "Your phone number was added."
                : message == ManageController.ManageMessageId.RemovePhoneSuccess ? "Your phone number was removed."
                : "";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}