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

        GOTOHERE:
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


            
        }
    }
}
