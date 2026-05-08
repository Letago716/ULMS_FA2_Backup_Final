using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ULMS.Tests;

[TestClass]
public class RegistrationTests
{
    [TestMethod]
    public void Age_ShouldFail_WhenInputIsNotNumeric()
    {
        string ageInput = "abc";

        bool isValidAge = int.TryParse(ageInput, out int age);

        Assert.IsFalse(isValidAge);
    }

    [TestMethod]
    public void Age_ShouldSucceed_WhenInputIsNumeric()
    {
        string ageInput = "20";

        bool isValidAge = int.TryParse(ageInput, out int age);

        Assert.IsTrue(isValidAge);

        Assert.AreEqual(20, age);
    }
    [TestMethod]
    public void Registration_ShouldFail_WhenRequiredFieldsAreEmpty()
    {
        string studentId = "";
        string fullName = "";
        string email = "";
        string age = "";
        string programme = "";
        bool fieldsValid = !string.IsNullOrWhiteSpace(studentId) &&
                                   !string.IsNullOrWhiteSpace(fullName) &&
                                   !string.IsNullOrWhiteSpace(email) &&
                                   !string.IsNullOrWhiteSpace(age) &&
                                   !string.IsNullOrWhiteSpace(programme);
        Assert.IsFalse(fieldsValid);
    }
    [TestMethod]
    public void Registration_ShouldSucceed_WhenAllFieldsAreFilled()
    {
        string studentId = "ST001";
        string fullName = "John Smith";
        string email = "john@gmail.com";
        string ageInput = "20";
        string programme = "Software Engineering";
        bool fieldsValid = !string.IsNullOrWhiteSpace(studentId) &&
                                   !string.IsNullOrWhiteSpace(fullName) &&
                                   !string.IsNullOrWhiteSpace(email) &&
                                   !string.IsNullOrWhiteSpace(ageInput) &&
                                   !string.IsNullOrWhiteSpace(programme);

        bool ageValid = int.TryParse(ageInput, out int age);

        Assert.IsTrue(fieldsValid);
        Assert.IsTrue(ageValid);
        Assert.AreEqual(20, age);
    }
}
