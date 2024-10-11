using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skole_Objekt_programmering_opgave
{
    internal class Person
    {


        private DateTime fødselsdato;

        public DateTime Fødselsdato
        {
            get { return fødselsdato; }
            set
            {
                if (value > DateTime.Now)
                    throw new ArgumentOutOfRangeException("Fødselsdato", "Fødselsdato kan ikke være i fremtiden.");
                fødselsdato = value;
            }
        }

        public int Alder
        {
            get
            {
                int alder = DateTime.Now.Year - Fødselsdato.Year;
                if (DateTime.Now.DayOfYear < Fødselsdato.DayOfYear)
                    alder--;

                if (alder < 0)
                    alder = 0;

                return alder;
            }
        }

        public static void BeregnAlder(DateTime fødelsdato, DateTime Datetime) {



            int FødelsdagÅr = fødelsdato.Year;

            int Yearnow = DateTime.Now.Year;

            int alder = Yearnow - FødelsdagÅr;
            Console.WriteLine($"Du er {alder} år gammel");
        }

        public  static void VisInfoallePersoner(List<Studerende> listStudents, List<Underviser> listUnderviser, List<AdminPersonale> listadmin )
        {
            foreach (var student in listStudents)
            {
                Console.WriteLine($" Student: Navn: {student.Navn} :Skolenavn: {student.SchoolName}" );
                BeregnAlder(student.Fødselsdato, DateTime.Now);
            }
            foreach (var underviser in listUnderviser)
            {
                Console.WriteLine($" Underviser: Navn: {underviser.Navn} :FAG: {underviser.Undervisingfag}" );
                BeregnAlder(underviser.Fødselsdato, DateTime.Now);
            }
            foreach (var AdminPersonale in listadmin)
            {
                Console.WriteLine($" AdminPersonale: Navn: {AdminPersonale.Navn} :WorkHours: {AdminPersonale.WorkHours}" );
                BeregnAlder(AdminPersonale.Fødselsdato, DateTime.Now);
            }

        }
      public virtual void Visinfo(List<AdminPersonale> listadmin)
        {

        }
       




    }





    }

