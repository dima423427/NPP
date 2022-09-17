using NPP.Models;
using NPP.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace NPP.Repositories
{
    public class DataDBRepository
    {
        private NPPBASEEntities objNPPBASEEntities;

        public DataDBRepository()
        {
            objNPPBASEEntities = new NPPBASEEntities();
        }

        public bool AddData(GeneralToolModel objgeneralToolModel)
        {
            
            return true;
        }
    }
}