using ConferenceManagement.Client;
using ConferenceManagement.Model;
using ConferenceManagement.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Controller
{
    [TestClass()]
    public class ControllerTest
    {
        [TestMethod()]
        public static void getConferenceIdFromNameTest()
        {

            BinaryServerFormatterSinkProvider serverProv = new BinaryServerFormatterSinkProvider();
            serverProv.TypeFilterLevel = System.Runtime.Serialization.Formatters.TypeFilterLevel.Full;
            BinaryClientFormatterSinkProvider clientProv = new BinaryClientFormatterSinkProvider();
            IDictionary props = new Hashtable();

            props["port"] = 0;
            TcpChannel channel = new TcpChannel(props, clientProv, serverProv);
            //ChannelServices.RegisterChannel(channel, false);
            IServiceServer server = (IServiceServer)Activator.GetObject(typeof(IServiceServer), "tcp://localhost:55555/Conference");

            ClientController ctrl = new ClientController(server);

            int result = ctrl.getConferenceIdFromName("TOTUL DESPRE STIINTE");
            try
            {
                Assert.AreEqual(result, 1);
                Console.WriteLine("Controller: Test 1 passed");
            }catch(AssertFailedException e)
            {
                Console.WriteLine("Controller: Test 1 failed");
            }
        }

        [TestMethod()]
        public static void validateAccountTest()
        {
            BinaryServerFormatterSinkProvider serverProv = new BinaryServerFormatterSinkProvider();
            serverProv.TypeFilterLevel = System.Runtime.Serialization.Formatters.TypeFilterLevel.Full;
            BinaryClientFormatterSinkProvider clientProv = new BinaryClientFormatterSinkProvider();
            IDictionary props = new Hashtable();

            props["port"] = 0;
            TcpChannel channel = new TcpChannel(props, clientProv, serverProv);
            //ChannelServices.RegisterChannel(channel, false);
            IServiceServer server = (IServiceServer)Activator.GetObject(typeof(IServiceServer), "tcp://localhost:55555/Conference");

            ClientController ctrl = new ClientController(server);

            User user = new User("Caspriac", "Dalia", "dcaspriac", "abc");
            User result = ctrl.validateAccount("dcaspriac", "abc");

            try
            {
                Assert.AreEqual(user.FirstName, result.FirstName);
                Console.WriteLine("Controller: Test 2 passed");
            }
            catch(AssertFailedException e)
            {
                Console.WriteLine("Controller: Test 2 failed");
            }
        }

        public static void addArticleTest()
        {
            BinaryServerFormatterSinkProvider serverProv = new BinaryServerFormatterSinkProvider();
            serverProv.TypeFilterLevel = System.Runtime.Serialization.Formatters.TypeFilterLevel.Full;
            BinaryClientFormatterSinkProvider clientProv = new BinaryClientFormatterSinkProvider();
            IDictionary props = new Hashtable();

            props["port"] = 0;
            TcpChannel channel = new TcpChannel(props, clientProv, serverProv);
            //ChannelServices.RegisterChannel(channel, false);
            IServiceServer server = (IServiceServer)Activator.GetObject(typeof(IServiceServer), "tcp://localhost:55555/Conference");

            ClientController ctrl = new ClientController(server);

            Article article = new Article(-1,"myArticle","this is an article","this is an article","YES",1);
            int noArticles = ctrl.getAllArticles().Count;
            ctrl.addArticle(article);
            try
            {
                int noArticles2 = ctrl.getAllArticles().Count;
                Assert.AreEqual(noArticles2, noArticles + 1);
                Console.WriteLine("Controller: Test 3 passed");

            }
            catch (AssertFailedException e)
            {
                Console.WriteLine("Controller: Test 3 failed");
            }
        }

        public static void getAllConferenceTest()
        {
            BinaryServerFormatterSinkProvider serverProv = new BinaryServerFormatterSinkProvider();
            serverProv.TypeFilterLevel = System.Runtime.Serialization.Formatters.TypeFilterLevel.Full;
            BinaryClientFormatterSinkProvider clientProv = new BinaryClientFormatterSinkProvider();
            IDictionary props = new Hashtable();

            props["port"] = 0;
            TcpChannel channel = new TcpChannel(props, clientProv, serverProv);
            //ChannelServices.RegisterChannel(channel, false);
            IServiceServer server = (IServiceServer)Activator.GetObject(typeof(IServiceServer), "tcp://localhost:55555/Conference");

            ClientController ctrl = new ClientController(server);

            int noConferences = ctrl.getAllConferences().Count;
            try
            {
                Assert.AreEqual(noConferences, 3);
                Console.WriteLine("Controller: Test 4 passed");
            }
            catch (AssertFailedException e)
            {
                Console.WriteLine("Controller: Test 4 failed");
            }
        }



        public void RunAll()
        {
            getConferenceIdFromNameTest();
            validateAccountTest();
            addArticleTest();
            getAllConferenceTest();
        }
    }
}
