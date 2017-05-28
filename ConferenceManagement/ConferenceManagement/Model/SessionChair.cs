using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceManagement.Model
{
    public class SessionChair
    {
        // No idea ce trebuie sa contina aceste clase mai exact :).
        private int id;
        private String tema;
        private String sala;
        private int nrParticipanti;
        public SessionChair(int id, String tema, String sala, int nrParticipanti)
        {
            this.id = id;
            this.tema = tema;
            this.sala = sala;
            this.nrParticipanti = nrParticipanti;
        }

        public int Id { get; set; }

        public string Tema { get; set; }

        public string Sala { get; set; }

        public int NrParticipanti { get; set; }
    }
}
