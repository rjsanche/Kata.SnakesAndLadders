using Microsoft.VisualStudio.TestTools.UnitTesting;
using SnakesAndLadders;

namespace SnakesAndLaddersTest
{
    [TestClass]
    public class SnakesAndLaddersShould
    {
        [TestMethod]
        public void GivenTheGameStartedTokenIsOnSquare1()
        {
            //arrange
            var expected = 1;
            SnakesAndLaddersEngine snakesAndLadders = new SnakesAndLaddersEngine();
            //act
            var actual = snakesAndLadders.GetCurrentPosition();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenTheTokenIn1Move3ThenJumpIntoSquare4()
        {
            //arrange
            var expected = 4;
            SnakesAndLaddersEngine snakesAndLadders = new SnakesAndLaddersEngine();
            snakesAndLadders.Move(3);
            //act
            var actual = snakesAndLadders.GetCurrentPosition();
            //assert
            Assert.AreEqual(expected, actual);
        }

    }
}
