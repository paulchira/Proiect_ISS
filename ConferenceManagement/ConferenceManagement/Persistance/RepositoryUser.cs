using ConferenceManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;


namespace ConferenceManagement.Persistance
{
    public class RepositoryUser : ICrudRepository<User>
    {

        public void add(User u)
        {
            //Not implemented
        }
        //get idUser from Users
        public User validateAccount(String username, String password)
        {
            IDbConnection connection = DatabaseConnection.getConnection();
            using (var comm = connection.CreateCommand())
            {
                comm.CommandText = "select * from Users where username = @username and password = @password";
                var paramUsername = comm.CreateParameter();
                paramUsername.ParameterName = "@username";
                paramUsername.Value = username;
                comm.Parameters.Add(paramUsername);

                var paramPassword = comm.CreateParameter();
                paramPassword.ParameterName = "@password";
                paramPassword.Value = password;
                comm.Parameters.Add(paramPassword);
                using (var result = comm.ExecuteReader())
                {
                    if(result.Read())
                    {
                        int idUser = result.GetInt16(0);
                        string firstName = result.GetString(3);
                        string lastName = result.GetString(4);
                        connection.Close();
                        int idRole = getUserRole(idUser);

                        if (idRole == 1)
                        {
                            return new Author(idUser, firstName, lastName, username, password);
                        }
                        if (idRole == 2)
                        {
                            return new Participant(idUser, firstName, lastName, username, password);
                        }
                        if (idRole == 3)
                        {
                            return new Reviewer(idUser, firstName, lastName, username, password);
                        }
                        if (idRole == 4)
                        {
                            return new PCMember(idUser, firstName, lastName, username, password);
                        }
                    }
                    else
                    {
                        throw new RepositoryException("User not found!");
                    }
                }

            }
            return null;
        }

        /**
         * return User idRole
         * return idRole if idUser exist,otherwise return -1
         * */
        public int getUserRole(int idUser)
        {
            IDbConnection connection = DatabaseConnection.getConnection();
            using (var comm = connection.CreateCommand())
            {
                comm.CommandText = "select idRole from Users_Role where idUser = @idUser";
                var paramIdUser = comm.CreateParameter();
                paramIdUser.ParameterName = "@idUser";
                paramIdUser.Value = idUser;
                comm.Parameters.Add(paramIdUser);

                int idRole = Convert.ToInt16(comm.ExecuteScalar());
                connection.Close();
                if(idRole != 0)
                    return idRole;
            }
            return -1;
        }


        public void add(User entity, int idRole)
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
                    throw new RepositoryException("User not added");

            }
            var cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT MAX(idUser) FROM Users";

            int idUser = Convert.ToInt32(cmd.ExecuteScalar());
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
            throw new NotImplementedException();
        }

        public User findOne(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> getAll()
        {
            throw new NotImplementedException();
        }

        public void update(User oldV, User newV)
        {
            throw new NotImplementedException();
        }

        public void attendToCoference(int idUser, int idConference)
        {
            if((checkAttend(idUser, idConference)))
            {
                throw new Exception("You are already attending the conference!");
            }

            IDbConnection connection = DatabaseConnection.getConnection();

            using (var comm = connection.CreateCommand())
            {
                comm.CommandText = "insert into Participant_Conference(idUser, idConference) values(@iduser,@idconf)";
                var paramUser = comm.CreateParameter();
                paramUser.ParameterName = "@iduser";
                paramUser.Value = idUser;
                comm.Parameters.Add(paramUser);

                var paramConf = comm.CreateParameter();
                paramConf.ParameterName = "@idconf";
                paramConf.Value = idConference;
                comm.Parameters.Add(paramConf);

                var result = comm.ExecuteNonQuery();
                if (result == 0)
                    throw new RepositoryException("Cannot attend to conference");
            }
        }

        public bool checkAttend(int idUser, int idConference)
        {
            IDbConnection connection = DatabaseConnection.getConnection();

            using (var comm = connection.CreateCommand())
            {
                comm.CommandText = "select * from Participant_Conference where idUser=@idUser and idConference=@idConf";
                var paramUser = comm.CreateParameter();
                paramUser.ParameterName = "@iduser";
                paramUser.Value = idUser;
                comm.Parameters.Add(paramUser);

                var paramConf = comm.CreateParameter();
                paramConf.ParameterName = "@idconf";
                paramConf.Value = idConference;
                comm.Parameters.Add(paramConf);

                int count = Convert.ToInt32(comm.ExecuteScalar());
                if (count == 0)
                    return false;
                return true;
            }
        }
    }
}
