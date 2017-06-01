using System;
using System.Collections.Generic;
using ConferenceManagement.Model;
using System.Data;

namespace ConferenceManagement.Persistance
{
    public class RepositoryConference : ICrudRepository<Conference>
    {
        public RepositoryConference()
        {

        }

        public void add(Conference entity)
        {
            IDbConnection con = DatabaseConnection.getConnection();
            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "insert into Conference(conferenceName,conferenceDate,conferenceEdition) values (@name,@date,@edition)";

                var paramName = comm.CreateParameter();
                paramName.ParameterName = "@name";
                paramName.Value = entity.Name;
                comm.Parameters.Add(paramName);

                var paramDate = comm.CreateParameter();
                paramDate.ParameterName = "@date";
                paramDate.Value = entity.Date;
                comm.Parameters.Add(paramDate);

                var paramEdition = comm.CreateParameter();
                paramEdition.ParameterName = "@edition";
                paramEdition.Value = entity.Edition;
                comm.Parameters.Add(paramEdition);

                var result = comm.ExecuteNonQuery();
                if (result == 0)
                    throw new RepositoryException("Conference not added");
            }
        }

        public void delete(int id)
        {
            IDbConnection con = DatabaseConnection.getConnection();
            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "delete from Conference where idConference=@id";
                IDbDataParameter paramId = comm.CreateParameter();
                paramId.ParameterName = "@id";
                paramId.Value = id;
                comm.Parameters.Add(paramId);
                var dataR = comm.ExecuteNonQuery();
                if (dataR == 0)
                    throw new RepositoryException("No conference deleted!");
            }
        }

        public Conference findOne(int id)
        {
            IDbConnection con = DatabaseConnection.getConnection();

            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "select * from Conference where idConference=@id";
                var param = comm.CreateParameter();
                param.ParameterName = "@id";
                param.Value = id;
                comm.Parameters.Add(param);

                using (var dataR = comm.ExecuteReader())
                {
                    while (dataR.Read())
                    {
                        int ID = dataR.GetInt16(0);
                        string name = dataR.GetString(1);
                        String date = dataR.GetString(2);
                        string edition = dataR.GetString(3);
                        Conference conf = new Conference(ID, name, date, edition);
                        return conf;
                    }
                }
            }
            return null;
        }

        public IEnumerable<Conference> getAll()
        {
            IDbConnection con = DatabaseConnection.getConnection();
            List<Conference> conferences = new List<Conference>();

            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "select * from Conference";

                using (var dataR = comm.ExecuteReader())
                {
                    while (dataR.Read())
                    {
                        int ID = dataR.GetInt16(0);
                        string name = dataR.GetString(1);
                        string date = dataR.GetString(2);
                        string edition = dataR.GetString(3);
                        Conference conf = new Conference(ID, name, date, edition);
                        conferences.Add(conf);
                    }
                }
            }
            return conferences;
        }

        public void update(Conference oldV, Conference newV)
        {
            IDbConnection con = DatabaseConnection.getConnection();
            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "Update Conference set conferenceName = @name, conferenceDate = @date, conferenceEdition = @edition where idConference = @ID";

                var paramName = comm.CreateParameter();
                paramName.ParameterName = "@name";
                paramName.Value = newV.Name;
                comm.Parameters.Add(paramName);

                var paramDate = comm.CreateParameter();
                paramDate.ParameterName = "@date";
                paramDate.Value = newV.Date;
                comm.Parameters.Add(paramDate);

                var paramEdition = comm.CreateParameter();
                paramEdition.ParameterName = "@edition";
                paramEdition.Value = newV.Edition;
                comm.Parameters.Add(paramEdition);

                var paramID = comm.CreateParameter();
                paramID.ParameterName = "@ID";
                paramID.Value = oldV.Id;
                comm.Parameters.Add(paramID);

                var result = comm.ExecuteNonQuery();
                if (result == 0)
                    throw new RepositoryException("Conference not updated");
            }

        }
    }
}
