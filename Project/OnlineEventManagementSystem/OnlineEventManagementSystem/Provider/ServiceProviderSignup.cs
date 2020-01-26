using System;
using System.Collections;
using System.Text;

namespace OnlineEventManagementSystem
{
    class ServiceProviderSignup
    {
        internal string serviceProviderMailId;
        internal string serviceProviderPassword;
        internal string serviceProviderFirstName;
        internal string serviceProviderLastName;
        internal long serviceProviderMobileNumber;
        internal string serviceProviderDOB;
        internal string serviceProviderGender;
        internal Hashtable serivceProviding = new Hashtable();
        public enum Service
        {
            Hall,
            Decoration,
            Food_and_Drink,
            Catering,
            Music,
            DJ,
            Dance,
        };
        public void DisplayService()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (Service service in Enum.GetValues(typeof(Service)))
            {
                stringBuilder.Append(service + "\n");
            }
            Console.WriteLine(stringBuilder.ToString());
        }

        void GetServicetDetails()
        {

        }
    }
}