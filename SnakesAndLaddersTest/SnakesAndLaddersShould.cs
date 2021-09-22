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
            
            SnakesAndLaddersEngine snakesAndLadders = new SnakesAndLaddersEngine(new Dice());
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
            SnakesAndLaddersEngine snakesAndLadders = new SnakesAndLaddersEngine(new Dice());
            snakesAndLadders.Move(3);
            //act
            var actual = snakesAndLadders.GetCurrentPosition();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenTheTokenIn1Move3NextMove4ThenJumpIntoSquare8()
        {
            //arrange
            var expected = 8;
            SnakesAndLaddersEngine snakesAndLadders = new SnakesAndLaddersEngine(new Dice());
            snakesAndLadders.Move(3);
            snakesAndLadders.Move(4);
            //act
            var actual = snakesAndLadders.GetCurrentPosition();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenTheTokenIn97Move3ThenJumpIntoSquare100_PlayerWins()
        {
            //arrange
            var expected = 100;
            var expectedWin = true;
            SnakesAndLaddersEngine snakesAndLadders = new SnakesAndLaddersEngine(new Dice());
            
            while(snakesAndLadders.GetCurrentPosition() != 97)
            {
                snakesAndLadders.Move(1);
            }
            snakesAndLadders.Move(3);
            //act
            var actual = snakesAndLadders.GetCurrentPosition();
            var actualPlayerWin = snakesAndLadders.PlayerWin();
            //assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expectedWin, actualPlayerWin);
        }

        [TestMethod]
        public void GivenTheTokenIn97Move4BounceIntoSquare97()
        {
            //arrange
            var expected = 97;
            SnakesAndLaddersEngine snakesAndLadders = new SnakesAndLaddersEngine(new Dice());

            while (snakesAndLadders.GetCurrentPosition() != 97)
            {
                snakesAndLadders.Move(1);
            }
            snakesAndLadders.Move(4);
            //act
            var actual = snakesAndLadders.GetCurrentPosition();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenTheGameStartedRollsDieResultRange1_6_inclusive()
        {
            //arrange
            var expectedMin = 1;
            var expectedMax = 6;
            SnakesAndLaddersEngine snakesAndLadders = new SnakesAndLaddersEngine(new Dice());

            //act
            var actual = snakesAndLadders.RollDie();
            //assert
            Assert.IsTrue(expectedMin <= actual);
            Assert.IsTrue(expectedMax >= actual);
        }

        [TestMethod]
        public void GivenThePlayerRolls4ThenMoveTheirTokenThenMove4Spaces()
        {
            //arrange
            var expected = 5;

            SnakesAndLaddersEngine snakesAndLadders = new SnakesAndLaddersEngine(new FakeDice(4));
            
            //act
            snakesAndLadders.RollDie();           

            var actual = snakesAndLadders.GetCurrentPosition();
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GivenThereIsASnakeConnectingSquares2and12sWhenTokenIsIn12ThenReturnTo2()
        {
            //arrange
            var expected = 2;

            SnakesAndLaddersEngine snakesAndLadders = new SnakesAndLaddersEngine(new FakeDice(11));

            //act
            snakesAndLadders.RollDie();

            var actual = snakesAndLadders.GetCurrentPosition();
            //assert
            Assert.AreEqual(expected, actual);
        }

    }
}
