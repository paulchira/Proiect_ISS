using ConferenceManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceManagement.Persistance
{
    public class RepositoryReview : ICrudRepository<Review>
    {
        public void add(Review entity)
        {
            IDbConnection connection = DatabaseConnection.getConnection();

            using (var comm = connection.CreateCommand())
            {
                comm.CommandText = "insert into Reviewer_Article(idUser, idArticle, comment, calificativ) values(@idU, @idA, @comm, @calif)";
                var paramIDU = comm.CreateParameter();
                paramIDU.ParameterName = "@idU";
                paramIDU.Value = entity.IdUser;
                comm.Parameters.Add(paramIDU);

                var paramIDA = comm.CreateParameter();
                paramIDA.ParameterName = "@idA";
                paramIDA.Value = entity.IdArticle;
                comm.Parameters.Add(paramIDA);

                var paramComm = comm.CreateParameter();
                paramComm.ParameterName = "@comm";
                paramComm.Value = entity.Comment;
                comm.Parameters.Add(paramComm);

                var paramCalif = comm.CreateParameter();
                paramCalif.ParameterName = "@calif";
                paramCalif.Value = entity.Calificativ;
                comm.Parameters.Add(paramCalif);

                var result = comm.ExecuteNonQuery();
                if (result == 0)
                    throw new RepositoryException("Review not added");
            }
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public Review findOne(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Review> getAll()
        {
            throw new NotImplementedException();
        }

        public void update(Review oldV, Review newV)
        {
            throw new NotImplementedException();
        }
    }
}
