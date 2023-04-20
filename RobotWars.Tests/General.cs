using RobotWars.Core;

namespace RobotWars.Tests
{
    [TestClass]
    public class General
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
            var originalPosition = new Position(0, 4, "S");
            var robot = new Robot(new Position(-1, 4, "S"));
            robot.PenaltyCheck(originalPosition);

            Assert.AreEqual(1, robot.Penalty);
        }

        [TestCategory("Penalty")]
        [TestMethod]
        public void OutsideYAxis()
        {
            var originalPosition = new Position(0, 4, "E");
            var robot = new Robot(new Position(0, 5, "E"));
            robot.PenaltyCheck(originalPosition);

            Assert.AreEqual(1, robot.Penalty);
        }

        [TestCategory("Movement")]
        [TestMethod]
        public void MoveNorthAddToYAxis()
        {
            var robot = new Robot(new Position(0, 1, "N"));
            var moveForward = new MoveForward();
            robot.CurrentPosition = moveForward.Move(robot.CurrentPosition);

            Assert.AreEqual(2, robot.CurrentPosition.Y);
        }

        [TestCategory("Movement")]
        [TestMethod]
        public void MoveSouthSubtractFromYAxis()
        {
            var robot = new Robot(new Position(0, 1, "S"));
            var moveForward = new MoveForward();
            robot.CurrentPosition = moveForward.Move(robot.CurrentPosition);

            Assert.AreEqual(0, robot.CurrentPosition.Y);
        }

        [TestCategory("Movement")]
        [TestMethod]
        public void MoveEastAddToXAxis()
        {
            var robot = new Robot(new Position(1, 0, "E"));
            var moveForward = new MoveForward();
            robot.CurrentPosition = moveForward.Move(robot.CurrentPosition);

            Assert.AreEqual(2, robot.CurrentPosition.X);
        }

        [TestCategory("Movement")]
        [TestMethod]
        public void MoveWestSubtractFromXAxis()
        {
            var robot = new Robot(new Position(1, 0, "W"));
            var moveForward = new MoveForward();
            robot.CurrentPosition = moveForward.Move(robot.CurrentPosition);

            Assert.AreEqual(0, robot.CurrentPosition.X);
        }
    }
}