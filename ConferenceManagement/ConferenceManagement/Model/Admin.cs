using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceManagement.Model
{
    [Serializable]
    public class Admin : User
    {
        public Admin(int id, string firstName, string lastName, string username, string pass) : base(id, firstName, lastName, username, pass) { }
    }
}
