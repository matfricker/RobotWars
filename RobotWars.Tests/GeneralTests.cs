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
            var newDirection = Direction.GetDirection("N", 'L');
            Assert.AreEqual(newDirection, "W");
        }

        [TestCategory("Direction")]
        [TestMethod]
        public void NorthRightAreEqualToEast()
        {
            var newDirection = Direction.GetDirection("N", 'R');
            Assert.AreEqual(newDirection, "E");
        }

        [TestCategory("Direction")]
        [TestMethod]
        public void SouthLeftAreEqualToEast()
        {
            var newDirection = Direction.GetDirection("S", 'L');
            Assert.AreEqual(newDirection, "E");
        }

        [TestCategory("Direction")]
        [TestMethod]
        public void SouthRightAreEqualToWest()
        {
            var newDirection = Direction.GetDirection("S", 'R');
            Assert.AreEqual(newDirection, "W");
        }

        [TestCategory("Direction")]
        [TestMethod]
        public void EastLeftAreEqualToNorth()
        {
            var newDirection = Direction.GetDirection("E", 'L');
            Assert.AreEqual(newDirection, "N");
        }

        [TestCategory("Direction")]
        [TestMethod]
        public void EastRightAreEqualToSouth()
        {
            var newDirection = Direction.GetDirection("E", 'R');
            Assert.AreEqual(newDirection, "S");
        }

        [TestCategory("Direction")]
        [TestMethod]
        public void WestLeftAreEqualToSouth()
        {
            var newDirection = Direction.GetDirection("W", 'L');
            Assert.AreEqual(newDirection, "S");
        }

        [TestCategory("Direction")]
        [TestMethod]
        public void WestRightAreEqualToNorth()
        {
            var newDirection = Direction.GetDirection("W", 'R');
            Assert.AreEqual(newDirection, "N");
        }

        [TestCategory("Penalty")]
        [TestMethod]
        public void OutsideXAxis()
        {
            var position = new Position(-1, 4, "N");
            Robot robot = new Robot(position);

            Assert.IsTrue(robot.PenaltyCheck(position));
        }

        [TestCategory("Penalty")]
        [TestMethod]
        public void OutsideYAxis()
        {
            var position = new Position(0, 5, "N");
            Robot robot = new Robot(position);

            Assert.IsTrue(robot.PenaltyCheck(position));
        }

        [TestCategory("Movement")]
        [TestMethod]
        public void MoveNorthAddToYAxis()
        {
            var position = new Position(0, 1, "N");
            Robot robot = new Robot(position);
            robot.Move('M');

            Assert.AreEqual(2, robot.Position.Y);
        }

        [TestCategory("Movement")]
        [TestMethod]
        public void MoveSouthSubtractFromYAxis()
        {
            var position = new Position(0, 1, "S");
            Robot robot = new Robot(position);
            robot.Move('M');

            Assert.AreEqual(0, robot.Position.Y);
        }

        [TestCategory("Movement")]
        [TestMethod]
        public void MoveEastAddToXAxis()
        {
            var position = new Position(1, 0, "E");
            Robot robot = new Robot(position);
            robot.Move('M');

            Assert.AreEqual(2, robot.Position.X);
        }

        [TestCategory("Movement")]
        [TestMethod]
        public void MoveWestSubtractFromXAxis()
        {
            var position = new Position(1, 0, "W");
            Robot robot = new Robot(position);
            robot.Move('M');

            Assert.AreEqual(0, robot.Position.X);
        }
    }
}
