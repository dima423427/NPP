using NPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NPP.Repositories
{
    public class UserRepository
    {
        private NPPBASEEntities objNPPBASEEntities;

        public UserRepository()
        {
            objNPPBASEEntities = new NPPBASEEntities();
        }

        public IEnumerable<SelectListItem> GetAllUser()
        {
            var objSelectListItems = new List<SelectListItem>();
            objSelectListItems = (from obj in objNPPBASEEntities.Users
                                  select new SelectListItem()
                                  {
                                      Text = obj.FIO,
                                      Value = obj.FIO.ToString(),
                                      Selected = true

                                  }).ToList();

            return objSelectListItems;
        }
    }
}