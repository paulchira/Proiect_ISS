using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceManagement.Model
{
    public class Speaker : User
    {
  
        private String domeniu;
        private int nrArticole;
        private int nrPremii;

        public Speaker(int ID, String firstName, String lastName,string username, string pass, String domeniu, int nrArticole, int nrPremii) : base(ID,firstName,lastName,username,pass)
        {

            this.domeniu = domeniu;
            this.NrArticole = nrArticole;
            this.NrPremii = nrPremii;
        }

        public string Domeniu { get; set; }

        public int NrArticole { get; set; }

        public int NrPremii { get; set; }

    }
}
