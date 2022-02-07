using System;
using RockPaperScissor.Models;

namespace RockPaperScissor
{

  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Player One enter rock, paper, or scisors.");
      string playerOne = Console.ReadLine();
      Console.WriteLine("Player Two enter rock, paper, or scisors.");
      string playerTwo = Console.ReadLine();
      Game test = new Game(playerOne, playerTwo);
      test.WhoWillWin();
    }
  }
}