using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceManagement.Model
{
    public class PCMember
    {
        private int Id { get; set; }
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private string Username { get; set; }
        private string Password { get; set; }

        public PCMember() { }

        public PCMember(int id, string firstName, string lastName, string username, string password)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Username = username;
            this.Password = password;
        }
    }
}
