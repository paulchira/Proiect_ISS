﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConferenceManagement.Model;

namespace ConferenceManagement.Service
{
    public interface IServiceServer
    {
        void login(string username, string password);

        void logout(string username, string password);

        User validateAccount(string username, string password);

        List<Conference> getAllConferences();

        List<Section> getAllSections();

        void attendToConference(int idUser, int idConference);

        void addArticle(Article article);

        void addArticleAuthor(int idArticle, int idAuthor);

        List<Article> getAllArticles();

        List<Int16> getAllArticlesforAuthor(int idAuthor);

        Article findOneArticle(int idArticle);

        void updateArticle(Article oldA, Article newA);
    }
}
