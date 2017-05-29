using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceManagement.Model
{
    [Serializable]
    public class Section
    {
        private int idSection;
        private string sectionName;
        private int idConference;

        public Section(int idSection, string sectionName, int idConference)
        {
            this.idSection = idSection;
            this.sectionName = sectionName;
            this.idConference = idConference;
        }

        public Section(string sectionName)
        {
            this.sectionName = sectionName;
        }

        public Section(string sectionName, int idConference)
        {
            this.sectionName = sectionName;
            this.idConference = idConference;
        }

        public int IdSection
        {
            get
            {
                return idSection;
            }

            set
            {
                idSection = value;
            }
        }

        public string SectionName
        {
            get
            {
                return sectionName;
            }

            set
            {
                sectionName = value;
            }
        }

        public int IdConference
        {
            get
            {
                return idConference;
            }

            set
            {
                idConference = value;
            }
        }
        public override string ToString()
        {
            return "Section = { " + idSection + " " + sectionName + " " + idConference + " }";
        }
    }
}
