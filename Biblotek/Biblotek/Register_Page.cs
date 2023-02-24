using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Registeration

namespace Biblotek
{
    class Register_Page
    {
       public static void Show()
        {
            Console.Clear();
            Console.WriteLine("Hej");
            Console.WriteLine("För att bli medlem till Sveriges största biblotek");
            Console.WriteLine("Vi kräver tyvärr dina personuppgifter för identification ");

            Console.Write("Förnamn: ");
            var firstName = Console.ReadLine();

            Console.Write("Efternamn: ");
            var lastName = Console.ReadLine();

            Console.Write("Personnummer: ");
            var personalNumber = Console.ReadLine();

            Console.Write("Lösenord: ");
            var password = Console.ReadLine();

            var line = $"{firstName} {lastName} {personalNumber} {password}";
            string[] lines = { line };

            File.AppendAllLines(@"C:\Users\deriye\Desktop\Registeration\Registeration\users.txt", lines);

            Console.WriteLine("");

            if (UserInfoIncomplete(firstName, lastName, personalNumber, password))
            {
                Console.Clear();
                Console.WriteLine("Ange riktiga uppgifter för att kunna registrera dig.");
                Console.WriteLine("");
                RegistrationPage();
                return;
            }
            else if (UserRegistered(personalNumber))
            {
                Console.Clear();
                Console.WriteLine("Du är redan registrerad. Ange ett nytt personnummer för att registrera dig.");
                Console.WriteLine("");
                RegistrationPage();
                return;
            }


        }
    }
}
