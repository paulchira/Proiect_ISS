using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceManagement.Model
{
    public interface iUser
    {
        int ID { get; set; }
        string firstName { get; set; }
        string lastName { get; set; }
        string Username { get; set; }
        string Password { get; set; }
    }
}
