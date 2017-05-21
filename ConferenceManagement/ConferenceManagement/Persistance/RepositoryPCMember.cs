using ConferenceManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceManagement.Persistance
{
    public class RepositoryPCMember : IRepositoryPCMember
    {
        /* Default constructor */
        public RepositoryPCMember()
        {

        }

        public void add(PCMember entity)
        {
            IDbConnection connection = DatabaseConnection.getConnection();

            using(var comm = connection.CreateCommand())
            {
                comm.CommandText = "insert into PCMembers(firstName, lastName, username, password) values(@firstName, @lastName, @username, @password)";
                var paramFirstName = comm.CreateParameter();
                paramFirstName.ParameterName = "@firstName";
                paramFirstName.Value = entity.FirstName;
                comm.Parameters.Add(paramFirstName);

                var paramLastName = comm.CreateParameter();
                paramLastName.ParameterName = "@lastName";
                paramLastName.Value = entity.LastName;
                comm.Parameters.Add(paramLastName);

                var paramUsername = comm.CreateParameter();
                paramUsername.ParameterName = "@username";
                paramUsername.Value = entity.Username;
                comm.Parameters.Add(paramUsername);

                var paramPassword = comm.CreateParameter();
                paramPassword.ParameterName = "@password";
                paramPassword.Value = entity.Password;
                comm.Parameters.Add(paramPassword);

                var result = comm.ExecuteNonQuery();
                if (result == 0)
                    throw new RepositoryException("PCMember not added");
            }
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public PCMember findOne(int id)
        {
            throw new NotImplementedException();
        }

        /* Get all pc members */
        public IEnumerable<PCMember> getAll()
        {
            IDbConnection connection = DatabaseConnection.getConnection();
            IList<PCMember> pcmembers = new List<PCMember>();

            using(var comm = connection.CreateCommand())
            {
                comm.CommandText = "select * from PCMembers"; // or another name of table

                using(var dataR = comm.ExecuteReader())
                {
                    while (dataR.Read())
                    {
                        int id = dataR.GetInt32(0);
                        string firstName = dataR.GetString(1);
                        string lastName = dataR.GetString(2);
                        string username = dataR.GetString(3);
                        string password = dataR.GetString(4);
                        PCMember pcmember = new PCMember(id, firstName, lastName, username, password);
                        pcmembers.Add(pcmember);
                    }
                }
            }
            return pcmembers; 
        }

        public void update(PCMember oldV, PCMember newV)
        {
            throw new NotImplementedException();
        }
    }
}
