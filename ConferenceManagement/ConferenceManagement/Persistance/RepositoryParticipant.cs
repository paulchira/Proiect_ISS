using ConferenceManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceManagement.Persistance
{
    class RepositoryParticipant : ICrudRepository<Participant>
    {
        public RepositoryParticipant() { }


        public void add(Participant entity)
        {
            IDbConnection connection = DatabaseConnection.getConnection();

            using (var comm = connection.CreateCommand())
            {
                comm.CommandText = "insert into Participant(username, password,firstName, lastName) values(@username, @password,@firstName, @lastName)";
                var paramFirstName = comm.CreateParameter();
                paramFirstName.ParameterName = "@firstName";
                paramFirstName.Value = entity.firstName;
                comm.Parameters.Add(paramFirstName);

                var paramLastName = comm.CreateParameter();
                paramLastName.ParameterName = "@lastName";
                paramLastName.Value = entity.lastName;
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
                    throw new RepositoryException("Participant not added");
            }
        }

        public void delete(int id)
        {
            IDbConnection con = DatabaseConnection.getConnection();
            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "delete from Participant where id=@id";
                IDbDataParameter paramId = comm.CreateParameter();
                paramId.ParameterName = "@id";
                paramId.Value = id;
                comm.Parameters.Add(paramId);
                var dataR = comm.ExecuteNonQuery();
                if (dataR == 0)
                    throw new RepositoryException("No participant deleted!");
            }
        }

        public Participant findOne(int id)
        {
            IDbConnection connection = DatabaseConnection.getConnection();
            List<Participant> participants = new List<Participant>();

            using (var comm = connection.CreateCommand())
            {
                comm.CommandText = "select * from Participant where id=@id";
                var param = comm.CreateParameter();
                param.ParameterName = "@id";
                param.Value = id;
                comm.Parameters.Add(param);

                using (var dataR = comm.ExecuteReader())
                {
                    while (dataR.Read())
                    {
                        int ID = dataR.GetInt32(0);
                        string username = dataR.GetString(1);
                        string password = dataR.GetString(2);
                        string firstName = dataR.GetString(3);
                        string lastName = dataR.GetString(4);
                        Participant p = new Participant(ID, username, password, firstName, lastName);
                        return p;
                    }
                }
            }
            return new Participant(0, "", "", "", "");
        }

        public IEnumerable<Participant> getAll()
        {
            IDbConnection connection = DatabaseConnection.getConnection();
            List<Participant> participants = new List<Participant>();

            using (var comm = connection.CreateCommand())
            {
                comm.CommandText = "select * from Participant"; 

                using (var dataR = comm.ExecuteReader())
                {
                    while (dataR.Read())
                    {
                        int id = dataR.GetInt32(0);
                        string username = dataR.GetString(1);
                        string password = dataR.GetString(2);
                        string firstName = dataR.GetString(3);
                        string lastName = dataR.GetString(4);
                        Participant p = new Participant(id,username,password,firstName,lastName);
                        participants.Add(p);
                    }
                }
            }
            return participants;
        }

        public void update(Participant oldV, Participant newV)
        {
            throw new NotImplementedException();
        }
    }
}
