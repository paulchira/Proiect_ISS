using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConferenceManagement.Model;
using System.Data;

namespace ConferenceManagement.Persistance
{
    public class RepositoryAuthor : IRepositoryAuthor
    {
        //ADD AUTHOR IN DB
        public void add(Author entity)
        {
            IDbConnection connection = DatabaseConnection.getConnection();

            using (var comm = connection.CreateCommand())
            {
                comm.CommandText = "insert into Author(firstName, lastName) values(@firstName, @lastName)";
                var paramFirstName = comm.CreateParameter();
                paramFirstName.ParameterName = "@firstName";
                paramFirstName.Value = entity.FirstName;
                comm.Parameters.Add(paramFirstName);

                var paramLastName = comm.CreateParameter();
                paramLastName.ParameterName = "@lastName";
                paramLastName.Value = entity.LastName;
                comm.Parameters.Add(paramLastName);

                var result = comm.ExecuteNonQuery();
                if (result == 0)
                    throw new RepositoryException("Author not added");
            }
        }

        //TODO:
        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        //TODO:
        public Author findOne(int id)
        {
            throw new NotImplementedException();
        }

        /**
         * GET ALL AUTHORS
         * */
        public IEnumerable<Author> getAll()
        {
            IDbConnection connection = DatabaseConnection.getConnection();
            IList<Author> authors = new List<Author>();

            using (var comm = connection.CreateCommand())
            {
                comm.CommandText = "select * from Author"; // or another name of table

                using (var dataR = comm.ExecuteReader())
                {
                    while (dataR.Read())
                    {
                        int id = dataR.GetInt32(0);
                        string firstName = dataR.GetString(1);
                        string lastName = dataR.GetString(2);
                        Author pcmember = new Author(id, firstName, lastName);
                        authors.Add(pcmember);
                    }
                }
            }
            return authors;
        }

        //TODO:
        public void update(Author oldV, Author newV)
        {
            throw new NotImplementedException();
        }
    }
}
