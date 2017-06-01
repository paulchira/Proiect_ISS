using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceManagement.Model
{
    [Serializable]
    public class Review
    {
        private int idArticle, idUser, calificativ;
        private string comment;

        public Review(int idArticle, int idUser, int calificativ, string comment)
        {
            this.IdArticle = idArticle;
            this.idUser = idUser;
            this.calificativ = calificativ;
            this.comment = comment;
        }
    }
}
