using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationException;

namespace TestingUserRegistration
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestingFirstName()
        {
            string message = null;
            string expected = "invalid";

            //Act
            UserException testing = new UserException(message);

            //handling exception
            try
            {
                string actual = testing.getValidUserFirstName();
            }
            catch (CustomException ex)
            {
                //Assert
                Assert.AreEqual(expected, ex.Message);
            }
        }
    }
}
