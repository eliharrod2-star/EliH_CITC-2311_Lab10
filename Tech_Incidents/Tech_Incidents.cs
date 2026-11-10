
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Tech_Incidents
{
    public partial class Incidents_By_Technicians : Form
    {
        public Incidents_By_Technicians()
        {
            InitializeComponent();
        }

        private void Incidents_By_Technicians_Load(object sender, EventArgs e)
        {
            List<Technician> technicians = TechnicianDB.GetTechnicians();
            List<Incident> incidents = IncidentDB.GetIncidents();

            var query = from technician in technicians
                        join incident in incidents.Where(incident => incident.TechID.HasValue)
                        on technician.TechId equals incident.TechID.Value
                        where incident.DateClosed != null
                        orderby technician.Name, incident.DateOpened
                        select new
                        {
                            TechnicianName = technician.Name,
                            Product = incident.ProductCode,
                            DateClosed = incident.DateClosed,
                            Title = incident.Title
                        };

            lst_Incidents.Items.Add(
                "Technician".PadRight(20) +
                "Product".PadRight(15) +
                "Date Closed".PadRight(15) +
                "Title");

            string previousTechnician = "";

            foreach (var incident in query)
            {
                string technicianName = incident.TechnicianName;

                if (technicianName == previousTechnician)
                {
                    technicianName = "";
                }
                else
                {
                    previousTechnician = technicianName;
                }

                string line = technicianName.PadRight(20) +
                              incident.Product.PadRight(15) +
                              incident.DateClosed.Value.ToShortDateString().PadRight(15) +
                              incident.Title;

                lst_Incidents.Items.Add(line);
            }
        }
    }
}



