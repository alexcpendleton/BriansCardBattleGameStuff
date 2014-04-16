using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BriansCardBattleGame.Web.Controllers
{
    public class CardController : Controller
    {
        //
        // GET: /Card/
        public ActionResult Index()
        {
            var x = File("~/CardData.json", "application/json");
            return x;
        }
    }
}