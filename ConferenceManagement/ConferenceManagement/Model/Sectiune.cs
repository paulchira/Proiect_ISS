using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceManagement.Model
{
    public class Sectiune
    {
        private int id;
        private String tema;
        private String sala;
        private int nrParticipanti;
        public Sectiune(int id, String tema, String sala, int nrParticipanti)
        {
            this.id = id;
            this.tema = tema;
            this.sala = sala;
            this.nrParticipanti = nrParticipanti;
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

        public string Tema
        {
            get
            {
                return tema;
            }

            set
            {
                tema = value;
            }
        }

        public string Sala
        {
            get
            {
                return sala;
            }

            set
            {
                sala = value;
            }
        }

        public int NrParticipanti
        {
            get
            {
                return nrParticipanti;
            }

            set
            {
                nrParticipanti = value;
            }
        }
    }
}
