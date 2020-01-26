using System;

namespace OnlineEventManagementSystem
{
    class ServiceProviderAccount
    {
        public ServiceProviderAccount(ServiceProviderSignup account)
        {
            ServiceProviderSignup serviceProviderAccount = account;
            while (true)
            {
                Console.WriteLine("Enter your choice \n1.Display profile \n2.Update profile \n3.Logout");
                ConsoleKey choiceKey = Console.ReadKey().Key;
                Console.ReadLine();
                if (choiceKey == ConsoleKey.D1)
                {
                    DisplayProfile(account);
                }
                else if (choiceKey == ConsoleKey.D2)
                {
                    UpdateProfile(serviceProviderAccount);
                }
                else if (choiceKey == ConsoleKey.D3)
                    break;
                else
                    Console.WriteLine("Invalid choice");
            }
        }
        void DisplayProfile(ServiceProviderSignup serviceProviderAccount)
        {
            Console.WriteLine("ServiceProvider Profile");
            Console.WriteLine("Mail ID          : " + serviceProviderAccount.serviceProviderMailId);
            Console.WriteLine("First Name       : " + serviceProviderAccount.serviceProviderFirstName);
            Console.WriteLine("Last Name        : " + serviceProviderAccount.serviceProviderLastName);
            Console.WriteLine("Mobile Number    : " + serviceProviderAccount.serviceProviderMobileNumber);
            Console.WriteLine("DOB              : " + serviceProviderAccount.serviceProviderDOB);
            Console.WriteLine("Gender           : " + serviceProviderAccount.serviceProviderGender);
        }
        void UpdateProfile(ServiceProviderSignup serviceProviderAccount)
        {
            Console.WriteLine("Select the field you want to change");
            Console.WriteLine("1.First name \n2.Last name \n3.Mobile number \n4.DOB \n5.Gender");
            int choice = Input.GetChoice();
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the First name");
                    serviceProviderAccount.serviceProviderFirstName = Input.GetName();
                    Console.WriteLine("Name updated successfully");
                    break;
                case 2:
                    Console.WriteLine("Enter the Last name");
                    serviceProviderAccount.serviceProviderLastName = Console.ReadLine();
                    Console.WriteLine("Name updated successfully");
                    break;
                case 3:
                    Console.WriteLine("Enter the Mobile number");
                    serviceProviderAccount.serviceProviderMobileNumber = Input.GetMobileNumber();
                    Console.WriteLine("Mobile number updated successfully");
                    break;
                case 4:
                    Console.WriteLine("Enter the DOB");
                    serviceProviderAccount.serviceProviderDOB = Input.GetDOB();
                    Console.WriteLine("DOB updated successfully");
                    break;
                case 5:
                    Console.WriteLine("Enter the Gender");
                    serviceProviderAccount.serviceProviderGender = Input.GetGender();
                    Console.WriteLine("Gender updated successfully");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;

            }
        }
        void UpdatePassword(ServiceProviderSignup serviceProviderAccount)
        {
            Console.WriteLine("Enter the new password");
            string newPassword = Input.GetPassword();
            Console.WriteLine("Re-Enter the password");
            string reenteredPassword = Console.ReadLine();
            if (newPassword.Equals(reenteredPassword))
            {
                serviceProviderAccount.serviceProviderPassword = newPassword;
                Console.WriteLine("Password updated successfully");
            }
            else
            {
                Console.WriteLine("Password mismatch");
            }
        }

    }
}
