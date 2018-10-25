using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Twoje imie ?");
            string name = Console.ReadLine();
            Console.WriteLine("jak długo spałeś ?");
            int hoursofSleep = int.Parse(Console.ReadLine());




            Console.WriteLine("Hello," + name);
            if (hoursofSleep > 8)
            {
                Console.WriteLine("tak jesteś wypoczety," + name);
            }
            else
            {
                Console.WriteLine("nie jesteś wypoczety," + name);

            }

            Console.Write("Press any key to continue...");
            Console.ReadKey(true);

            Console.WriteLine();

        }
    }
}
