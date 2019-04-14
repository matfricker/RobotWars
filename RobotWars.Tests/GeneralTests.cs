using Microsoft.VisualStudio.TestTools.UnitTesting;
using RobotWars.Library;

namespace RobotWars.Tests
{
    [TestClass]
    public class GeneralTests
    {
        [TestCategory("Direction")]
        [TestMethod]
        public void NorthLeftAreEqualToWest()
        {
            var newDirection = Direction.GetDirection("N", MovementDirection.Left);
            Assert.AreEqual(newDirection, "W");
        }

        [TestCategory("Direction")]
        [TestMethod]
        public void NorthRightAreEqualToEast()
        {
            var newDirection = Direction.GetDirection("N", MovementDirection.Right);
            Assert.AreEqual(newDirection, "E");
        }

        [TestCategory("Direction")]
        [TestMethod]
        public void SouthLeftAreEqualToEast()
        {
            var newDirection = Direction.GetDirection("S", MovementDirection.Left);
            Assert.AreEqual(newDirection, "E");
        }

        [TestCategory("Direction")]
        [TestMethod]
        public void SouthRightAreEqualToWest()
        {
            var newDirection = Direction.GetDirection("S", MovementDirection.Right);
            Assert.AreEqual(newDirection, "W");
        }

        [TestCategory("Direction")]
        [TestMethod]
        public void EastLeftAreEqualToNorth()
        {
            var newDirection = Direction.GetDirection("E", MovementDirection.Left);
            Assert.AreEqual(newDirection, "N");
        }

        [TestCategory("Direction")]
        [TestMethod]
        public void EastRightAreEqualToSouth()
        {
            var newDirection = Direction.GetDirection("E", MovementDirection.Right);
            Assert.AreEqual(newDirection, "S");
        }

        [TestCategory("Direction")]
        [TestMethod]
        public void WestLeftAreEqualToSouth()
        {
            var newDirection = Direction.GetDirection("W", MovementDirection.Left);
            Assert.AreEqual(newDirection, "S");
        }

        [TestCategory("Direction")]
        [TestMethod]
        public void WestRightAreEqualToNorth()
        {
            var newDirection = Direction.GetDirection("W", MovementDirection.Right);
            Assert.AreEqual(newDirection, "N");
        }

        [TestCategory("Penalty")]
        [TestMethod]
        public void OutsideXAxis()
        {
            Position originalPosition = new Position(0, 4, "S");
            Position position = new Position(-1, 4, "S");
            Robot robot = new Robot()
            {
                Position = position
            };

            robot.PenaltyCheck(originalPosition);

            Assert.AreEqual(1, robot.Penalty);
        }

        [TestCategory("Penalty")]
        [TestMethod]
        public void OutsideYAxis()
        {
            Position originalPosition = new Position(0, 4, "E");
            Position position = new Position(0, 5, "E");
            Robot robot = new Robot()
            {
                Position = position
            };

            robot.PenaltyCheck(originalPosition);

            Assert.AreEqual(1, robot.Penalty);
        }

        [TestCategory("Movement")]
        [TestMethod]
        public void MoveNorthAddToYAxis()
        {
            var position = new Position(0, 1, "N");
            Robot robot = new Robot()
            {
                Position = position,
                Input = 'M'
            };

            MoveForward moveForward = new MoveForward();
            robot.Position = moveForward.Move(robot.Position);

            Assert.AreEqual(2, robot.Position.Y);
        }

        [TestCategory("Movement")]
        [TestMethod]
        public void MoveSouthSubtractFromYAxis()
        {
            var position = new Position(0, 1, "S");
            Robot robot = new Robot()
            {
                Position = position,
                Input = 'M'
            };

            MoveForward moveForward = new MoveForward();
            robot.Position = moveForward.Move(robot.Position);

            Assert.AreEqual(0, robot.Position.Y);
        }

        [TestCategory("Movement")]
        [TestMethod]
        public void MoveEastAddToXAxis()
        {
            var position = new Position(1, 0, "E");
            Robot robot = new Robot()
            {
                Position = position,
                Input = 'M'
            };

            MoveForward moveForward = new MoveForward();
            robot.Position = moveForward.Move(robot.Position);

            Assert.AreEqual(2, robot.Position.X);
        }

        [TestCategory("Movement")]
        [TestMethod]
        public void MoveWestSubtractFromXAxis()
        {
            var position = new Position(1, 0, "W");
            Robot robot = new Robot()
            {
                Position = position,
                Input = 'M'
            };

            MoveForward moveForward = new MoveForward();
            robot.Position = moveForward.Move(robot.Position);

            Assert.AreEqual(0, robot.Position.X);
        }
    }
}
