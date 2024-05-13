using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HiTechLibrary.VALIDATION
{
    public class Validator
    {
        //Validate  Id
        public static bool IsValid(string id)
        {
            if (!Regex.IsMatch(id, @"^\d{7}$"))
            {
                return false;
            }
            return true;
        }

        //Validate ID- Length will be given as a parameter 
        public static bool IsValid(string id, int size)
        {
            if (!Regex.IsMatch(id, @"^\d{" + size + "}$"))
            {
                return false;
            }
            return true;
        }

        //Validate First or Last name
        public static bool IsValidName(string name)
        {
            if (name.Length == 0)
            {
                return false;
            }

            else
            {
                for (int i = 0; i < name.Length; i++)
                {
                    if ((!Char.IsLetter(name[i])) && (!Char.IsWhiteSpace(name[i])))
                    {
                        return false;

                    }

                }

            }

            return true;
        }

        //validate Password
        public static bool IsValidPassword(string password)
        {
            // Check if the password is atleast 8 characters long and not too long
            if (password.Length < 8 || password.Length>20)
            {
                return false;
            }

            // Check for at least one uppercase letter
            if (!Regex.IsMatch(password, @"[A-Z]"))
            {
                return false;
            }

            // Check for at least one lowercase letter
            if (!Regex.IsMatch(password, @"[a-z]"))
            {
                return false;
            }

            // Check for at least one special character
            if (!Regex.IsMatch(password, @"[\W_]"))
            {
                return false;
            }

            return true;
        }

        //Email validation
        public static bool IsValidEmail(string email)
        {
            // Regex pattern for email validation
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }

        //Phone Number Validation
        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            // Regex pattern for phone number validation
            string pattern = @"^\+?(\d{1,3})?[-. (]?\d{3}[-. )]?\d{3}[-. ]?\d{4}$";

            return Regex.IsMatch(phoneNumber, pattern);
        }
        //Fax Number Validation
        public static bool IsValidFaxNumber(string faxNumber)
        {
            string pattern = @"^1-\d{3}-\d{3}-\d{4}$";
            return Regex.IsMatch(faxNumber, pattern);
        }

        //Postal Code Validation
        public static bool IsValidPostalCode(string postalCode)
        {
            if (postalCode.Length == 0)
            {
                return false;
            }
            string pattern = @"^[A-Za-z]\d[A-Za-z] \d[A-Za-z]\d$";
            return Regex.IsMatch(postalCode, pattern);
        }

        //City validation
        public static bool IsValidCity(string cityName)
        {
            if (cityName.Length == 0)
            {
                return false;
            }
            string pattern = @"^[A-Za-z\s\-']+$";
            return Regex.IsMatch(cityName, pattern);
        }

        //Street validation
        public static bool IsValidStreetAddress(string streetAddress)
        {
            if (streetAddress.Length == 0)
            {
                return false;
            }
            string pattern = @"^[A-Za-z0-9\s\.,\-']+$";
            return Regex.IsMatch(streetAddress, pattern);
        }
        //Credit Limit Validation
        public static bool IsValidCreditLimit(string creditLimit)
        {
            // Check if the credit limit is empty
            if (creditLimit.Length == 0)
            {
                return false;
            }
            string pattern = @"^\$\s\d+(,\d{3})*(\.\d+)?$";
            return Regex.IsMatch(creditLimit, pattern);
        }

        //Validation to check Input strings not Empty
        public static bool IsInputEmpty(string input)
        {
            return string.IsNullOrEmpty(input);
            
        }

        //Validation to check if input is integer
        public static bool IsValidInteger(string inputText, out int input)
        {
            if (!int.TryParse(inputText, out input))
            {
                //if parsing fails
                
                return false;
            }
            // input is valid
            return true;
        }

        //Checking Valid ISBN -- format ISBN-10
        public static bool IsValidISBN(string isbn)
        {
            // Regex pattern for ISBN-10 validation with hyphens
            string pattern = @"^\d{1,5}-\d{1,7}-\d{1,6}-[\dXx]$";

            return Regex.IsMatch(isbn, pattern);
        }

    }
}
