using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceManagement.Server
{
    public interface IServiceServer
    {
        void login(string username, string password);
        void logout(string username, string password);
    }
}
