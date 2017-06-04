using System;
using System.Collections.Generic;
using System.Linq;
using ConferenceManagement.Model;
using ConferenceManagement.Service;
using ConferenceManagement.Persistance;
using System.Threading.Tasks;

namespace ServerConferenceManagement
{
    public class ServiceServerImpl : MarshalByRefObject, IServiceServer
    {
        RepositoryConference repoConf;
        RepositoryArticle repoArticle;
        RepositoryUser repoUser;
        RepositoryAuthor repoAuthor;
        RepositoryPCMember repoPCMember;
        RepositorySection repoSection;
        RepositoryReviewer repoReviewer;
        RepositoryParticipant repoParticipant;
        RepositoryReview repoReview;

        private readonly IDictionary<String, IServiceClient> loggedClients;

        public ServiceServerImpl(RepositoryConference repoConf, RepositoryArticle repoArticle, RepositorySection repoSection, RepositoryUser repoUser,
            RepositoryAuthor repoAuthor, RepositoryPCMember repoPCMember, RepositoryReviewer repoReviewer, RepositoryParticipant repoParticipant,RepositoryReview repoReview)
        {
            this.repoConf = repoConf;
            this.repoArticle = repoArticle;
            this.repoUser = repoUser;
            this.repoAuthor = repoAuthor;
            this.repoPCMember = repoPCMember;
            this.repoSection = repoSection;
            this.repoReviewer = repoReviewer;
            this.repoParticipant = repoParticipant;
            this.repoReview = repoReview;

            loggedClients = new Dictionary<String, IServiceClient>();
        }

        

        public List<Conference> getAllConferences()
        {
            return repoConf.getAll().ToList();
        }

        
        public List<Conference> getAllPlannedConferences()
        {
            return repoConf.getPlannedConferences().ToList();
        }

        public void login(string username, IServiceClient client)
        {
            if (loggedClients.ContainsKey(username))
                throw new Exception("User already logged in.");
            else
                loggedClients.Add(username, client);
        }

        public void logout(string username, IServiceClient client)
        {
            loggedClients.Remove(username);
        }

        public User validateAccount(string username, string password)
        {
            return repoUser.validateAccount(username, password);
        }

        public List<Section> getAllSections()
        {
            return repoSection.getAll().ToList();
        }

        public void attendToConference(int idUser, int idConference)
        {
            repoUser.attendToCoference(idUser, idConference);
            notifyAddedParticipant(idConference);
        }

        public void addConference(Conference conf)
        {
            repoConf.add(conf);
            notifyAddedConference(conf);
        }

        public void addSection(Section section)
        {
            repoSection.add(section);
        }

        public int getConferenceId(string conferenceName)
        {
            return repoConf.getId(conferenceName);
	}
        public void addArticle(Article article)
        {
            repoArticle.add(article);
            notifyAddedArticle(article);
        }

        public void addArticleAuthor(int idArticle, int idAuthor)
        {
            repoArticle.addArticle_Author(idArticle, idAuthor);
        }

        public List<Article> getAllArticles()
        {
            return repoArticle.getAll().ToList();
        }

        public List<Article> getAllArticles(int idReviewer)
        {
            return repoReviewer.getAllArticles(idReviewer).ToList();
        }

        public void insertReview(int idUser, int idArticle, string comment, int calificativ)
        {
            repoReviewer.insertReview(idUser, idArticle, comment, calificativ);
        }

        public List<short> getAllArticlesforAuthor(int idAuthor)
        {
            return repoArticle.getAllArticleforAuthor(idAuthor).ToList();
        }

        public Article findOneArticle(int idArticle)
        {
            return repoArticle.findOne(idArticle);
        }

        public void updateArticle(Article oldA, Article newA)
        {
            repoArticle.update(oldA, newA);
        }

        public List<Participant> getAllParticipantsByConference(int idConf)
        {
            return repoParticipant.getAllByConference(idConf);
        }

        public void signUpUser(User u, int idRole)
        {
            repoUser.add(u, idRole);
        }

        public List<Article> getUnreviewedArticles(int id)
        {
            return repoArticle.unreviewedArticles(id).ToList();
        }

        public List<Reviewer> getAvailableReviewers()
        {
            return repoReviewer.getAvailableReviewers().ToList();
        }

        public void addReview(Review r)
        {
            repoReview.add(r);
        }

        private void notifyAddedConference(Conference conference)
        {
            foreach(IServiceClient client in loggedClients.Values)
            {
                Task.Run(() => client.conferenceAdded(conference));
            }
        }

        private void notifyAddedParticipant(int idConf)
        {
            foreach (IServiceClient client in loggedClients.Values)
            {
                Task.Run(() => client.participantAdded(idConf));
            }
        }

        private void notifyAddedArticle(Article article)
        {
            foreach (IServiceClient client in loggedClients.Values)
            {
                Task.Run(() => client.articleAdded(article));
            }
        }

        public List<Review> getAllReviews(int idReviewer,int idArticol)
        {
            return repoReviewer.getAllReviews(idReviewer,idArticol).ToList();
            
        }

        public List<string> getSectionsByConference(int idConf)
        {
            List<Section> sections = repoSection.getAll().ToList();
            List<string> rez = new List<string>();
            foreach (Section s in sections)
                if (s.IdConference == idConf)
                    rez.Add(s.SectionName);
            return rez;
        }
    }
}
