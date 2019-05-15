using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Activity4.Models;

namespace Activity4.Controllers
{
    public class ButtonController : Controller
    {
        static List<ButtonModel> buttons = new List<ButtonModel>();

        // GET: Button
        public ActionResult Index()
        {
            buttons.Add(new ButtonModel(true));
            buttons.Add(new ButtonModel(false));

            return View("Button", buttons);
        }

        public ActionResult OnButtonClick(string mine)
        {
            if (mine.Equals("1"))
            {
                buttons[0].State = !buttons[0].State;
            }

            if (mine.Equals("2"))
            {
                buttons[1].State = !buttons[1].State;
            }

            return View("Button", buttons);
        }
    }
}