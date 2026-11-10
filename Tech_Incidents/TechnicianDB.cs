
using System;
using System.Collections.Generic;
using System.IO;
using Tech_Incidents;

namespace Tech_Incidents
{
    public static class TechnicianDB
    {
        private const string Dir = "Technicians.txt";
        private const string Path = Dir;
        internal static List<Technician> GetTechnicians()

        {
            List<Technician> technicians = new List<Technician>();

            string[] lines = File.ReadAllLines(Path);

            foreach (string line in lines)
            {
                string[] fields = line != null ? line.Split('|') : new string[0];

                Technician technician = new Technician
                {
                    TechId = fields[0] != null && int.TryParse(fields[0], out int techId) ? techId : 0,
                    Name = fields[1].Trim()
                };

                technicians.Add(technician);
            }

            return technicians;
        }
    }
}
