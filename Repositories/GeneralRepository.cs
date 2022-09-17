using NPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NPP.Repositories
{
    public class GeneralRepository
    {
        private NPPBASEEntities objNPPBASEEntities;

        public GeneralRepository()
        {
            objNPPBASEEntities = new NPPBASEEntities();
        }

        public IEnumerable<SelectListItem> GetAllGeneral()
        {
            var objSelectListItems = new List<SelectListItem>();
            objSelectListItems = (from obj in objNPPBASEEntities.Generals
                                  select new SelectListItem()
                                  {
                                      /*     Text = obj.id,
                                           Value = obj.id.ToString(),
                                           Selected = true*/

                                  }).ToList();

            return objSelectListItems;
        }
    }
}