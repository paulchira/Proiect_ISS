using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceManagement.Model
{
    [Serializable]
    public class Reviewer : User
    {
        
        public Reviewer(int id, string firstName, string lastName, string username, string pass) : base(id, firstName, lastName, username, pass) { }
        public Reviewer(int id, string firstName, string lastName): base(id,firstName,lastName)
        {
            
        }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }

      
    }
}
