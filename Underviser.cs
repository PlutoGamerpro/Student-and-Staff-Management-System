using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skole_Objekt_programmering_opgave
{
    internal class Underviser : Person
    {

        public string Navn { get; set; }
        public DateTime Fødselsdato { get; set; }

        public string Undervisingfag { get; set; }


        public Underviser(string navn, DateTime fødselsdato, string undervisingfag)
        {
            Navn = navn;
            Fødselsdato = fødselsdato;
            Undervisingfag = undervisingfag;
        }
        /*
        public override void Visinfo(List<Underviser> listUnderviser)
        {
            foreach (var underviser in listUnderviser)
            {
                Console.WriteLine($" Underviser: Navn: {underviser.Navn} :FAG: {underviser.Undervisingfag}");
                BeregnAlder(underviser.Fødselsdato, DateTime.Now);
            }
        }
        */



    }
}
