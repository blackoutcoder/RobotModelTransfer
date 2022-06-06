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

    }
}
