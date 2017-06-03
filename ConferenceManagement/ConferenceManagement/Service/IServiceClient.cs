using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConferenceManagement.Model;

namespace ConferenceManagement.Service
{
    public interface IServiceClient
    {
        void conferenceAdded(Conference conference);
        void articleAdded(Article article);
        void participantAdded(User user);
    }
}
