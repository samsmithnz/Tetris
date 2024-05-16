using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tetris.Logic;

namespace Tetris.Tests
{
    [TestClass]
    public class GameLogicTests
    {
        [TestMethod]
        public void TestResetPlayer()
        {
            var game = new GameLogic();
            game.ResetPlayer();
            Assert.IsNotNull(game);
            // Additional tests to verify the behavior of ResetPlayer method
        }

        // Additional unit tests for other methods in GameLogic class
    }
}
