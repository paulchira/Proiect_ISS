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

        public ServiceServerImpl(RepositoryConference repoConf, RepositoryArticle repoArticle, RepositorySection repoSection, RepositoryUser repoUser,
            RepositoryAuthor repoAuthor, RepositoryPCMember repoPCMember)
        {
            this.repoConf = repoConf;
            this.repoArticle = repoArticle;
            this.repoUser = repoUser;
            this.repoAuthor = repoAuthor;
            this.repoPCMember = repoPCMember;
            this.repoSection = repoSection;
        }

        public List<Conference> getAllConferences()
        {
            return repoConf.getAll().ToList();
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

        public void addArticle(Article article)
        {
            repoArticle.add(article);
        }

        public void addArticleAuthor(int idArticle, int idAuthor)
        {
            //repoArticle.addArticle_Author(idArticle, idAuthor);
        }

        public List<Article> getAllArticles()
        {
            //return repoArticle.getAll().ToList();
            return null;
        }
    }
}
