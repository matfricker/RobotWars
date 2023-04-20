using RobotWars.Core;

namespace RobotWars.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var scenario1 = new Scenario
            {
                Origin = new Position(0, 2, "E"),
                Input = "MLMRMMMRMMRR"
            };

            Run(scenario1);

            var scenario2 = new Scenario
            {
                Origin = new Position(4, 4, "S"),
                Input = "LMLLMMLMMMRMM"
            };

            Run(scenario2);

            var scenario3 = new Scenario
            {
                Origin = new Position(2, 2, "W"),
                Input = "MLMLMLMRMRMRMRM"
            };

            Run(scenario3);

            var scenario4 = new Scenario
            {
                Origin = new Position(1, 3, "N"),
                Input = "MMLMMLMMMMM"
            };

            Run(scenario4);

            System.Console.ReadLine();
        }

        private static void Run(Scenario scenario)
        {
            var robot = new Robot(scenario.Origin);

            foreach (var c in scenario.Input.ToCharArray())
            {
                switch (ConvertCharToEnum(c))
                {
                    case MovementDirection.Left:
                        robot.Move(new RotateLeft());
                        break;
                    case MovementDirection.Right:
                        robot.Move(new RotateRight());
                        break;
                    case MovementDirection.Forward:
                        robot.Move(new MoveForward());
                        break;
                }
            }

            System.Console.WriteLine("Final Position: {0}, {1}, {2}",
                robot.CurrentPosition.X,
                robot.CurrentPosition.Y,
                robot.CurrentPosition.Direction);

            System.Console.WriteLine("Penalties: {0}",
                robot.Penalty);

            System.Console.WriteLine("");
        }

        private static MovementDirection ConvertCharToEnum(char character)
        {
            if (character == 'M')
                return MovementDirection.Forward;

            if (character == 'L')
                return MovementDirection.Left;

            if (character == 'R')
                return MovementDirection.Right;

            throw new ArgumentException($"Invalid Character Passed: {character}.");
        }
    }
}