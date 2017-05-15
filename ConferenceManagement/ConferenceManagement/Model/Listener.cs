using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceManagement.Model
{
    class Listener
    {
        private int id;
        private String nume;
        private String prenume;
        private String domeniu;
        private int nrArticole;
        private int nrPremii;

        public Listener(int id, String nume, String prenume, String domeniu, int nrArticole, int nrPremii)
        {
            this.id = id;
            this.nume = nume;
            this.prenume = prenume;
            this.domeniu = domeniu;
            this.NrArticole = nrArticole;
            this.NrPremii = nrPremii;
        }
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Nume
        {
            get
            {
                return nume;
            }

            set
            {
                nume = value;
            }
        }

        public string Domeniu
        {
            get
            {
                return domeniu;
            }

            set
            {
                domeniu = value;
            }
        }

        public int NrArticole
        {
            get
            {
                return nrArticole;
            }

            set
            {
                nrArticole = value;
            }
        }

        public int NrPremii
        {
            get
            {
                return nrPremii;
            }

            set
            {
                nrPremii = value;
            }
        }
    }
}
