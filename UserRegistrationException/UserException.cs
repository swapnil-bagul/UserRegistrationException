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

        
    }
}
