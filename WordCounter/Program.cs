using System;
using Counter.Models;
using System.Collections.Generic;

namespace Counter
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Please enter a word!");
      string response = Console.ReadLine();

      Console.WriteLine("Please enter a sentence and I'll tell you how many times the word appeared!");
      string sentence = Console.ReadLine();
      UserInput newResponse = new UserInput(response, sentence);

      int score = newResponse.GetScore();
      Console.WriteLine("your word appeared " + score + " times.");
    }
  }
}