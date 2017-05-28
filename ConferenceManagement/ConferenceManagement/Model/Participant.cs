using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceManagement.Model
{
    public class Participant : User
    {   
       public Participant(int id, string firstName, string lastName, string username, string pass) : base(id, firstName, lastName, username, pass) { }
       
    }
}
