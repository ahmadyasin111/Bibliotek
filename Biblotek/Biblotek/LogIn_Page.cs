using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblotek
{
    class LogIn_Page
    {
       
       public static void Show()
        {
            bool wrongpassword = false;
            string personnummer = "";
            string password = "";

            Console.Clear();
            Console.WriteLine("Log in");
            Console.WriteLine("");



            Console.WriteLine("Va vänligen snäll och skriv in ditt Personnummer?(12 siffror)");
            personnummer = Console.ReadLine();

            Console.WriteLine("Va nu vänligen snäll och skriv ditt Lösenord");
            password = Console.ReadLine();

            wrongpassword = true;
            

            static bool Authenticate(string personnummer, string password)
            {
                string[] AnvändarnamnDb = System.IO.File.ReadAllLines(@"C:\Users\ahmad.yasin\source\repos\Biblotek\Biblotek\TextFile_AnvändarNamn.txt");
                string[] LösenordDb = System.IO.File.ReadAllLines(@"C:\Users\ahmad.yasin\source\repos\Biblotek\Biblotek\TextFile_Lösenord.txt");
                string[] PersonnummerDb = System.IO.File.ReadAllLines(@"C:\Users\ahmad.yasin\source\repos\Biblotek\Biblotek\TextFile_Personnummer.txt");

                for (int i = 0; i < PersonnummerDb.Length; i++)
                {
                    string personalNumberFromDb = PersonnummerDb[i];
                    string passFromDb = LösenordDb[i];

                    if (personnummer == personalNumberFromDb && password == passFromDb)
                    {
                        Console.Clear();
                        Biblotek_StartSida.Show();
                    }
                }

                return false;
            }


            while (!Authenticate(personnummer, password))
            {
               

                if (wrongpassword)
                {

                    Console.Clear();
                    Console.WriteLine("Fel lösenord!");
                    Console.WriteLine("Är du medlem?");
                    Console.WriteLine("Ja/Nej");

                    String medlemSvarsalternativ = Convert.ToString(Console.ReadLine());


                    if (medlemSvarsalternativ == "Nej")
                    {
                        Register_Page.Show();

                        Console.ReadLine();
                    }
                    if (medlemSvarsalternativ == "Ja")
                    {
                        LogIn_Page.Show();

                        Console.ReadLine();
                    }
                    LogIn_Page.Show();

  
                }
                else
                {
                    Biblotek_StartSida.Show();
                    Console.ReadLine();
                }

            }
            




           



            }

        }
    }
