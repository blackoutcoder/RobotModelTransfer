using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using MongoDB.Driver;

namespace Services
{
    public class RobotRepository
    {
        public RobotRepository()
        {

        }

        public Robot CreateNewRobot()
        {
            MongoClient client = new MongoClient("mongodb+srv://blackout:karina@cluster1.b9ndq.mongodb.net/?retryWrites=true&w=majority");
            var playlistCollections = client.GetDatabase("Robots").GetCollection<Robot>("RobotDataSheets");

            Console.WriteLine("Enter 'Robot' name and press ENTER...");
            var robotName = Console.ReadLine();
            List<Arm> robotArms = new List<Arm>();
            List<Leg> robotLeg = new List<Leg>();
            robotArms.Add(new Arm("Steel", 5, 5));
            robotArms.Add(new Arm("Steel", 5, 5));
            robotLeg.Add(new Leg("Leather", 3, 7));
            robotLeg.Add(new Leg("Leather", 3, 7));
            Torso torso = new Torso(2.33m, 3.33m);
            Head head = new Head("Black");
            Robot robot = new Robot(robotName, robotArms, robotLeg, torso, head);
           
            playlistCollections.InsertOne(robot);
            Console.WriteLine(robot.ToString());
            return robot;
        }

        public void SaveRobotDataToMongoDB(Robot robot)
        {
            MongoClient client = new MongoClient("mongodb+srv://blackout:karina@cluster1.b9ndq.mongodb.net/?retryWrites=true&w=majority");
            var playlistCollections = client.GetDatabase("Robots").GetCollection<Robot>("RobotDataSheets");
            playlistCollections.InsertOne(robot);
        }
    }
}
