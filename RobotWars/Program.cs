using RobotWars.Library;
using System;

namespace RobotWars
{
    public class Program
    {
        static void Main(string[] args)
        {
            Scenario scenario1 = new Scenario();
            scenario1.Origin = new Position(0, 2, "E");
            scenario1.Input = "MLMRMMMRMMRR";
            Process(scenario1);

            Scenario scenario2 = new Scenario();
            scenario2.Origin = new Position(4, 4, "S");
            scenario2.Input = "LMLLMMLMMMRMM";
            Process(scenario2);

            Scenario scenario3 = new Scenario();
            scenario3.Origin = new Position(2, 2, "W");
            scenario3.Input = "MLMLMLMRMRMRMRM";
            Process(scenario3);

            Scenario scenario4 = new Scenario();
            scenario4.Origin = new Position(1, 3, "N");
            scenario4.Input = "MMLMMLMMMMM";
            Process(scenario4);

            Console.ReadLine();
        }

        private static void Process(Scenario scenario)
        {
            Robot robot = new Robot(scenario.Origin);

            foreach (var i in scenario.Input.ToCharArray())
            {
                robot.Move(i);
            }

            Console.WriteLine("Final Position: {0}, {1}, {2}", robot.Position.X, robot.Position.Y, robot.Position.Direction);
            Console.WriteLine("Penalties: {0}", robot.Penalty);
            Console.WriteLine("");
        }
    }
}
