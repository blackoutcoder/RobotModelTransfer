using System;
using Services;

namespace RobotModelTransfer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RobotRepository robotRepository = new RobotRepository();
            robotRepository.CreateNewRobot();
        }
    }
}
