using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceManagement.Model
{
    public class Article
    {
        private int id;
        private string title;
        private List<string> keywords;
        private string topics;
        private List<Autor> authors;
        private string extensionFile;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        public List<string> Keywords
        {
            get
            {
                return keywords;
            }

            set
            {
                keywords = value;
            }
        }

        public string Topics
        {
            get
            {
                return topics;
            }

            set
            {
                topics = value;
            }
        }

        public List<Autor> Authors
        {
            get
            {
                return authors;
            }

            set
            {
                authors = value;
            }
        }

        public string ExtensionFile
        {
            get
            {
                return extensionFile;
            }

            set
            {
                extensionFile = value;
            }
        }

        public Article()
        {

        }
        public Article(int id, string title, List<string> keywords, string topics, List<Autor> authors, string extensionFile)
        {
            this.Id = id;
            this.Title = title;
            this.Keywords = keywords;
            this.Topics = topics;
            this.Authors = authors;
            this.ExtensionFile = extensionFile;
        }

        public string ToString()
        {
            return "Article{id=" + Id + ", title=" + Title + ", topics=" + Topics + "}";
        }
    }
}
