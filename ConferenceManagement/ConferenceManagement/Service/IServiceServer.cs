using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConferenceManagement.Model;

namespace ConferenceManagement.Service
{
    public interface IServiceServer
    {
        void login(string username, IServiceClient client);

        void logout(string username, IServiceClient client);

        User validateAccount(string username, string password);

        List<Conference> getAllConferences();

        List<Conference> getAllPlannedConferences();

        List<Section> getAllSections();

        void attendToConference(int idUser, int idConference);

        void addConference(Conference conf);

        void addSection(Section section);

        int getConferenceId(string nconferenceName);

        
	    void addArticle(Article article);

        void addArticleAuthor(int idArticle, int idAuthor);

        List<Article> getAllArticles();

        List<Article> getAllArticles(int idReviewer);

        void insertReview(int idUser, int idArticle, string comment, int calificativ);

        List<Int16> getAllArticlesforAuthor(int idAuthor);

        Article findOneArticle(int idArticle);

        void updateArticle(Article oldA, Article newA);

        List<Participant> getAllParticipantsByConference(int idConf);

        void signUpUser(User u,int idRole);

        List<Article> getUnreviewedArticles(int id);

        List<Reviewer> getAvailableReviewers();

        void addReview(Review r);

    }
}
