using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;

namespace MoodTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
         public void sadmood()
            {
                // Arrange
                string excepted = "HAPPY";
                string message = "i am in sad mood";   //here to pass a null for second uc
                Mood objmood = new Mood(message);
                
                //Act
                string mood = objmood.AnalyseMood();

                //Assert
                Assert.AreEqual(excepted, mood);
            }
        
    }
}