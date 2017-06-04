using System;
using System.Collections;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using ConferenceManagement.Persistance;
using ConferenceManagement.Model;
using ConferenceManagement.Model.Tests;
using UnitTests.Controller;

namespace ServerConferenceManagement
{
    class StartServer
    {
        static void Main(string[] args)
        {
            PCMemberTests tests = new PCMemberTests();
            tests.RunAllTests(); // call all tests 

           


            RepositoryConference repoConf = new RepositoryConference();
            //repoConf.add(new Conference("nume1", DateTime.Now, "ed1"));
            //repoConf.add(new Conference("nume2", DateTime.Now, "ed1"));
            //repoConf.add(new Conference("nume3", DateTime.Now, "ed1"));
            RepositoryArticle repoArticle = new RepositoryArticle();
            RepositoryAuthor repoAuthor = new RepositoryAuthor();
            RepositoryPCMember repoPCM = new RepositoryPCMember();
            RepositorySection repoSection = new RepositorySection();
            RepositoryUser repoUser = new RepositoryUser();
            RepositoryReviewer repoReviewer = new RepositoryReviewer();
            RepositoryParticipant repoParticipant = new RepositoryParticipant();
            RepositoryReview repoReview = new RepositoryReview();
            var serviceServer = new ServiceServerImpl(repoConf,repoArticle,repoSection,repoUser,repoAuthor,repoPCM, repoReviewer, repoParticipant,repoReview);
            BinaryServerFormatterSinkProvider serverProv = new BinaryServerFormatterSinkProvider();
            serverProv.TypeFilterLevel = System.Runtime.Serialization.Formatters.TypeFilterLevel.Full;
            BinaryClientFormatterSinkProvider clientProv = new BinaryClientFormatterSinkProvider();
            IDictionary props = new Hashtable();

            props["port"] = 55555;
            TcpChannel channel = new TcpChannel(props, clientProv, serverProv);
            ChannelServices.RegisterChannel(channel, false);

            RemotingServices.Marshal(serviceServer, "Conference");
            //Controller tests
            ControllerTest ctrTest = new ControllerTest();
            //ctrTest.getConferenceIdFromNameTest();
            ctrTest.RunAll();

            Console.WriteLine("Server started ...");
            Console.WriteLine("Press <enter> to exit...");
            Console.ReadLine();

           
        }
    }
}
