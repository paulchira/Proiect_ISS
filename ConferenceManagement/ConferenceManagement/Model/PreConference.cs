using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferenceManagement.Model
{
    public class PreConference
    {
        private List<PCMember> pcMembers;
        private List<Article> articles;
        private List<Reviewer> reviewers;
        private IDictionary<Reviewer, List<Article>> assignments;

        public PreConference(List<PCMember> pcMembers, List<Article> articles, List<Reviewer> reviewers)
        {
            this.pcMembers = pcMembers;
            this.articles = articles;
            this.reviewers = reviewers;
        }

        public void assignArticles()
        {
            throw new NotImplementedException();
        }

        public List<Article> getAcceptedArticles()
        {
            //to implement
            return new List<Article>();
        }
        public List<PCMember> PcMembers
        {
            get
            {
                return pcMembers;
            }

        }

        public List<Article> Articles
        {
            get
            {
                return articles;
            }

        }

        public List<Reviewer> Reviewers
        {
            get
            {
                return reviewers;
            }

        }

        
    }
}
