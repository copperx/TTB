using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls.Expressions;
using TTB_Model;

namespace TTB.ViewModels
{
    public class ProjectViewModel
    {
        public project Project { get; set; }
        public List<status> Statuses { get; set; }

        public List<rating> Ratings { get; set; }

    }
}