using System;

namespace OnlineEventManagementSystem
{
    class Admin
    {
        private string _adminID
        {
            get
            {
                return "Rabishrobin";
            }
        }
        private string _adminPassword
        {
            get
            {
                return "R@6!shrobin";
            }
        }
        string adminID;
        string adminPassword;
        internal Admin()
        {
            Console.WriteLine("Enter admin ID");
            adminID = Console.ReadLine();
            Console.WriteLine("Enter admin password");
            adminPassword = Console.ReadLine();
            if (adminID.Equals(_adminID) && adminPassword.Equals(_adminPassword))
            {
                AdminChoice();
            }
            else
                Console.WriteLine("Invalid admin ID and password");
        }
        private void AdminChoice()
        {
        GetChoice:
            Console.WriteLine("Enter Your Choice : \n1)View users \n2)Display user details \n3)Exit");
            int choice = Input.GetChoice();
            switch (choice)
            {
                case 1:
                    Displayusers();
                    goto GetChoice;
                case 2:
                    DisplayuserDetails();
                    goto GetChoice;
                case 3:
                    break;
                default:
                    Console.WriteLine("Invaid choice");
                    goto GetChoice;
            }
        }
        private void Displayusers()
        {
            Console.WriteLine("Total number of registered user: ", Repository.userDatabase.Count);
            Console.WriteLine("user List");
            foreach (var database in Repository.userDatabase)
            {
                Console.WriteLine("Your Name :{0} \nYour Mail ID:{1}", database.userFirstName + " " + database.userLastName, database.userMailId);
            }
        }
        private void DisplayuserDetails()
        {
        Search:
            Console.WriteLine("Enter the user name or mail ID to search");
            string keyword = Console.ReadLine();
            bool isFound = false;
            foreach (var database in Repository.userDatabase)
            {
                if (keyword.Equals(database.userFirstName) || keyword.Equals(database.userMailId))
                {
                    Console.WriteLine("ServiceProvider Profile");
                    Console.WriteLine("Mail ID          : " + database.userMailId);
                    Console.WriteLine("First Name       : " + database.userFirstName);
                    Console.WriteLine("Last Name        : " + database.userLastName);
                    Console.WriteLine("Mobile Number    : " + database.userMobileNumber);
                    Console.WriteLine("DOB              : " + database.userDOB);
                    Console.WriteLine("Gender           : " + database.userGender);
                    isFound = true;
                }
            }
            if (!isFound)
            {
                Console.WriteLine("user not found");
                goto Search;
            }
        }
    }
}
