﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConferenceManagement.Service;
using ConferenceManagement.Model;

namespace ConferenceManagement.Client
{
    public class ClientController : MarshalByRefObject, IServiceClient
    {
        public event EventHandler<ClientEvents> updateEvent;
        private readonly IServiceServer serviceServer;
        private User user;

        public ClientController(IServiceServer serviceServer)
        {
            this.serviceServer = serviceServer;
            user = null;
        }

        protected virtual void OnUserEvent(ClientEvents e)
        {
            if (updateEvent == null)
                return;
            updateEvent(this, e);
            Console.WriteLine("Update Event called");
        }

        public List<Conference> getAllConferences()
        {
            return serviceServer.getAllConferences();
        }

        public User validateAccount(string username, string password)
        {
            return serviceServer.validateAccount(username, password);
        }

        public List<Section> getAllSections()
        {
            return serviceServer.getAllSections();
        }

        public void attendToConference(int idUser, int idConference)
        {
            serviceServer.attendToConference(idUser, idConference);
        }

        public void addConference(Conference conf)
        {
            serviceServer.addConference(conf);
        }

        public void addSection(Section section)
        {
            serviceServer.addSection(section);
        }

        public int getConferenceIdFromName(string name)
        {
            return serviceServer.getConferenceId(name);
        }
    }
}
