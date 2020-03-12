using Microsoft.VisualStudio.TestTools.UnitTesting;
using Counter.Models;
using System;

namespace Counter.Tests
{
  [TestClass]
  
  public class WordCounterTests
  {
    [TestMethod]
    public void InputConstructor_CreatesInstanceOfUserInput_String()
    {
      string userWord = "cat";
      string userSentence = "Today I need to buy cat food for my cat so my cat can eat something";
      UserInput newUserInput = new UserInput(userWord, userSentence);
      
      Assert.AreEqual(typeof(UserInput), newUserInput.GetType());
    }
    [TestMethod]
    public void InputConstructor_ApplicationCanReconizeNewUserWord_String()
    {
      string userWord = "cat";
      string userSentence = "cat";
      UserInput newUserInput = new UserInput(userWord, userSentence);
      
      Assert.AreEqual(newUserInput.UserWord, userSentence);
    }
    [TestMethod]
    public void InputConstructor_ApplicationCanReconizeNewUserSentenceSentence_String()
    {
      string userWord = "cat";
      string userSentence = "cat";
      UserInput newUserInput = new UserInput(userWord, userSentence);
      
      Assert.AreEqual(userWord, newUserInput.UserSentence);
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
    public void GetScore_CalculateWordScore_Int()
    {
      string userWord = "cat";
      string userSentence = "Today I need to buy cat food for my cat so my cat can eat something";
      UserInput newUserInput = new UserInput(userWord, userSentence);
      
      int score = newUserInput.GetScore();
    
      Assert.AreEqual(3, score);
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
      string userSentence = "I'm going to the dogpark to take my dog to meet other dogs";
      UserInput newUserInput = new UserInput(userWord, userSentence);
      
      int score = newUserInput.GetScore();
      
      Assert.AreEqual(1, score);
    }
    [TestMethod]
    public void CheckInput_CheckUserInputIsWord_True()
    {
      string userWord = "cat";
      string userSentence = "Today I'm taking my cat to the cathedral";
      UserInput newUserInput = new UserInput(userWord, userSentence);
      
      Assert.AreEqual(true,newUserInput.CheckInput());
    }
  }
}