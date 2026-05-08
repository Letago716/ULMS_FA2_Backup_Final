using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace ULMS.Tests;

[TestClass]
public class MarksTests
{
    [TestMethod]
    public void Average_ShouldCalculateCorrectly()
    {
        double subject1 = 80;
        double subject2 = 70;
        double subject3 = 90;

        double average = (subject1 + subject2 + subject3) / 3.0;

        Assert.AreEqual(80, average);
    }

    [TestMethod]
    public void FaultyAverage_ShouldNotBeIncorrect()
    {
        double subject1 = 80;
        double subject2 = 70;
        double subject3 = 90;

        double faultyAverage = subject1 + subject2 + subject3 / 3.0;

        Assert.AreEqual(180, faultyAverage);
    }
}
