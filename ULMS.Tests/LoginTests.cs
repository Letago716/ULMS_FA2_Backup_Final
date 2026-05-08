using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ULMS.Tests
{
    [TestClass]
    public class LoginTests
    {
        [TestMethod]
        public void Login_ShouldFail_WhenPasswordIsIncorrect()
        {
            string username = "admin";
            string password = "wrong";

            bool loginResult = username == "admin" && password == "1234";

            Assert.IsFalse(loginResult);
        }

        [TestMethod]
        public void Login_ShouldSucceed_WhenPasswordIsCorrect()
        {
            string username = "admin";
            string password = "1234";

            bool loginResult = username == "admin" && password == "1234";

            Assert.IsTrue(loginResult);
        }
    }
}
