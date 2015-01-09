using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TTB_Model;

namespace TTB.ViewModels
{
    public class EventViewModel
    {
        public projectEvent ProjectEvent { get; set; }
        public IEnumerable<eventType> eventTypes { get; set; }
    }
}