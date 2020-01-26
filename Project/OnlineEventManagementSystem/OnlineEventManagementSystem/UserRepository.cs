using System;
using System.Collections.Generic;

namespace OnlineEventManagementSystem
{

    class Repository : Signup
    {
        protected internal static List<Signup> userDatabase = new List<Signup>();

        public Repository()
        {
            while (true)
            {
                Console.WriteLine("Enter your choice \n1.Signup \n2.Login \n3.Home");
                ConsoleKey choiceKey = Console.ReadKey().Key;
                Console.ReadLine();
                if (choiceKey == ConsoleKey.D1)
                {
                    string loginMailId;
                    string loginPassword;
                    Console.WriteLine("Enter your Mail ID");
                    loginMailId = Console.ReadLine();
                    Console.WriteLine("Enter your Password");
                    loginPassword = Input.GetPassword();
                    if (VerifyMailId(loginMailId))
                        Signup(loginMailId, loginPassword);
                    else
                        Console.WriteLine("Mail ID already exist");
                }
                else if (choiceKey == ConsoleKey.D2)
                {
                    string loginMailId;
                    string loginPassword;
                    Console.WriteLine("Logging in");
                    Console.WriteLine("Enter Mail ID");
                    loginMailId = Console.ReadLine();
                    Console.WriteLine("Enter Password");
                    loginPassword = Console.ReadLine();
                    if (ValidateAccount(loginMailId, loginPassword))
                    {
                        Console.WriteLine("Logged in successfully");
                        Login(loginMailId, loginPassword);
                    }
                    else
                    {
                        Console.WriteLine("Invalid mail id and password");
                    }
                }
                else if (choiceKey == ConsoleKey.D3)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice");
                }
            }
        }
        public void Signup(string mailId, string password)
        {
            Signup signup = new Signup();
            userDatabase.Add(signup);
            signup.userMailId = mailId;
            signup.userPassword = password;
            Console.WriteLine("Enter your first name");
            signup.userFirstName = Input.GetName();
            Console.WriteLine("Enter your last name");
            signup.userLastName = Console.ReadLine();
            Console.WriteLine("Enter your mobile number");
            signup.userMobileNumber = Input.GetMobileNumber();
            Console.WriteLine("Enter your DOB in DD/MM/YYYY format");
            signup.userDOB = Input.GetDOB();
            Console.WriteLine("Enter your gender");
            signup.userGender = Input.GetGender();
            Console.WriteLine("Enter your role");
            signup.userRole = Input.GetRole();
            Console.WriteLine("Account created succesfully");
    }
        public void Login(string mailId, string password)
        {
            foreach (var account in userDatabase)
            {
                if (account.userMailId.Equals(mailId))
                {
                    if (account.userRole.Equals("Customer"))
                    {
                        UserAccount user = new UserAccount(account);
                    }
                    else if(account.userRole.Equals("Organizer"));
                    {
                        OrganizerAccount organizer = new OrganizerAccount(account);
                    }
                    break;
                }
            }
        }
        public bool VerifyMailId(string mailId)
        {
            bool isExist = true;
            foreach (var user in userDatabase)
            {
                if (user.userMailId.Equals(mailId))
                {
                    return false;
                }
            }
            return isExist;
        }
        public bool ValidateAccount(string mailId, string password)
        {
            bool isMatched = false;
            foreach (var user in userDatabase)
            {
                if (user.userMailId.Equals(mailId) && user.userPassword.Equals(password))
                {
                    isMatched = true;
                    break;
                }
            }
            return isMatched;
        }
    }

}
