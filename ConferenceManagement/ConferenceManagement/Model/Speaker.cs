using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceManagement.Model
{
    class Speaker
    {
        // No idea ce trebuie sa contina aceste clase mai exact :).

        private int id;
        private String nume;
        private String prenume;
        private String domeniu;
        private int nrArticole;
        private int nrPremii;

        public Speaker(int id, String nume, String prenume, String domeniu, int nrArticole, int nrPremii)
        {
            this.id = id;
            this.nume = nume;
            this.prenume = prenume;
            this.domeniu = domeniu;
            this.NrArticole = nrArticole;
            this.NrPremii = nrPremii;
        }
        public int Id { get; set; }

        public string Nume { get; set; }

        public string Domeniu { get; set; }

        public int NrArticole { get; set; }

        public int NrPremii { get; set; }

    }
}
