using System;

namespace OnlineEventManagementSystem
{
    class UserAccount
    {
        public UserAccount(Signup account)
        {
            while (true)
            {
                Console.WriteLine("Enter your choice \n1.Display profile \n2.Update profile \n3.Update password \n4.Logout");
                ConsoleKey choiceKey = Console.ReadKey().Key;
                Console.ReadLine();
                if (choiceKey == ConsoleKey.D1)
                {
                    DisplayProfile(account);
                }
                else if (choiceKey == ConsoleKey.D2)
                {
                    UpdateProfile(account);
                }
                else if (choiceKey == ConsoleKey.D3)
                {
                    UpdatePassword(account);
                }
                else if (choiceKey == ConsoleKey.D4)
                {
                    Console.WriteLine("Logout successfull");
                    break;
                }
                else
                    Console.WriteLine("Invalid Choice");
            }
        }
        void DisplayProfile(Signup userAccount)
        {
            Console.WriteLine("user Profile");
            Console.WriteLine("Mail ID          : " + userAccount.userMailId);
            Console.WriteLine("First Name       : " + userAccount.userFirstName);
            Console.WriteLine("Last Name        : " + userAccount.userLastName);
            Console.WriteLine("Mobile Number    : " + userAccount.userMobileNumber);
            Console.WriteLine("DOB              : " + userAccount.userDOB);
            Console.WriteLine("Gender           : " + userAccount.userGender);
        }
        void UpdateProfile(Signup userAccount)
        {
            Console.WriteLine("Select the field you want to change");
            Console.WriteLine("1.First name \n2.Last name \n3.Mobile number \n4.DOB \n5.Gender");
            int choice = Input.GetChoice();
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the First name");
                    userAccount.userFirstName = Input.GetName();
                    Console.WriteLine("Name updated successfully");
                    break;
                case 2:
                    Console.WriteLine("Enter the Last name");
                    userAccount.userLastName = Console.ReadLine();
                    Console.WriteLine("Name updated successfully");
                    break;
                case 3:
                    Console.WriteLine("Enter the Mobile number");
                    userAccount.userMobileNumber = Input.GetMobileNumber();
                    Console.WriteLine("Mobile number updated successfully");
                    break;
                case 4:
                    Console.WriteLine("Enter the DOB");
                    userAccount.userDOB = Input.GetDOB();
                    Console.WriteLine("DOB updated successfully");
                    break;
                case 5:
                    Console.WriteLine("Enter the Gender");
                    userAccount.userGender = Input.GetGender();
                    Console.WriteLine("Gender updated successfully");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;

            }
        }
        void UpdatePassword(Signup userAccount)
        {
            Console.WriteLine("Enter the new password");
            string newPassword = Input.GetPassword();
            Console.WriteLine("Re-Enter the password");
            string reenteredPassword = Console.ReadLine();
            if (newPassword.Equals(reenteredPassword))
            {
                userAccount.userPassword = newPassword;
                Console.WriteLine("Password updated successfully");
            }
            else
            {
                Console.WriteLine("Password mismatch");
            }
        }
    }
}
