using ConferenceManagement.Model;
using ConferenceManagement.Persistance;
using ConferenceManagement.View;
using ConferenceManagement.Service;
using System;
using System.Collections;
using System.Windows.Forms;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using Hashtable = System.Collections.Hashtable;
using ConferenceManagement.Client;

namespace ConferenceManagement
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BinaryServerFormatterSinkProvider serverProv = new BinaryServerFormatterSinkProvider();
            serverProv.TypeFilterLevel = System.Runtime.Serialization.Formatters.TypeFilterLevel.Full;
            BinaryClientFormatterSinkProvider clientProv = new BinaryClientFormatterSinkProvider();
            IDictionary props = new Hashtable();

            props["port"] = 0;
            TcpChannel channel = new TcpChannel(props, clientProv, serverProv);
            ChannelServices.RegisterChannel(channel, false);
            IServiceServer server = (IServiceServer)Activator.GetObject(typeof(IServiceServer), "tcp://localhost:55555/Conference");

            ClientController ctrl = new ClientController(server);
            //ParticipantForm win = new ParticipantForm(ctrl);
            LoginForm win = new LoginForm(ctrl);
            Application.Run(win);

        }
    }
}