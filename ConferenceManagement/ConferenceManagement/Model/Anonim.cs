using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceManagement.Model
{
    public class Anonim
    {
        private int id;

        public Anonim(int id)
        {
            this.Id = id;
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

        public string ToString()
        {
            return "Anonim{id=" + Id + "}";
        }
    }
}
