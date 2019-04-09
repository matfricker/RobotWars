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
            int penalty = 0;

            Position currentPosition = scenario.Origin;
            Position newPostion = new Position();

            foreach (var i in scenario.Input.ToCharArray())
            {
                newPostion = Movement.Move(currentPosition, i.ToString(), out bool hasPenalty);

                if (hasPenalty)
                {
                    penalty++;
                }

                currentPosition = newPostion;
            }

            Position finalPosition = newPostion;

            Console.WriteLine("Final Position: {0}, {1}, {2}", finalPosition.X, finalPosition.Y, finalPosition.Direction);
            Console.WriteLine("Penalties: {0}", penalty);
            Console.WriteLine("");
        }
    }
}
