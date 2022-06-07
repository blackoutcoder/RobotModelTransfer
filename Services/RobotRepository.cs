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

        public List<Robot> GetRobotList()
        {
            List<Robot> robotList = new List<Robot>();
            MongoClient client = new MongoClient("mongodb+srv://blackout:karina@cluster1.b9ndq.mongodb.net/?retryWrites=true&w=majority");
            var playlistCollections = client.GetDatabase("Robots").GetCollection<Robot>("RobotDataSheets");
            //robotList = playlistCollections.Indexes.List<Robot>;
            //foreach (var robot in playlistCollections)
            //{
            //    robotList.Add(robot);
            //}
            Console.WriteLine(playlistCollections.ToString());
            return robotList;
        }

        public void FindRobotDataSheetById()
        {
            MongoClient client = new MongoClient("mongodb+srv://blackout:karina@cluster1.b9ndq.mongodb.net/?retryWrites=true&w=majority");
            var playlistCollections = client.GetDatabase("Robots").GetCollection<Robot>("RobotDataSheets");
            Console.WriteLine("Enter robot 'id' for search and press ENTER...");
            var id = Console.ReadLine();
            var name = Builders<Robot>.Projection;
            var filter = Builders<Robot>.Filter.Eq("ObjectId", id);
            var results = playlistCollections.Find(filter);
            Console.WriteLine(Convert.ToString(results));
            Console.WriteLine(name);
            Console.ReadLine();
        }

        public void FindRobotDataSheetByName()
        {
            MongoClient client = new MongoClient("mongodb+srv://blackout:karina@cluster1.b9ndq.mongodb.net/?retryWrites=true&w=majority");
            var playlistCollections = client.GetDatabase("Robots").GetCollection<Robot>("RobotDataSheets");
            Console.WriteLine("Enter robot 'name' for search and press ENTER...");
            var name = Console.ReadLine();
            var filter = Builders<Robot>.Filter.Eq("Name", name);
            var results = playlistCollections.Find(filter);
            Console.WriteLine(Convert.ToString(results));
            Console.WriteLine(name);
            Console.ReadLine();
        }
    }
}
