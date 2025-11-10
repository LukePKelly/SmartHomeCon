using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeController
{
    public class SmartDevice
    {
        // private fields
        private int userId;
        private string userName;
        private string contactInfo;
        private string password;
        private bool isLoggedIn;

        // public properties
        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        public string ContactInfo
        {
            get { return contactInfo; }
            set { contactInfo = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public bool IsLoggedIn
        {
            get { return isLoggedIn; }
            set { isLoggedIn = value; }
        }

        // Constructor
        public User(int userId,
            string password,
            string userName,
            string contactInfo,
            bool isLoggedIn
            )
        {
            UserId = userId;    
            Password = password;    
            UserName = userName;
            ContactInfo = contactInfo;
            IsLoggedIn = isLoggedIn;
        }

        // Methods - If statement for signing in
        public bool Login(string username, string password)
        {
            if (UserName == username && Password == password)
            {
                IsLoggedIn = true;
                Console.WriteLine("Login successful."); 
            }
            else
            {
                IsLoggedIn = false;
                Console.WriteLine($"Login failed. User {userName} password is incorrect.");
            }
            return IsLoggedIn;
        }

        // Method for signing out
        public bool Logout()
        {
            //If they are logged in then lgo the user out
            if (IsLoggedIn)
            {
                IsLoggedIn = false;
                Console.WriteLine("Logout successful.");
            }
            else           
            {
                Console.WriteLine("User is not logged in.");
            }   
            return IsLoggedIn;
        }

    }
}
