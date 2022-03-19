using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SchoolLibraryUnitTesting;

namespace SchoolLibraryUnitTest
{
    [TestClass]
    public class SchoolTest
    {
        [TestMethod]
        public void AverageThreeScoresTest()
        {
            var schoolLibrary = new School();
            float averageValue = schoolLibrary.AverageThreeScores(4.0f, 5.4f, 5.6f);
            Assert.AreEqual(5.0f, averageValue);

        }
        [TestMethod]
        public void ToStringMethodTest()
        {
            var schoolLibrary = new School();
            Assert.IsTrue(schoolLibrary.ToString().StartsWith("Name"));
        }

        [TestMethod]
        public void ConstructorInitializingTest()
        {
            var schoolLibrary = new School("HPS", "555-678-456");
            Assert.AreEqual(schoolLibrary.Name, "HPS");
        }
    }
}