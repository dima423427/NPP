using NPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NPP.Repositories
{
    public class ToolRepository
    {

        private NPPBASEEntities objNPPBASEEntities;

        public ToolRepository()
        {
            objNPPBASEEntities = new NPPBASEEntities();
        }

        public IEnumerable<SelectListItem> GetAllTool()
        {
            var objSelectListItems = new List<SelectListItem>();
            objSelectListItems = (from obj in objNPPBASEEntities.Tools
                                  select new SelectListItem()
                                  {
                                      Text = obj.ToolName,
                                      Value = obj.ToolName.ToString(),
                                      Selected = true

                                  }).ToList();

            return objSelectListItems;
        }

        public IEnumerable<SelectListItem> GetCountTool()
        {
            var objSelectListItems = new List<SelectListItem>();
            objSelectListItems = (from obj in objNPPBASEEntities.Tools
                                  select new SelectListItem()
                                  {
                                      Text = obj.CountTool.ToString(),
                                      Value = obj.CountTool.ToString(),
                                      Selected = true

                                  }).ToList();

            return objSelectListItems;
        }
    }
}