using ConferenceManagement.Client;
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

namespace ConferenceManagementTest.Tests
{
    [TestClass]
    public class ControllerClientTest
    {
        static void Main()
        {
            getConferenceIdFromNameTest();
        }
        [TestMethod]
        public static void getConferenceIdFromNameTest()
        {
            BinaryServerFormatterSinkProvider serverProv = new BinaryServerFormatterSinkProvider();
            serverProv.TypeFilterLevel = System.Runtime.Serialization.Formatters.TypeFilterLevel.Full;
            BinaryClientFormatterSinkProvider clientProv = new BinaryClientFormatterSinkProvider();
            IDictionary props = new Hashtable();

            props["port"] = 0;
            TcpChannel channel = new TcpChannel(props, clientProv, serverProv);
            ChannelServices.RegisterChannel(channel, false);
            IServiceServer server = (IServiceServer)Activator.GetObject(typeof(IServiceServer), "tcp://localhost:55555/Conference");

            ClientController ctrl = new ClientController(server);

            int result = ctrl.getConferenceIdFromName("TOTUL DESPRE STIINTE");

            Assert.AreEqual(result, 1);
        }
    }

}
