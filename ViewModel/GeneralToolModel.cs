using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NPP.ViewModel
{
    public class GeneralToolModel
    {
        [Required]
        public int id { get; set; }

        public string ToolName { get; set; }

        public string CountTool { get; set; }
        public string FIO { get; set; }
    }
}