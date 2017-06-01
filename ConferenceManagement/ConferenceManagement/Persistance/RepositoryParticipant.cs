using ConferenceManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceManagement.Persistance
{
    public class RepositoryParticipant : ICrudRepository<Participant>
    {
        public RepositoryParticipant() { }


        public void add(Participant entity)
        {
            IDbConnection connection = DatabaseConnection.getConnection();

            using (var comm = connection.CreateCommand())
            {
                comm.CommandText = "insert into Users(username,password,firstName, lastName) values(@username,@password,@firstName, @lastName)";
                var paramUsername = comm.CreateParameter();
                paramUsername.ParameterName = "@username";
                paramUsername.Value = entity.Username;
                comm.Parameters.Add(paramUsername);

                var paramPass = comm.CreateParameter();
                paramPass.ParameterName = "@password";
                paramPass.Value = entity.Password;
                comm.Parameters.Add(paramPass);

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
                    throw new RepositoryException("Participant not added");

            }
            var cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT MAX(idUser) FROM Users";

            int idUser = Convert.ToInt32(cmd.ExecuteScalar());

            var cmd2 = connection.CreateCommand();
            cmd.CommandText = "SELECT idRole FROM Roles WHERE roleName='Participant'";

            int idRole = Convert.ToInt32(cmd.ExecuteScalar());


            using (var comm = connection.CreateCommand())
            {
                comm.CommandText = "insert into Users_Role(idUser,idRole) values(@idUser,@idRole)";
                var paramUser = comm.CreateParameter();
                paramUser.ParameterName = "@idUser";
                paramUser.Value = idUser;
                comm.Parameters.Add(paramUser);

                var paramPass = comm.CreateParameter();
                paramPass.ParameterName = "@idRole";
                paramPass.Value = idRole;
                comm.Parameters.Add(paramPass);


                var result = comm.ExecuteNonQuery();
                if (result == 0)
                    throw new RepositoryException("Could not add in relationship table Users_Role");

            }

        }

        public void delete(int id)
        {
            IDbConnection con = DatabaseConnection.getConnection();
            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "delete from Users_Role where idUser=@id and idRole=(select idRole from Roles where roleName='Participant') ";
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
            /*
            IDbConnection connection = DatabaseConnection.getConnection();
            List<Participant> participants = new List<Participant>();

            using (var comm = connection.CreateCommand())
            {
                comm.CommandText = "select * from Users where id=@id";
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
            }*/
            return new Participant(0, "", "", "", "");
            
        }

        public IEnumerable<Participant> getAll()
        {
            IDbConnection connection = DatabaseConnection.getConnection();
            IList<Participant> authors = new List<Participant>();

            using (var comm = connection.CreateCommand())
            {
                comm.CommandText = "select Users.idUser,Users.username,Users.password,Users.firstName,Users.lastName from Users inner join Users_Role on Users.idUser=Users_Role.idUser inner join Roles on Users_Role.idRole=Roles.idRole where Roles.roleName='Participant'"; // or another name of table

                using (var dataR = comm.ExecuteReader())
                {
                    while (dataR.Read())
                    {
                        int id = dataR.GetInt16(0);
                        string username = dataR.GetString(1);
                        string password = dataR.GetString(2);
                        string firstName = dataR.GetString(3);
                        string lastName = dataR.GetString(4);
                        Participant a = new Participant(id, username, password, firstName, lastName);
                        authors.Add(a);
                    }
                }
            }
            return authors;
        }

        public void update(Participant oldV, Participant newV)
        {
            throw new NotImplementedException();
        }

        public List<Participant> getAllByConference(int idConf)
        {
            List<Participant> res = new List<Participant>();
            IDbConnection connection = DatabaseConnection.getConnection();

            using (var comm = connection.CreateCommand())
            {
                comm.CommandText = "select Users.idUser,Users.username,Users.password,Users.firstName,Users.lastName from Users inner join Users_Role on Users.idUser=Users_Role.idUser inner join Roles on Users_Role.idRole=Roles.idRole inner join Participant_Conference on Participant_Conference.idUser=Users.idUser where Roles.roleName='Participant' and  Participant_Conference.idConference=@idConf";
                var paramID = comm.CreateParameter();
                paramID.ParameterName = "@idConf";
                paramID.Value = idConf;
                comm.Parameters.Add(paramID);

                using (var dataR = comm.ExecuteReader())
                {
                    while (dataR.Read())
                    {
                        int id = dataR.GetInt16(0);
                        string username = dataR.GetString(1);
                        string password = dataR.GetString(2);
                        string firstName = dataR.GetString(3);
                        string lastName = dataR.GetString(4);
                        Participant a = new Participant(id, username, password, firstName, lastName);
                        res.Add(a);
                    }
                }
            }
            return res;
        }
    }
}
