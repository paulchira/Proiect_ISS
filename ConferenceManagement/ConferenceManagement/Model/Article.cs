using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceManagement.Model
{
    [Serializable]
    public class Article
    {
        private int idArticle;
        private string articleTitle;
        private string articleAbstract;
        private string articleText;
        private int sectionId;

        public Article(int idArticle, string articleTitle, string articleAbstract, string articleText, int sectionId)
        {
            this.IdArticle = idArticle;
            this.ArticleTitle = articleTitle;
            this.ArticleAbstract = articleAbstract;
            this.ArticleText = articleText;
            this.SectionId = sectionId;
        }
        public Article()
        {

        }

        public int IdArticle
        {
            get
            {
                return idArticle;
            }

            set
            {
                idArticle = value;
            }
        }

        public string ArticleTitle
        {
            get
            {
                return articleTitle;
            }

            set
            {
                articleTitle = value;
            }
        }

        public string ArticleAbstract
        {
            get
            {
                return articleAbstract;
            }

            set
            {
                articleAbstract = value;
            }
        }

        public string ArticleText
        {
            get
            {
                return articleText;
            }

            set
            {
                articleText = value;
            }
        }

        public int SectionId
        {
            get
            {
                return sectionId;
            }

            set
            {
                sectionId = value;
            }
        }

    }
}
