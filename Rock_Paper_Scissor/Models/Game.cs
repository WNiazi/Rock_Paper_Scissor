using System;

namespace RockPaperScissor.Models
{

  public class Game
  {
    public string PlayerOne { get; set; }
    public string PlayerTwo { get; set; }
    public Game(string playerOne, string playerTwo)
    {
      PlayerOne = playerOne;
      PlayerTwo = playerTwo;
    }
    public string WhoWillWin()
    {
      if (PlayerOne == "rock")
      {
        if (PlayerTwo == "scissor")
        {
          return ("PlayerOne wins!");
        }
        else if (PlayerTwo == "paper")
        {
          return ("PlayerTwo wins!");
        }
        else
        {
          return ("it is a tie");
        }

      }
      else if (PlayerOne == "scissor")
      {
        if (PlayerTwo == "scissor")
        {
          return ("it is a tie!");
        }
        else if (PlayerTwo == "paper")
        {
          return ("PlayerOne wins!");
        }
        else
        {
          return ("PlayerOne wins");
        }
      }
      else
      {
        if (PlayerTwo == "scissor")
        {
          return ("PlayerTwo wins");
        }
        else if (PlayerTwo == "paper")
        {
          return ("it is a tie");
        }
        else
        {
          return ("PlayerTwo wins");
        }
      }
    }

  }
}
