using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RobertRover;

namespace RobertRoverTest
{
    [TestClass]
    public class RoverPositionTest
    {
        
        [TestMethod]
        public void Blank_Command_Sequence()
        {
            string expectedResult = "Provide input command";
            RoverPosition roverPosition = new RoverPosition();
            string result = roverPosition.Move("");

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Incomplete_Command_Sequence()
        {
            string expectedResult = "Incomplete command given";
            RoverPosition roverPosition = new RoverPosition();
            string result = roverPosition.Move("R1R2L2L");

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Invalid_Moving_Direction_Command_Sequence()
        {
            string expectedResult = "Invalid moving direction";
            RoverPosition roverPosition = new RoverPosition();
            string result = roverPosition.Move("P1Q2L2");

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Invalid_Moving_Step_Command_Sequence()
        {
            string expectedResult = "Invalid Moving step";
            RoverPosition roverPosition = new RoverPosition();
            string result = roverPosition.Move("R1RRL2");

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Impermissible_Movement_Command_Sequence()
        {
            string expectedResult = "Impermissible Movement";
            RoverPosition roverPosition = new RoverPosition();
            string result = roverPosition.Move("R1R9L2R9L2R9");

            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void ValidImpermissible_Movement_Command_Sequence()
        {
            string expectedResult = "[ 13 9 N ]";
            RoverPosition roverPosition = new RoverPosition();
            string result = roverPosition.Move("R1R2L2L1");

            Assert.AreEqual(expectedResult, result.Trim());
        }
    }
}
