using NPP.Models;
using NPP.Repositories;
using NPP.ViewModel;
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

        [HttpPost]
        public JsonResult Index(GeneralToolModel objgeneralToolModel)
        {
            return Json("",JsonRequestBehavior.AllowGet);
        }
    }
}