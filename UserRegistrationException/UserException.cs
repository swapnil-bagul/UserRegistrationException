using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Text;

namespace UserRegistrationException
{
    public class UserException
    {
        //instance variable
        public string message;
        //constructor to intitialise

        public UserException(string message)
        {
            this.message = message;

        }

        //User Registration Pattern
        string firstNamePattern = "^[A-Z]{1}[a-z]{2}$";
        string lastNamePattern = "^[A-Z]{1}[a-z]{2}$";
        string mobileNoPattern = "^[1-9]{2}[ ]{1}[0-9]{10}$";
        string emailPattern = "^[a-z]{3}[.][a-z]*[@]{1}[bl]{2}[.]{1}[co]{2}[.]{1}[a-z]*$";

        public string getValidUserFirstName()
        {
            Regex regex = new Regex(firstNamePattern);
            try
            {
                if (regex.IsMatch(message))
                {
                    //Console.WriteLine(word + "---> valid");
                    return "valid";
                }
                else
                    return "invalid";

            }
            catch (ArgumentNullException ex)
            {
                throw new CustomException(CustomException.ExceptionType.ArgumentNullException, "invalid");
                //Console.WriteLine(ex);
            }

        }

        public string getvalidUserLastName()
        {

            Regex regex = new Regex(lastNamePattern);
            try
            {
                if (regex.IsMatch(message))
                {
                    //Console.WriteLine(word + "---> valid");
                    return "valid";
                }
                else
                    return "invalid";

            }
            catch (ArgumentNullException ex)
            {
                throw new CustomException(CustomException.ExceptionType.ArgumentNullException, "invalid");
                //Console.WriteLine(ex);
            }
        }

        //method for validating mobile number
        public string getValidUserMobileNumber()
        {
            Regex regex = new Regex(mobileNoPattern);
            try
            {
                if (regex.IsMatch(message))
                {
                    //Console.WriteLine(word + "---> valid");
                    return "valid";
                }
                else
                    return "invalid";

            }
            catch (Exception ex)
            {
                throw new CustomException(CustomException.ExceptionType.ArgumentNullException, "invalid");
                //Console.WriteLine(ex);
            }

        }
        //method to validating email
        public string getValidUserEmail()
        {
            Regex regex = new Regex(emailPattern);
            try
            {
                if (regex.IsMatch(message))
                {
                    //Console.WriteLine(word + "---> valid");
                    return "valid";
                }
                else
                    return "invalid";

            }
            catch (Exception ex)
            {
                throw new CustomException(CustomException.ExceptionType.ArgumentNullException, "invalid");
                //Console.WriteLine(ex);
            }
        }

    }
}
