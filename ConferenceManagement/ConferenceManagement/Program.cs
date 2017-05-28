using ConferenceManagement.Model;
using ConferenceManagement.Persistance;
using ConferenceManagement.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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




 /*           RepositoryUser rep = new RepositoryUser();
            User u = rep.validateAccount("dcaspriac", "abc");
            if(u is Participant)
            {
                Console.WriteLine("da");
            }
            if (u is PCMember)
            {
                Console.WriteLine("dada");
            }*/
            Application.Run(new LoginForm());

        }
    }
}