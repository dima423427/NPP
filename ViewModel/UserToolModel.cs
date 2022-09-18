using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NPP.ViewModel
{
    public class UserToolModel
    {
        public int UserID { get; set; }
        public string FIO { get; set; }

        public IEnumerable<UserToolModel> UserToolModels { get; set; }

    }
}