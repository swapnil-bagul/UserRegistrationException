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
        //test to checking lastneme
        [TestMethod]
        public void TestUserLastName()
        {
            string message = null;
            string expected = "invalid";

            //Act
            UserException testing = new UserException(message);

            //handling exception
            try
            {
                string actual = testing.getvalidUserLastName();
            }
            catch (CustomException ex)
            {
                //Assert
                Assert.AreEqual(expected, ex.Message);
            }
        }
        //test to check mobilenumber
        [TestMethod]
        public void TestUserMobileNumber()
        {
            string message = null;
            string expected = "invalid";

            //Act
            UserException testing = new UserException(message);

            try
            {
                string actual = testing.getValidUserMobileNumber();
            }
            catch (CustomException ex)
            {
                //Assert
                Assert.AreEqual(expected, ex.Message);
            }
        }

        //Test for checking Email
        [TestMethod]
        public void TestUserEmail()
        {
            string message = null;
            string expected = "invalid";

            //Act
            UserException testing = new UserException(message);

            try
            {
                string actual = testing.getValidUserEmail();
            }
            catch (CustomException ex)
            {
                //Assert
                Assert.AreEqual(expected, ex.Message);
            }
        }
    }
}
