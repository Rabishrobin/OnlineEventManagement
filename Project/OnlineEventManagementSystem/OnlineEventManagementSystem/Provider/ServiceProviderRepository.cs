using System;
using System.Collections.Generic;

namespace OnlineEventManagementSystem
{
    class ServiceProviderRepository : ServiceProviderSignup, IRepository
    {
        protected internal List<ServiceProviderSignup> serviceProviderDatabase = new List<ServiceProviderSignup>();

        public void Repository()
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
                    Console.WriteLine("Creating account");
                    Console.WriteLine("Enter Mail ID");
                    loginMailId = Console.ReadLine();
                    Console.WriteLine("Enter Password");
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
            ServiceProviderSignup signup = new ServiceProviderSignup();
            serviceProviderDatabase.Add(signup);

            signup.serviceProviderMailId = mailId;
            signup.serviceProviderPassword = password;
            Console.WriteLine("Enter your first name");
            signup.serviceProviderFirstName = Input.GetName();
            Console.WriteLine("Enter your last name");
            signup.serviceProviderLastName = Console.ReadLine();
            Console.WriteLine("Enter your mobile number");
            signup.serviceProviderMobileNumber = Input.GetMobileNumber();
            Console.WriteLine("Enter your DOB in DD/MM/YYYY format");
            signup.serviceProviderDOB = Input.GetDOB();
            Console.WriteLine("Enter your gender");
            signup.serviceProviderGender = Input.GetGender();
            Console.WriteLine("Account created succesfully");
            signup.DisplayService();

        }
        public void Login(string mailId, string password)
        {
            foreach (var account in serviceProviderDatabase)
            {
                if (account.serviceProviderMailId.Equals(mailId))
                {
                    ServiceProviderAccount serviceProvider = new ServiceProviderAccount(account);
                    break;
                }
            }
        }
        public bool VerifyMailId(string mailId)
        {
            bool isExist = true;
            foreach (var database in serviceProviderDatabase)
            {
                if (database.serviceProviderMailId.Equals(mailId))
                {
                    return false;
                }
            }
            return isExist;
        }
        public bool ValidateAccount(string mailId, string password)
        {
            bool isMatched = false;
            foreach (var database in serviceProviderDatabase)
            {
                if (database.serviceProviderMailId.Equals(mailId) && database.serviceProviderPassword.Equals(password))
                {
                    isMatched = true;
                    break;
                }
            }
            return isMatched;
        }
    }
}
