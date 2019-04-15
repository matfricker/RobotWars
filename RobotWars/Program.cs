using RobotWars.Library;
using System;

namespace RobotWars
{
    public class Program
    {
        static void Main(string[] args)
        {
            Scenario scenario1 = new Scenario
            {
                Origin = new Position(0, 2, "E"),
                Input = "MLMRMMMRMMRR"
            };

            Process(scenario1);

            Scenario scenario2 = new Scenario
            {
                Origin = new Position(4, 4, "S"),
                Input = "LMLLMMLMMMRMM"
            };

            Process(scenario2);

            Scenario scenario3 = new Scenario
            {
                Origin = new Position(2, 2, "W"),
                Input = "MLMLMLMRMRMRMRM"
            };

            Process(scenario3);

            Scenario scenario4 = new Scenario
            {
                Origin = new Position(1, 3, "N"),
                Input = "MMLMMLMMMMM"
            };

            Process(scenario4);

            Console.ReadLine();
        }

        private static void Process(Scenario scenario)
        {
            Robot robot = new Robot(scenario.Origin);

            foreach (var i in scenario.Input.ToCharArray())
            {
                robot.Input = i;

                if (i == 'L')
                {
                    robot.Move(new RotateLeft());
                }

                if (i == 'R')
                {
                    robot.Move(new RotateRight());
                }

                if (i == 'M')
                {
                    robot.Move(new MoveForward());
                }
            }

            Console.WriteLine("Final Position: {0}, {1}, {2}", robot.Position.X, robot.Position.Y, robot.Position.Direction);
            Console.WriteLine("Penalties: {0}", robot.Penalty);
            Console.WriteLine("");
        }
    }
}
