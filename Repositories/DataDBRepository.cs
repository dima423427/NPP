using NPP.Models;
using NPP.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.UI.WebControls;
using System.Web.Util;

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
            General general = new General();
            general.id = objgeneralToolModel.id;
            general.ToolName = objgeneralToolModel.ToolName;
            general.CountTool = int.Parse(objgeneralToolModel.CountTool);
            general.FIO = objgeneralToolModel.FIO;
            objNPPBASEEntities.Generals.Add(general);
            objNPPBASEEntities.SaveChanges();
            return true;
        }
    }
}