using System;
using System.Collections.Generic;
using System.Linq;
using ConferenceManagement.Model;
using ConferenceManagement.Service;
using ConferenceManagement.Persistance;

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

        public ServiceServerImpl(RepositoryConference repoConf, RepositoryArticle repoArticle, RepositorySection repoSection, RepositoryUser repoUser,
            RepositoryAuthor repoAuthor, RepositoryPCMember repoPCMember, RepositoryReviewer repoReviewer, RepositoryParticipant repoParticipant)
        {
            this.repoConf = repoConf;
            this.repoArticle = repoArticle;
            this.repoUser = repoUser;
            this.repoAuthor = repoAuthor;
            this.repoPCMember = repoPCMember;
            this.repoSection = repoSection;
            this.repoReviewer = repoReviewer;
            this.repoParticipant = repoParticipant;
        }

        public List<Conference> getAllConferences()
        {
            return repoConf.getAll().ToList();
        }

        
        public List<Conference> getAllPlannedConferences()
        {
            return repoConf.getPlannedConferences().ToList();
        }

        public void login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public void logout(string username, string password)
        {
            throw new NotImplementedException();
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
        }

        public void addConference(Conference conf)
        {
            repoConf.add(conf);
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
    }
}
