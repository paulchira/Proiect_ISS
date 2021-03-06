﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConferenceManagement.Model;
using System.Data;

namespace ConferenceManagement.Persistance
{
    public class RepositoryAuthor : ICrudRepository<Author>
    {
        //ADD AUTHOR IN DB
        public void add(Author entity)
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
                    throw new RepositoryException("Author not added");

            }
            var cmd = connection.CreateCommand();
            cmd.CommandText = "SELECT MAX(idUser) FROM Users";

            int idUser = Convert.ToInt32(cmd.ExecuteScalar());

            var cmd2 = connection.CreateCommand();
            cmd.CommandText = "SELECT idRole FROM Roles WHERE roleName='Author'";

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

        //TODO:
        public void delete(int id)
        {
            IDbConnection con = DatabaseConnection.getConnection();
            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "delete from Users_Role where idUser=@id and idRole=(select idRole from Roles where roleName='Author') ";
                IDbDataParameter paramId = comm.CreateParameter();
                paramId.ParameterName = "@id";
                paramId.Value = id;
                comm.Parameters.Add(paramId);
                var dataR = comm.ExecuteNonQuery();
                if (dataR == 0)
                    throw new RepositoryException("No author deleted!");
            }
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
                comm.CommandText = "select Users.idUser,Users.username,Users.password,Users.firstName,Users.lastName from Users inner join Users_Role on Users.idUser=Users_Role.idUser inner join Roles on Users_Role.idRole=Roles.idRole where Roles.roleName='Author'"; // or another name of table

                using (var dataR = comm.ExecuteReader())
                {
                    while (dataR.Read())
                    {
                        int id = dataR.GetInt16(0);
                        string username = dataR.GetString(1);
                        string password = dataR.GetString(2);
                        string firstName = dataR.GetString(3);
                        string lastName = dataR.GetString(4);
                        Author a = new Author(id, username, password, firstName, lastName);
                        authors.Add(a);
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
