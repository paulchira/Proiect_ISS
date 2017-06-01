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
            this.idArticle = idArticle;
            this.idUser = idUser;
            this.calificativ = calificativ;
            this.comment = comment;
        }

        public Review(int idArticle,int idUser)
        {
            this.idArticle = idArticle;
            this.idUser = idUser;
            this.calificativ = -1;
            this.comment = "";
        }

        
        public int IdArticle
        {
            get
            {
                return idArticle;
            }

            set
            {
                idArticle = value;
            }
        }

        public int IdUser
        {
            get
            {
                return idUser;
            }

            set
            {
                idUser = value;
            }
        }

        public int Calificativ
        {
            get
            {
                return calificativ;
            }

            set
            {
                calificativ = value;
            }
        }

        public string Comment
        {
            get
            {
                return comment;
            }

            set
            {
                comment = value;
            }
        }
    }
}
