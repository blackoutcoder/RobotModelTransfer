using System;
using Services;

namespace RobotModelTransfer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileManager fileManager = new FileManager();
            RobotRepository robotRepository = new RobotRepository();
            StartUp startUp = new StartUp();
            startUp.PrintStartUpMenu();
            //fileManager.WriteToFile(robotRepository.CreateNewRobot());
            
        }
    }
}
