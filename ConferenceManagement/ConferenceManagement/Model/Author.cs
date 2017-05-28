using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceManagement.Model
{
    public class Author : User
    {
        public Author(int id, string firstName, string lastName, string username, string pass) : base(id, firstName, lastName, username, pass) { }
    }
}
