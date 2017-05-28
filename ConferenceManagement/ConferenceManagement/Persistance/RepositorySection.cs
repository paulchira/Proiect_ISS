using System;
using System.Collections.Generic;
using ConferenceManagement.Model;
using System.Data;

namespace ConferenceManagement.Persistance
{
    public class RepositorySection : ICrudRepository<Section>
    {
        public RepositorySection()
        {

        }

        public void add(Section entity)
        {
            IDbConnection con = DatabaseConnection.getConnection();
            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "insert into Section(sectionName,idConference) values (@name,@idConf)";

                var paramName = comm.CreateParameter();
                paramName.ParameterName = "@name";
                paramName.Value = entity.SectionName;
                comm.Parameters.Add(paramName);

                var paramIdConf = comm.CreateParameter();
                paramIdConf.ParameterName = "@idConf";
                paramIdConf.Value = entity.IdConference;
                comm.Parameters.Add(paramIdConf);

                var result = comm.ExecuteNonQuery();
                if (result == 0)
                    throw new RepositoryException("Section not added");
            }
        }

        public void delete(int id)
        {
            IDbConnection con = DatabaseConnection.getConnection();
            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "delete from Section where idSection=@id";
                IDbDataParameter paramId = comm.CreateParameter();
                paramId.ParameterName = "@id";
                paramId.Value = id;
                comm.Parameters.Add(paramId);
                var dataR = comm.ExecuteNonQuery();
                if (dataR == 0)
                    throw new RepositoryException("No section deleted!");
            }
        }

        public Section findOne(int id)
        {
            IDbConnection con = DatabaseConnection.getConnection();

            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "select * from Section where idSection=@id";
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
                        int idS = dataR.GetInt16(2);
                        Section sec = new Section(ID, name, idS);
                        return sec;
                    }
                }
            }
            return null;
        }

        public IEnumerable<Section> getAll()
        {
            IDbConnection con = DatabaseConnection.getConnection();
            List<Section> sections = new List<Section>();

            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "select * from Section";

                using (var dataR = comm.ExecuteReader())
                {
                    while (dataR.Read())
                    {
                        int ID = dataR.GetInt16(0);
                        string name = dataR.GetString(1);
                        int idS = dataR.GetInt16(2);
                        Section sec = new Section(ID, name, idS);
                        sections.Add(sec);
                    }
                }
            }
            return sections;
        }

        public void update(Section oldV, Section newV)
        {
            IDbConnection con = DatabaseConnection.getConnection();
            using (var comm = con.CreateCommand())
            {
                comm.CommandText = "Update Section set sectionName = @name, idConference = @idConf where idSection = @ID";

                var paramName = comm.CreateParameter();
                paramName.ParameterName = "@name";
                paramName.Value = newV.SectionName;
                comm.Parameters.Add(paramName);

                var paramIdConf = comm.CreateParameter();
                paramIdConf.ParameterName = "@idConf";
                paramIdConf.Value = newV.IdConference;
                comm.Parameters.Add(paramIdConf);

                var paramID = comm.CreateParameter();
                paramID.ParameterName = "@ID";
                paramID.Value = oldV.IdSection;
                comm.Parameters.Add(paramID);

                var result = comm.ExecuteNonQuery();
                if (result == 0)
                    throw new RepositoryException("Section not updated");
            }
        }
    }
}
