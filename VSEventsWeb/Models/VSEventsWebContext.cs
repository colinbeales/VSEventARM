using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace VSEventsWeb.Models
{
    public class VSEventsWebContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public VSEventsWebContext() : base("name=VSEventsWebContext")
        {
            Database.SetInitializer<VSEventsWebContext>(new AgendaInitializer());
        }

        public System.Data.Entity.DbSet<VSEventsWeb.Models.AgendaItem> AgendaItems { get; set; }
    }


    public class AgendaInitializer : CreateDatabaseIfNotExists<VSEventsWebContext>
    {
        protected override void Seed(VSEventsWebContext context)
        {
            IList<AgendaItem> agenda = new List<AgendaItem>();

            agenda.Add(new AgendaItem() { Timeslot = "09:00 – 09:30", Description = "Registration" });
            agenda.Add(new AgendaItem() { Timeslot = "09:30 - 11:00", Description = "Morning Session 1" });
            agenda.Add(new AgendaItem() { Timeslot = "11:00 - 11:15", Description = "Break" });
            agenda.Add(new AgendaItem() { Timeslot = "11:15 - 12:30", Description = "Morning Session 2" });
            agenda.Add(new AgendaItem() { Timeslot = "12:30 - 13:15", Description = "Lunch Break" });
            agenda.Add(new AgendaItem() { Timeslot = "13:15 - 15:00", Description = "Afternoon Sessions" });
            agenda.Add(new AgendaItem() { Timeslot = "15:00 - 15:15", Description = "Afternoon Break" });
            agenda.Add(new AgendaItem() { Timeslot = "15:15 - 16:30", Description = "Afternoon Session 2" });
            agenda.Add(new AgendaItem() { Timeslot = "16:30"        , Description = "Close" });
  
            foreach (AgendaItem item in agenda)
                context.AgendaItems.Add(item);

            base.Seed(context);
        }
    }

}
