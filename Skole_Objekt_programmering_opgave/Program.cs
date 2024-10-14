using System.IO;



namespace Skole_Objekt_programmering_opgave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string basePath = @"C:\Files\"; // Base path where files are located

            // Read from AllPersons.txt
            using (StreamReader sr = new StreamReader(Path.Combine(basePath, "AllPersons.txt")))
            {
                string line;
                // Read and display lines from the file until the end of the file is reached.
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

            // Read from Students.txt
            using (StreamReader sr = new StreamReader(Path.Combine(basePath, "Students.txt")))
            {
                string line;
                // Read and display lines from the file until the end of the file is reached.
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

            // Read from Underviser.txt
            using (StreamReader sr = new StreamReader(Path.Combine(basePath, "Underviser.txt")))
            {
                string line;
                // Read and display lines from the file until the end of the file is reached.
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

            // Read from AdminPersonale.txt
            using (StreamReader sr = new StreamReader(Path.Combine(basePath, "AdminPersonale.txt")))
            {
                string line;
                // Read and display lines from the file until the end of the file is reached.
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        */




        // MENU
        List<Studerende> lstStudents = new List<Studerende>();
            List<Underviser> lstUnderviser = new List<Underviser>();
            List<AdminPersonale> lstadminPersonales = new List<AdminPersonale>();

            bool KeepRuning = true;
            while (KeepRuning)
            {
                Console.WriteLine("");

                Console.WriteLine("1: Tilføj Studerende");
                Console.WriteLine("2: Tilføj Underviser");
                Console.WriteLine("3: Tilføj Admin Personale");
                Console.WriteLine("4: Vis alle bruger");
                Console.WriteLine("5: Afslut");
                Console.WriteLine("-------------------");

                Console.Write("Pick a Option: ");
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                char userInput = keyInfo.KeyChar;
                switch (userInput)
                {
                    case '1':
                        Console.Write(" Navn: ");
                        string Navn = Console.ReadLine();

                        bool DateIsvalid = false;
                        while (!DateIsvalid)
                        {
                            Console.Write("Skole navn");
                            string schoolName = Console.ReadLine();

                            Console.Write("Please indtast din fødselsdato dato og tid (e.g., 2024-05-28):  ");

                          

                            string dato = Console.ReadLine();
                            DateTime dateTime;
                            DateTime nowDate = DateTime.Now;


                            if (DateTime.TryParse(dato, out dateTime))
                            {


                                 Studerende.BeregnAlder(dateTime, nowDate);
                                DateIsvalid = true;
                                Studerende opretStudent = new Studerende(Navn, dateTime, schoolName);
                                lstStudents.Add(opretStudent);
                            }
                            else { Console.WriteLine("Wrong data and time format inputet inputet"); }
                        }


                        

                      //  Studerende opretStudent = new Studerende(Navn, da);
                       
                   

                       
                        
                      
                      



                       


                        Console.WriteLine( "" );
                        Console.WriteLine( "" );

                        break;
                    case '2':

                        Console.Write(" Navn: ");
                        string NavnUnderviser = Console.ReadLine();

                        bool DateIsvalide = false;
                        while (!DateIsvalide)
                        {
                            Console.Write("undervising fag: ");
                            string Undervisingfag = Console.ReadLine();


                            Console.Write("Please indtast en dato og tid (e.g., 2024-05-28):  ");
                            string dato = Console.ReadLine();
                            DateTime dateTime;
                            DateTime nowDate = DateTime.Now;


                            if (DateTime.TryParse(dato, out dateTime))
                            {


                                Underviser.BeregnAlder(dateTime, nowDate);
                                DateIsvalide = true;
                                Underviser opretUnderviser = new Underviser(NavnUnderviser, dateTime, Undervisingfag);
                                lstUnderviser.Add(opretUnderviser);
                            }
                            else { Console.WriteLine("Wrong data and time format inputet inputet"); }
                        }

                        break;
                    case '3':;

                        Console.Write(" Navn: ");
                        string NavnAdminPersonale = Console.ReadLine();

                        bool DateIsvalider = false;
                        while (!DateIsvalider)
                        {
                            Console.Write("Workhours: ");
                            int WorkHours = Convert.ToInt16(Console.ReadLine());


                            Console.Write("Please indtast en dato og tid (e.g., 2024-05-28):  ");
                            string dato = Console.ReadLine();
                            DateTime dateTime;
                            DateTime nowDate = DateTime.Now;


                            if (DateTime.TryParse(dato, out dateTime))
                            {


                                AdminPersonale.BeregnAlder(dateTime, nowDate);
                                DateIsvalider = true;
                                AdminPersonale opretadminpersonale = new AdminPersonale(NavnAdminPersonale, dateTime, WorkHours);
                                lstadminPersonales.Add(opretadminpersonale);

                             

                            }
                            else { Console.WriteLine("Wrong data and time format inputet inputet"); }
                        }

                      
                        break;
                    case '4': Console.WriteLine(" "); Person.VisInfoallePersoner(lstStudents,lstUnderviser,lstadminPersonales); break;
                    case '5': Console.WriteLine(" Afslutter program "); Environment.Exit(0); break;
                    default: Console.WriteLine("Wrong input: enter 1,2,3,4,5"); break;
                }

            }


        }
    }
}