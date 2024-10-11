using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skole_Objekt_programmering_opgave
{
    internal class Studerende : Person
    {
        




     


        public string Navn { get; set; }
        public DateTime Fødselsdato { get; set; }

        public string SchoolName { get; set; }

        public Studerende(string navn, DateTime fødselsdato, string schoolName)
        {
            Navn = navn;
            Fødselsdato = fødselsdato;
            SchoolName = schoolName;
        }
        /*
        public  override void  Visinfo(List<Studerende> listStudents)
        {
            foreach (var student in listStudents)
            {
                Console.WriteLine($" Student: Navn: {student.Navn} :Skolenavn: {student.SchoolName}");
                BeregnAlder(student.Fødselsdato, DateTime.Now);
            }
        }
        */





    }
}
