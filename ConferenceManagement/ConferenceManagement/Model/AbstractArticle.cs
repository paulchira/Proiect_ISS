﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceManagement.Model
{
    public class AbstractArticle
    {
        private int id;
        private string title;
        private List<string> keywords;
        private string topics;
        private string author;

        public AbstractArticle()
        {

        }

        public AbstractArticle(int id, string title, List<string> keywords, string topics, string author)
        {
            this.id = id;
            this.title = title;
            this.keywords = keywords;
            this.topics = topics;
            this.author = author;
        }

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

        public string Author
        {
            get
            {
                return author;
            }

            set
            {
                author = value;
            }
        }

        public string ToString()
        {
            return "AbstractArticle{id=" + Id + "title=" + Title + "author=" + Author + "topics="+ Topics +  "}";
        }
    }
}