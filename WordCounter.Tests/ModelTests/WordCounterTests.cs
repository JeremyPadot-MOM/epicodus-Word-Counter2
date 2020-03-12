using Microsoft.VisualStudio.TestTools.UnitTesting;
using Counter.Models;
using System;

namespace Counter.Tests
{
  [TestClass]
  
  public class WordCounterTests
  {
    [TestMethod]
    public void InputConstructor_CreatesInstanceOfUserInput_UserInput()
    {
      string userWord = "cat";
      string userSentence = "Today I need to buy cat food for my cat so my cat can eat something";
      UserInput newUserInput = new UserInput(userWord, userSentence);
      
      Assert.AreEqual(typeof(UserInput), newUserInput.GetType());
    }
    [TestMethod]
    public void InputConstructor_ApplicationCanReconizeWord_UserInput()
    {
      string userWord = "cat";
      string userSentence = "cat";
      UserInput newUserInput = new UserInput(userWord, userSentence);
      
      Assert.AreEqual(typeof(UserInput), newUserInput.GetType());
    }
    [TestMethod]
    public void GetScore_CalculateWordScore_Int()
    {
      string userWord = "cat";
      string userSentence = "Today I need to buy cat food for my cat so my cat can eat something";
      UserInput newUserInput = new UserInput(userWord, userSentence);
      
      int score = newUserInput.GetScore();
    
      Assert.AreEqual(3, score);
    }
       [TestMethod]
    public void GetScore_CalculateASingleWordScore_Int()
    {
      string userWord = "cat";
      string userSentence = "cat";
      UserInput newUserInput = new UserInput(userWord, userSentence);
      
      int score = newUserInput.GetScore();
    
      Assert.AreEqual(1, score);
    }
    [TestMethod]
    public void GetScore_ExcludeWordsWithSameCharacters_Int()
    {
      string userWord = "cat";
      string userSentence = "Today I'm taking my cat to the cathedral";
      UserInput newUserInput = new UserInput(userWord, userSentence);
      
      int score = newUserInput.GetScore();
      
      Assert.AreEqual(1, score);
    }
    [TestMethod]
    public void GetWordScore_StillAddingScoreAfterWordIncludedInAnotherWord_Int()
    {
      string userWord = "dog";
      string userSentence = "I'd like to take my dog to the dogpark to meet other dogs";
      UserInput newUserInput = new UserInput(userWord, userSentence);
      
      int score = newUserInput.GetScore();
      
      Assert.AreEqual(1, score);
    }
    [TestMethod]
    public void CheckInput_CheckUserInputIsWord_CheckInput()
    {
      string userWord = "c1a2t";
      string userSentence = "Today I'm taking my cat to the cathedral";
      UserInput newUserInput = new UserInput(userWord, userSentence);
      
      Assert.AreEqual(true,newUserInput.CheckInput());
    }
  }
}