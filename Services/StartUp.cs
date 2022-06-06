using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class StartUp
    {
        public void PrintStartUpMenu()
        {
            FileManager fileManager = new FileManager();

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("MongoDB. Robot database inc.");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(">Attension! All data files must be in 'Services' folder");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(">Enter a 'file name' to read 'Robot data' and press ENTER...");
            var datafile = Console.ReadLine();
            fileManager.DeserializeDataFile(datafile);

            Console.WriteLine("Press any key to enter 'Service' menu...");
            Console.ReadLine();
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--Mongo database service menu--");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("1. Save robot data to mongoDB database.");
            Console.WriteLine("2. Save a list of robots data to mongoDB database.");
            Console.WriteLine("3. Find robot data by Id.");
            Console.WriteLine("4. Find robot data by other parmeters.");
            Console.WriteLine("5. Delete robot data by Id.");
            Console.WriteLine("6. Update robot data.");
            Console.ReadLine();
        }
    }
}
