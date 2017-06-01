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
        IEnumerable<Article> getAllArticles(int idReviewer)
        {
            IDbConnection connection = DatabaseConnection.getConnection();
            IList<Article> articles = new List<Article>();

            using (var comm = connection.CreateCommand())
            { comm.CommandText = "select * from Article where idArticle = (select idArticle from Reviewer_Article where idUser = @idReviewer)";
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

       
    }
}
