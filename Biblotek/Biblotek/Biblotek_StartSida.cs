using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblotek
{

    class Biblotek_StartSida
    {
        public static void Show()
        {
            string[] AnvändarnamnDb = System.IO.File.ReadAllLines(@"C:\Users\ahmad.yasin\source\repos\Biblotek\Biblotek\TextFile_AnvändarNamn.txt");
            Console.WriteLine("Hej och välkommen");

            Console.ReadLine();
            }
    }
}

