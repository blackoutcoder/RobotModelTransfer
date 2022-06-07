using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace Services
{
    public class StartUp
    {
        public void PrintStartUpMenu()
        {
            RobotRepository robotRepository = new RobotRepository();
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
            GOTOHERE:
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
            Console.WriteLine("7. Save any robot data to text file.");
            Console.WriteLine("8. Exit data manager.");
            var choise = Convert.ToInt32(Console.ReadLine());


            if (choise == 1)
            {
                var data = fileManager.DeserializeDataQuick(datafile);
                robotRepository.SaveRobotDataToMongoDB(data);
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine($">Robot data successfully saved to MongoDB database!");
                Console.WriteLine("");
                Console.WriteLine(">Press any key to watch robot list...");
                robotRepository.GetRobotList();
                System.Threading.Thread.Sleep(2000);
                goto GOTOHERE;

            }
            else if (choise == 2)
            {
                robotRepository.GetRobotList();
                System.Threading.Thread.Sleep(2000);
                goto GOTOHERE;

            }
            else if (choise == 3)
            {
                robotRepository.FindRobotDataSheetById();
                System.Threading.Thread.Sleep(2000);
                goto GOTOHERE;
            }
            else if (choise == 4)
            {
                robotRepository.FindRobotDataSheetByName();
                System.Threading.Thread.Sleep(2000);
                goto GOTOHERE;
            }

            else if (choise == 5)
            {
                
            }
            else if (choise == 6)
            {

            } 
            else if (choise == 7)
            {

            }
            else if (choise == 8)
            {
                Console.Clear();
                Console.WriteLine(">Saving progress...3 ");
                System.Threading.Thread.Sleep(1500);
                Console.Clear();
                Console.WriteLine(">Saving progress...2 ");
                System.Threading.Thread.Sleep(1500);
                Console.Clear();
                Console.WriteLine(">Saving progress...1 ");
                System.Threading.Thread.Sleep(1500);
                Console.Clear();
                
                Process.GetCurrentProcess().Kill();
            }
            else
            {
                Console.WriteLine("Enter a valid number and press ENTER...");
                System.Threading.Thread.Sleep(2000);
                goto GOTOHERE;
            }
        }
    }
}
