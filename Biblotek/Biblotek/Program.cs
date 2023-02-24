using System;

namespace Biblotek
{
    class Program
    {
        //private string TextFile_Personnummer.txt();
        static void Main(string[] args)
        {
            Console.WriteLine("Hej");
            Console.WriteLine("Väkommen till Yasins Biblotek");
            Console.WriteLine("Vårt biblotek innehåller flertals böcker från Action till Manga");
            Console.WriteLine("Bli medlem idag för att inte missa våra sällsynta böcker");
            Console.WriteLine("Är du medlem?");
            Console.WriteLine("Ja/Nej");

            String medlemSvarsalternativ = Convert.ToString(Console.ReadLine());
            if (medlemSvarsalternativ == "Nej")
            {
                Register_Page.Show();

                Console.ReadLine();
            }
            if (medlemSvarsalternativ == "Ja") ;
            {
                LogIn_Page.Show();

                Console.ReadLine();
            }
            


        }
    }
}
