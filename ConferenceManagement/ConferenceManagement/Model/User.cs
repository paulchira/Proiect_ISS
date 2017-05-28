using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceManagement.Model
{
    public class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public User(int id, string firstName, string lastName, string username, string pass)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            Username = username;
            Password = pass;
        }
    }
}
