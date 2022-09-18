using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NPP.ViewModel
{
    public class ViewToolModel
    {
        public int Toolid { get; set; }

        public string ToolName { get; set; }

        public int CountTool { get; set; }

        public IEnumerable<ViewToolModel> ViewToolModels { get; set; }
    }
}