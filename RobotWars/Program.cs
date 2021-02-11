using RobotWars.Library;
using System;

namespace RobotWars
{
    public class Program
    {
        static void Main(string[] args)
        {
            var scenario1 = new Scenario
            {
                Origin = new Position(0, 2, "E"),
                Input = "MLMRMMMRMMRR"
            };

            Process(scenario1);

            var scenario2 = new Scenario
            {
                Origin = new Position(4, 4, "S"),
                Input = "LMLLMMLMMMRMM"
            };

            Process(scenario2);

            var scenario3 = new Scenario
            {
                Origin = new Position(2, 2, "W"),
                Input = "MLMLMLMRMRMRMRM"
            };

            Process(scenario3);

            var scenario4 = new Scenario
            {
                Origin = new Position(1, 3, "N"),
                Input = "MMLMMLMMMMM"
            };

            Process(scenario4);

            Console.ReadLine();
        }

        private static void Process(Scenario scenario)
        {
            var robot = new Robot(scenario.Origin);

            foreach (var i in scenario.Input.ToCharArray())
            {
                switch (i)
                {
                    case 'L':
                        robot.Move(new RotateLeft());
                        break;
                    case 'R':
                        robot.Move(new RotateRight());
                        break;
                    case 'M':
                        robot.Move(new MoveForward());
                        break;
                }
            }

            Console.WriteLine("Final Position: {0}, {1}, {2}", robot.CurrentPosition.X, robot.CurrentPosition.Y, robot.CurrentPosition.Direction);
            Console.WriteLine("Penalties: {0}", robot.Penalty);
            Console.WriteLine("");
        }
    }
}
