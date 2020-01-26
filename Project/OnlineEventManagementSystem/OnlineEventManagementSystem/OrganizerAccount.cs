using System;

namespace OnlineEventManagementSystem
{
    class OrganizerAccount
    {
        public OrganizerAccount(Signup organizer)
        {
            while (true)
            {
                Console.WriteLine("Enter your choice \n1.Display profile \n2.Update profile \n3.Update password \n4.Logout");
                ConsoleKey choiceKey = Console.ReadKey().Key;
                Console.ReadLine();
                if (choiceKey == ConsoleKey.D1)
                {
                    DisplayProfile(organizer);
                }
                else if (choiceKey == ConsoleKey.D2)
                {
                    UpdateProfile(organizer);
                }
                else if (choiceKey == ConsoleKey.D3)
                {
                    UpdatePassword(organizer);
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
        void DisplayProfile(Signup organizerAccount)
        {
            Console.WriteLine("user Profile");
            Console.WriteLine("Mail ID\t: " + organizerAccount.userMailId);
            Console.WriteLine("First Name\t: " + organizerAccount.userFirstName);
            Console.WriteLine("Last Name\t: " + organizerAccount.userLastName);
            Console.WriteLine("Mobile Number\t: " + organizerAccount.userMobileNumber);
            Console.WriteLine("DOB\t: " + organizerAccount.userDOB);
            Console.WriteLine("Gender\t: " + organizerAccount.userGender);
            Console.WriteLine("Role\t: " + organizerAccount.userGender);
        }
        void UpdateProfile(Signup organizerAccount)
        {
            Console.WriteLine("Select the field you want to change");
            Console.WriteLine("1.First name \n2.Last name \n3.Mobile number \n4.DOB \n5.Gender");
            int choice = Input.GetChoice();
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the First name");
                    organizerAccount.userFirstName = Input.GetName();
                    Console.WriteLine("Name updated successfully");
                    break;
                case 2:
                    Console.WriteLine("Enter the Last name");
                    organizerAccount.userLastName = Console.ReadLine();
                    Console.WriteLine("Name updated successfully");
                    break;
                case 3:
                    Console.WriteLine("Enter the Mobile number");
                    organizerAccount.userMobileNumber = Input.GetMobileNumber();
                    Console.WriteLine("Mobile number updated successfully");
                    break;
                case 4:
                    Console.WriteLine("Enter the DOB");
                    organizerAccount.userDOB = Input.GetDOB();
                    Console.WriteLine("DOB updated successfully");
                    break;
                case 5:
                    Console.WriteLine("Enter the Gender");
                    organizerAccount.userGender = Input.GetGender();
                    Console.WriteLine("Gender updated successfully");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;

            }
        }
        void UpdatePassword(Signup organizerAccount)
        {
            Console.WriteLine("Enter the new password");
            string newPassword = Input.GetPassword();
            Console.WriteLine("Re-Enter the password");
            string reenteredPassword = Console.ReadLine();
            if (newPassword.Equals(reenteredPassword))
            {
                organizerAccount.userPassword = newPassword;
                Console.WriteLine("Password updated successfully");
            }
            else
            {
                Console.WriteLine("Password mismatch");
            }
        }
    }
}
