using System;
using System.Collections.Generic;

namespace Counter.Models
{
  public class UserInput
  {
    public string UserWord {get; set;}
    public string UserSentence {get; set;}
    
    public UserInput(string userWord, string userSentence)
    {
      UserWord = userWord;
      UserSentence = userSentence;
    }
  
    public int GetScore()
    {
      int wordScore = 0;
      string[] splitString = UserSentence.Split();
      
      for(int i = 0; i < splitString.Length; i++)
      {
        if (splitString[i]==(UserWord))
        {
          wordScore +=1;
        }
      }
      return wordScore;
    }

    public bool CheckInput()
    {
      char[] checkWord = UserWord.ToCharArray();
      for (int i = 0; i < checkWord.Length; i++)
      {
        bool correct = Char.IsLetter(checkWord[i]);
        if (correct == false)
        {
          return false;
        }
      }
        return true;
    }
  }
}
