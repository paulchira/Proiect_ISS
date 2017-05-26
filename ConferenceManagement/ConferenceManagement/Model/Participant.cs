using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceManagement.Model
{
    public class Participant : iUser
    {
        private int id;
        private string password;
        private string username;
        private string fName;
        private string lName;

        public Participant(int id, string username, string password, string fName, string lName)
        {
            this.id = id;
            this.password = password;
            this.username = username;
            this.fName = fName;
            this.lName = lName;
        }

        public void payForConference()
        {
            throw new NotImplementedException();
        }

        public string firstName
        {
            get
            {
                return this.firstName;
            }

            set
            {
                this.fName = value;
            }
        }

        public int ID
        {
            get
            {
                return this.id;
            }

            set
            {
                this.id = value;
            }
        }

        public string lastName
        {
            get
            {
                return this.lName;
            }

            set
            {
                this.lName = value;
            }
        }

        public string Password
        {
            get
            {
                return this.password;
            }

            set
            {
                this.password = value;
            }
        }

        public string Username
        {
            get
            {
                return this.username;
            }

            set
            {
                this.username = value;
            }
        }
    }
}
