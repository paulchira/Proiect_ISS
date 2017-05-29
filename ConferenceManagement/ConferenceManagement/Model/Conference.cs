using System;

namespace ConferenceManagement.Model
{
    [Serializable]
    public class Conference
    {
        public int Id { set; get; }
        public String Name { set; get; }
        public DateTime Date { set; get; }
        public String Edition { set; get; }

        public Conference(int id, string name, DateTime date, string edition)
        {
            Id = id;
            Name = name;
            Date = date;
            Edition = edition;
        }

        public Conference(string name, DateTime date, string edition)
        {
            Name = name;
            Date = date;
            Edition = edition;
        }
    }
}
