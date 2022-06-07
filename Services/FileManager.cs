using System;
using System.IO;
using System.Text.Json;
using Models;

namespace Services
{
    public class FileManager
    {
        public Robot robot { get; set; }
        public void WriteToFile(Robot robot)
        {
            string path = @"C:\Users\romka\source\repos\RobotModelTransfer\Services\";
            var options = new JsonSerializerOptions { WriteIndented = true };
            string text = JsonSerializer.Serialize(robot, options);
            File.WriteAllText(@$"{path}RobotData.txt", text);
        }

        public Robot DeserializeDataFile(string file)
        {
            string filepath = @$"C:\Users\romka\source\repos\RobotModelTransfer\Services\{file}";
            var jsonString = File.ReadAllText(filepath);
            Robot robotData = JsonSerializer.Deserialize<Robot>(jsonString);
            Console.WriteLine($">Robot id: {robotData.Id}.");
            Console.WriteLine($">Robot name: {robotData.Name}.");
            Console.WriteLine($">Number of arms: {robotData.Arms.Count}. Material: {robotData.Arms[1].Material}, number of fingers: {robotData.Arms[1].NumberOfFingers}, number of joints: {robotData.Arms[1].NumberOfJoints}.");
            Console.WriteLine($">Number of legs: {robotData.Legs.Count}. Material: {robotData.Legs[1].Material}, number of joints: {robotData.Legs[1].NumberOfJoints}, size of foot: {robotData.Legs[1].SizeOfFoot} Cm.");
            Console.WriteLine($">Robot torso chest measurements: {robotData.Torso.ChestMeasurements}, waist measurements: {robotData.Torso.WaistMeasurements}");
            Console.WriteLine($">Robot head color: {robotData.Head.Color}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("");
            Console.WriteLine("Data file successfully loaded!");

            return robotData;
        }

        public Robot DeserializeDataQuick(string file)
        {
            string filepath = @$"C:\Users\romka\source\repos\RobotModelTransfer\Services\{file}";
            var jsonString = File.ReadAllText(filepath);
            Robot robotData = JsonSerializer.Deserialize<Robot>(jsonString);
            return robotData;
        }
    }
}
