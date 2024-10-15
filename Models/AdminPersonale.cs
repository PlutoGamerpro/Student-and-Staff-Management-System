using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skole_Objekt_programmering_opgave
{
    internal class AdminPersonale : Person
    {
        public string Navn { get; set; }
        public DateTime Fødselsdato { get; set; }

        public int WorkHours { get; set; }


        public AdminPersonale(string navn, DateTime fødselsdato, int workHours)
        {
            Navn = navn;
            Fødselsdato = fødselsdato;
            WorkHours = workHours;
        }
        
        public override void Visinfo(List<AdminPersonale> listadmin)
        {
            foreach (var AdminPersonale in listadmin)
            {
                Console.WriteLine($" AdminPersonale: Navn: {AdminPersonale.Navn} :WorkHours: {AdminPersonale.WorkHours}");
                BeregnAlder(AdminPersonale.Fødselsdato, DateTime.Now);
            }
        }
        

    }
}
