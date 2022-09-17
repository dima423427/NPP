using NPP.Models;
using NPP.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NPP.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ToolRepository objtoolRepository = new ToolRepository();
            UserRepository objuserRepository = new UserRepository();
          //  GeneralRepository objgeneralRepository = new GeneralRepository();

            var objMultipleModels = new Tuple<IEnumerable<SelectListItem>, IEnumerable<SelectListItem>, IEnumerable<SelectListItem>>
                (objuserRepository.GetAllUser(), objtoolRepository.GetAllTool(), objtoolRepository.GetCountTool());
            return View(objMultipleModels);
        }

        NPPBASEEntities nPPBASEEntities = new NPPBASEEntities();

        [HttpPost]
        public ActionResult AddDataDB(General model)
        {
            General obj = new General();
            obj.id = model.id;
            obj.ToolName = model.ToolName;
            obj.CountTool = model.CountTool;
            obj.FIO = model.FIO;

            nPPBASEEntities.Generals.Add(obj);
            nPPBASEEntities.SaveChanges();

            return View("Index");
        }
    }
}