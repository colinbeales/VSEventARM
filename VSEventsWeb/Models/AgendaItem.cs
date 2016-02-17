using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VSEventsWeb.Models
{
    public class AgendaItem
    {
        public int ID { get; set; }
        public string Timeslot { get; set; }
        public string Description { get; set; }
    }
}