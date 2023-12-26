using Assessment12.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assessment12.Controllers
{
    public class PlayersController : Controller
    {
        static List<Player> ListTeams = new List<Player>()
        {
            new Player(){TeamId=1,TeamName="India",NOWC=3},
            new Player(){TeamId=2,TeamName="Australia",NOWC=4},
            new Player(){TeamId=3,TeamName="West Indies",NOWC=2},
            new Player(){TeamId=4,TeamName="England",NOWC=1}
        };

        // GET: Players
        public ActionResult Index()
        {
            return View(ListTeams);
        }
        
    }
}