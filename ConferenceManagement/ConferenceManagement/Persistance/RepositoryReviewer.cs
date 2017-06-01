using ConferenceManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceManagement.Persistance
{
    public class RepositoryReviewer
    {
        public IEnumerable<Article> getAllArticles(int idReviewer)
        {
            IDbConnection connection = DatabaseConnection.getConnection();
            IList<Article> articles = new List<Article>();

            using (var comm = connection.CreateCommand())
            {
                comm.CommandText = "select * from Article where idArticle in (select idArticle from Reviewer_Article where idUser = @idReviewer and comment ='')";
                var paramIdR = comm.CreateParameter();
                paramIdR.ParameterName = "idReviewer";
                paramIdR.Value = idReviewer;
                comm.Parameters.Add(paramIdR);

           

                using (var dataR = comm.ExecuteReader())
                {
                    while (dataR.Read())
                    {
                        int idArticle = dataR.GetInt16(0);
                        string articleTitle = dataR.GetString(1);
                        string articleAbstract = dataR.GetString(2);
                        string articleText = dataR.GetString(3);
                        string upload = dataR.GetString(4);
                        int sectionId = dataR.GetInt16(5);
                        Article a = new Article(idArticle,articleTitle,articleAbstract,articleText,upload,sectionId);
                        articles.Add(a);
                    }
                }
            }
            return articles;

        }

        public void insertReview(int idUser,int idArticle,string comment, int calificativ) {
            IDbConnection connection = DatabaseConnection.getConnection();
            using (var comm = connection.CreateCommand())
            {
                comm.CommandText = "update Reviewer_Article set comment = @comment, calificativ = @calificativ where idUser = @idUser and idArticle = @idArticle";
                var paramIdU = comm.CreateParameter();
                paramIdU.ParameterName = "@idUser";
                paramIdU.Value = idUser;
                comm.Parameters.Add(paramIdU);

                var paramIdA = comm.CreateParameter();
                paramIdA.ParameterName = "@idArticle";
                paramIdA.Value = idArticle;
                comm.Parameters.Add(paramIdA);

                var paramComm = comm.CreateParameter();
                paramComm.ParameterName = "@comment";
                paramComm.Value = comment;
                comm.Parameters.Add(paramComm);

                var paramCalificativ = comm.CreateParameter();
                paramCalificativ.ParameterName = "@calificativ";
                paramCalificativ.Value = calificativ;
                comm.Parameters.Add(paramCalificativ);

                var result = comm.ExecuteNonQuery();
                if (result == 0)
                    throw new RepositoryException("Review not added");

            }

        }

       
    }
}
