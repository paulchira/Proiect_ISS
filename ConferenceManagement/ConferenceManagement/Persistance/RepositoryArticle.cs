using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConferenceManagement.Model;
using System.Data;

namespace ConferenceManagement.Persistance
{
    public class RepositoryArticle : ICrudRepository<Article>
    {
        public RepositoryArticle()
        {

        }
        public void add(Article entity)
        {
            IDbConnection con = DatabaseConnection.getConnection();
            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "insert into Article(articleTitle,articleAbstract,articleText,sectionId) values (@title,@abstract,@text,@sectionid)";

                var paramTitle = comm.CreateParameter();
                paramTitle.ParameterName = "@title";
                paramTitle.Value = entity.ArticleTitle;
                comm.Parameters.Add(paramTitle);

                var paramAbstract = comm.CreateParameter();
                paramAbstract.ParameterName = "@abstract";
                paramAbstract.Value = entity.ArticleAbstract;
                comm.Parameters.Add(paramAbstract);

                var paramText = comm.CreateParameter();
                paramText.ParameterName = "@text";
                paramText.Value = entity.ArticleText;
                comm.Parameters.Add(paramText);

                var paramID = comm.CreateParameter();
                paramID.ParameterName = "@sectionid";
                paramID.Value = entity.SectionId;
                comm.Parameters.Add(paramID);

                var result = comm.ExecuteNonQuery();
                if (result == 0)
                    throw new RepositoryException("Article not added");
            }
        }

        public void delete(int id)
        {
            IDbConnection con = DatabaseConnection.getConnection();
            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "delete from Article where idArticle=@id";
                IDbDataParameter paramId = comm.CreateParameter();
                paramId.ParameterName = "@id";
                paramId.Value = id;
                comm.Parameters.Add(paramId);
                var dataR = comm.ExecuteNonQuery();
                if (dataR == 0)
                    throw new RepositoryException("No article deleted!");
            }
        }

        public Article findOne(int id)
        {
            IDbConnection con = DatabaseConnection.getConnection();
            List<Article> participants = new List<Article>();

            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "select * from Article where idArticle=@id";
                var param = comm.CreateParameter();
                param.ParameterName = "@id";
                param.Value = id;
                comm.Parameters.Add(param);

                using (var dataR = comm.ExecuteReader())
                {
                    while (dataR.Read())
                    {
                        int ID = dataR.GetInt16(0);
                        string articleTitle = dataR.GetString(1);
                        string articleAbstract = dataR.GetString(2);
                        string articleText = dataR.GetString(3);
                        int sectioid = dataR.GetInt16(4);
                        Article art = new Article(ID, articleTitle, articleAbstract, articleText, sectioid);
                        return art;
                    }
                }
            }
            return null;
        }

        public IEnumerable<Article> getAll()
        {
            IDbConnection con = DatabaseConnection.getConnection();
            List<Article> articles = new List<Article>();

            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "select * from Article";

                using (var dataR = comm.ExecuteReader())
                {
                    while (dataR.Read())
                    {
                        int ID = dataR.GetInt16(0);
                        string articleTitle = dataR.GetString(1);
                        string articleAbstract = dataR.GetString(2);
                        string articleText = dataR.GetString(3);
                        int sectioid = dataR.GetInt16(4);
                        Article art = new Article(ID, articleTitle, articleAbstract, articleText, sectioid);
                        articles.Add(art);
                    }
                }
            }
            return articles;
        }

        public void update(Article oldV, Article newV)
        {
            IDbConnection con = DatabaseConnection.getConnection();
            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "Update Article set articleTitle = @title, articleAbstract = @artAbstract, articleText = @text, sectionId = @sectionid where idArticle = @ID";

                var paramTitle = comm.CreateParameter();
                paramTitle.ParameterName = "@title";
                paramTitle.Value = newV.ArticleTitle;
                comm.Parameters.Add(paramTitle);

                var paramAbstract = comm.CreateParameter();
                paramAbstract.ParameterName = "@artAbstract";
                paramAbstract.Value = newV.ArticleAbstract;
                comm.Parameters.Add(paramAbstract);

                var paramText = comm.CreateParameter();
                paramText.ParameterName = "@text";
                paramText.Value = newV.ArticleText;
                comm.Parameters.Add(paramText);

                var paramsecID = comm.CreateParameter();
                paramsecID.ParameterName = "@sectionid";
                paramsecID.Value = newV.SectionId;
                comm.Parameters.Add(paramsecID);

                var paramID = comm.CreateParameter();
                paramID.ParameterName = "@ID";
                paramID.Value = oldV.IdArticle;
                comm.Parameters.Add(paramID);

                var result = comm.ExecuteNonQuery();
                if (result == 0)
                    throw new RepositoryException("Article not updated");
            }
        }
    }
}
