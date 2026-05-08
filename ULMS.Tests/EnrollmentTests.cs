using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ULMS.Tests;

[TestClass]
public class EnrollmentTests
{
    [TestMethod]
    public void Enrollment_ShouldFall_WhenRequiredFieldsAreBlack()
    {
        string studentId = "";
        string courseCode = "";
        string semester = "";

        bool fieldsValid = 
            !string.IsNullOrWhiteSpace(studentId) &&
            !string.IsNullOrWhiteSpace(courseCode) &&
            !string.IsNullOrWhiteSpace(semester);

        Assert.IsFalse(fieldsValid);
    }

    [TestMethod]
    public void Enrollment_ShouldPass_WhenRequiredFieldsAreFilled()
    {
        string studentId = "ST001";
        string courseCode = "SDT621";
        string semester = "Semester 1";

        bool fieldsValid =
            !string.IsNullOrWhiteSpace(studentId) &&
            !string.IsNullOrWhiteSpace(courseCode) &&
            !string.IsNullOrWhiteSpace(semester);

        Assert.IsTrue(fieldsValid);
    }
}
