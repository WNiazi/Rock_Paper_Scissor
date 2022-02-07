using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissor.Models;

namespace RockPaperScissor.Tests
{
  [TestClass]
  public class GameTest
  {

    [TestMethod]
    public void IsPlayerBeingBroughtIn_BothPlayers_String()
    {
      string playerOne = "rock";
      string playerTwo = "rock";

      Game test = new Game(playerOne, playerTwo);
      string result = test.PlayerOne;
      string result2 = test.PlayerTwo;
      Assert.AreEqual(playerOne, result);
      Assert.AreEqual(playerTwo, result2);
    }
    [TestMethod]
    public void IsScoreBeingBroughtIn_BothPlayers_String()
    {
      string playerOne = "rock";
      string playerTwo = "paper";
      Game test = new Game(playerOne, playerTwo);
      test.WhoWillWin();
      Assert.AreEqual("PlayerTwo wins!", test.WhoWillWin());
    }
    [TestMethod]
    public void IsCheckingOtherOptions_BothPlayers_String()
    {
      string playerOne = "rock";
      string playerTwo = "rock";
      Game test = new Game(playerOne, playerTwo);
      test.WhoWillWin();
      Assert.AreEqual("it is a tie", test.WhoWillWin());
    }
    [TestMethod]
    public void IsCheckingOptions_BothPlayers_String()
    {
      string playerOne = "rock";
      string playerTwo = "scissor";
      Game test = new Game(playerOne, playerTwo);
      test.WhoWillWin();
      Assert.AreEqual("PlayerOne wins!", test.WhoWillWin());
    }
  }
}