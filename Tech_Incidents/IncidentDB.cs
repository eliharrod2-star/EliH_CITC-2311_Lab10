
using System;
using System.Collections.Generic;
using System.IO;
using Tech_Incidents;

namespace Tech_Incidents
{
    public static class IncidentDB
    {
        private const string Dir = "Incidents.txt";
        private const string Path = Dir;

        public static List<Incident> GetIncidents()
        {
            List<Incident> incidents = new List<Incident>();

            string[] lines = File.ReadAllLines(Path);

            foreach (string line in lines)
            {
                string[] fields = line.Split('|');

                Incident incident = new Incident
                {
                    IncidentID = Convert.ToInt32(fields[0]),
                    CustomerID = Convert.ToInt32(fields[1]),
                    ProductCode = fields[2].Trim(),
                    TechID = string.IsNullOrWhiteSpace(fields[3])
                        ? null
                        : Convert.ToInt32(fields[3]),
                    DateOpened = Convert.ToDateTime(fields[4]),
                    DateClosed = string.IsNullOrWhiteSpace(fields[5])
                        ? null
                        : Convert.ToDateTime(fields[5]),
                    Title = fields[6].Trim(),
                    Description = fields[7].Trim()
                };

                incidents.Add(incident);
            }

            return incidents;
        }
    }
}

