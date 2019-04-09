using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RobotWars.Tests
{
    [TestClass]
    public class GeneralTests
    {
        [TestCategory("Direction")]
        [TestMethod]
        public void NorthLeftAreEqualToWest()
        {
            var newDirection = Direction.GetDirection("N", "L");
            Assert.AreEqual(newDirection, "W");
        }

        [TestCategory("Direction")]
        [TestMethod]
        public void NorthRightAreEqualToEast()
        {
            var newDirection = Direction.GetDirection("N", "R");
            Assert.AreEqual(newDirection, "E");
        }

        [TestCategory("Direction")]
        [TestMethod]
        public void SouthLeftAreEqualToEast()
        {
            var newDirection = Direction.GetDirection("S", "L");
            Assert.AreEqual(newDirection, "E");
        }

        [TestCategory("Direction")]
        [TestMethod]
        public void SouthRightAreEqualToWest()
        {
            var newDirection = Direction.GetDirection("S", "R");
            Assert.AreEqual(newDirection, "W");
        }

        [TestCategory("Direction")]
        [TestMethod]
        public void EastLeftAreEqualToNorth()
        {
            var newDirection = Direction.GetDirection("E", "L");
            Assert.AreEqual(newDirection, "N");
        }

        [TestCategory("Direction")]
        [TestMethod]
        public void EastRightAreEqualToSouth()
        {
            var newDirection = Direction.GetDirection("E", "R");
            Assert.AreEqual(newDirection, "S");
        }

        [TestCategory("Direction")]
        [TestMethod]
        public void WestLeftAreEqualToSouth()
        {
            var newDirection = Direction.GetDirection("W", "L");
            Assert.AreEqual(newDirection, "S");
        }

        [TestCategory("Direction")]
        [TestMethod]
        public void WestRightAreEqualToNorth()
        {
            var newDirection = Direction.GetDirection("W", "R");
            Assert.AreEqual(newDirection, "N");
        }

        [TestCategory("Penalty")]
        [TestMethod]
        public void OutsideXAxis()
        {
            var currentPosition = new Position(-1, 4, "N");
            Assert.IsTrue(Penalty.Check(currentPosition));
        }

        [TestCategory("Penalty")]
        [TestMethod]
        public void OutsideYAxis()
        {
            var currentPosition = new Position(0, 5, "N");
            Assert.IsTrue(Penalty.Check(currentPosition));
        }

        [TestCategory("Movement")]
        [TestMethod]
        public void MoveNorthAddToYAxis()
        {
            var currentPosition = new Position(0, 1, "N");
            Position newPosition = Movement.Move(currentPosition, "M", out _);

            Assert.AreEqual(2, newPosition.Y);
        }

        [TestCategory("Movement")]
        [TestMethod]
        public void MoveSouthSubtractFromYAxis()
        {
            var currentPosition = new Position(0, 1, "S");
            Position newPosition = Movement.Move(currentPosition, "M", out _);

            Assert.AreEqual(0, newPosition.Y);
        }

        [TestCategory("Movement")]
        [TestMethod]
        public void MoveEastAddToXAxis()
        {
            var currentPosition = new Position(1, 0, "E");
            Position newPosition = Movement.Move(currentPosition, "M", out _);

            Assert.AreEqual(2, newPosition.X);
        }

        [TestCategory("Movement")]
        [TestMethod]
        public void MoveWestSubtractFromXAxis()
        {
            var currentPosition = new Position(1, 0, "W");
            Position newPosition = Movement.Move(currentPosition, "M", out _);

            Assert.AreEqual(0, newPosition.X);
        }
    }
}
