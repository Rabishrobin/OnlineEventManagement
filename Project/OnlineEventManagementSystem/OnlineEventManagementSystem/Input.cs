using System;

namespace OnlineEventManagementSystem
{
    public static class Input
    {
        public enum Role
        {
            Customer,
            Organizer
        }
        //public static string GetMailId() { }
        public static string GetPassword()
        {
            string password;
            while (true)
            {
                password = Console.ReadLine();
                if (password.Length < 8)
                {
                    Console.WriteLine("Enter a valid password");
                    continue;
                }
                int validationCount = 0; ;
                foreach (char ch in password)
                {
                    if (ch >= 'A' && ch <= 'Z')
                    {
                        validationCount++;
                        break;
                    }
                }
                if (validationCount == 0)
                {
                    Console.WriteLine("Enter a valid password");
                    continue;
                }
                validationCount = 0;
                foreach (char ch in password)
                {
                    if (ch >= 'a' && ch <= 'z')
                    {
                        validationCount++;
                        break;
                    }
                }
                if (validationCount == 0)
                {
                    Console.WriteLine("Enter a valid password");
                    continue;
                }
                validationCount = 0;
                foreach (char ch in password)
                {
                    if (ch >= '0' && ch <= '9')
                    {
                        validationCount++;
                        break;
                    }
                }
                if (validationCount == 0)
                {
                    Console.WriteLine("Enter a valid password");
                    continue;
                }
                char[] specialCharacters = { '@', '#', '$', '%', '^', '&', '*', '(', ')' };
                if (password.IndexOfAny(specialCharacters) == -1)
                {
                    Console.WriteLine("Enter a valid password");
                    continue;
                }
                break;
            }
            return password;
        }
        public static int GetChoice()
        {
            bool canConvert;
            int choice;
            while (true)
            {
                string input = Console.ReadLine();
                canConvert = int.TryParse(input, out choice);
                if (canConvert)
                {
                    break;
                }
                Console.WriteLine("Incorrect format enter a correct one");
            }
            return choice;
        }
        public static string GetName()
        {
            string firstName;
            while (true)
            {
                firstName = Console.ReadLine();
                if (firstName == null)
                {
                    Console.WriteLine("Enter a valid name");
                    continue;
                }
                if (!(firstName[0] >= 'A') && !(firstName[0] <= 'Z'))
                {
                    Console.WriteLine("First character should be in uppercase");
                    continue;
                }
                if (firstName.Length < 3)
                {
                    Console.WriteLine("Length of the name is too small");
                    continue;
                }
                break;
            }
            return firstName;
        }
        public static long GetMobileNumber()
        {
            bool canConvert;
            long mobileNumber;
            while (true)
            {
                string input = Console.ReadLine();
                canConvert = long.TryParse(input, out mobileNumber);
                if (canConvert)
                {
                    if (mobileNumber.ToString().Length == 10 && mobileNumber > 6000000000)
                        break;
                }
                Console.WriteLine("Enter a valid mobile number");
            }
            return mobileNumber;
        }
        public static string GetDOB()
        {
            bool canConvert;
            DateTime dob;
            while(true)
            {
                string input = Console.ReadLine();
                canConvert = DateTime.TryParse(input, out dob);
                if (canConvert)
                    break;
                Console.WriteLine("Invalid formate");

            }
            return dob.ToString("d");
        }
        public static string GetGender()
        {
            string gender;
            while(true)
            {
                gender = Console.ReadLine();
                if(gender != "Male" && gender != "Female")
                {
                    Console.WriteLine("Enter a valid gender");
                    continue;
                }
                break;
            }
            return gender;
        }
        public static string GetRole()
        {
            string role;
            while(true)
            {
                role = Console.ReadLine();
                if (role.Equals(Convert.ToString(Role.Customer)) || role.Equals(Convert.ToString(Role.Organizer)))
                    break;
                else
                    Console.WriteLine("Enter a valid role");
            }
            return role;
        }
        
    }
}  