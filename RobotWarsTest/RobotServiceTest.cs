using Moq;
using Robot_Wars;
using Robot_Wars.BL;
using Robot_Wars.BL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RobotWarsTest
{
    public class RobotServiceTest
    {
        private IMove move;
        private RobotService robotService;

        public RobotServiceTest()
        {
            move = new Move();
            robotService = new RobotService(move);
        }

        [Fact]
        public void MoveRobot_TestScenario1()
        {
            var result = robotService.MoveRobot(new List<int> { 1, 2 }, "N", new List<string> { "L", "M", "L", "M", "L", "M", "L", "M", "M" });

            Assert.Equal(new List<int> { 1, 3 }, result.coordinates);
            Assert.Equal("N", result.heading);
        }

        [Fact]
        public void MoveRobot_TestScenario2()
        {
            var result = robotService.MoveRobot(new List<int> { 3, 3 }, "E", new List<string> { "M", "M", "R", "M", "M", "R", "M", "R", "R", "M" });

            Assert.Equal(new List<int> { 5, 1 }, result.coordinates);
            Assert.Equal("E", result.heading);
        }
    }
}
