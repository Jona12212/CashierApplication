using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAccountNamespace
{
    public class UserAccount
    {
        // Private fields
        private string full_name;
        protected string user_name;
        protected string user_password;

        // Constructor
        public UserAccount(string name, string uName, string password)
        {
            full_name = name;
            user_name = uName;
            user_password = password;
        }

        // Method to validate login
        public virtual bool validateLogin(string uName, string password)
        {
            return (user_name == uName && user_password == password);
        }

        // Method to get full name
        public string getFullName()
        {
            return full_name;
        }
    }

    public class Cashier : UserAccount
    {
        // Private field for department
        private string department;

        // Constructor
        public Cashier(string name, string department, string uName, string password)
            : base(name, uName, password)
        {
            this.department = department;
        }

        // Method to validate login
        public override bool validateLogin(string uName, string password)
        {
            return base.validateLogin(uName, password);
        }

        // Method to get department
        public string getDepartment()
        {
            return department;
        }
    }
}
    
