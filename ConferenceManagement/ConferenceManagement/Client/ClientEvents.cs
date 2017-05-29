using System;


namespace ConferenceManagement.Client
{
    public enum UserEvent
    {
        newArticle, newConference, newAuthor
    };

    public class ClientEvents : System.EventArgs
    {
        private readonly UserEvent userEvent;
        private readonly Object data;

        public ClientEvents(UserEvent userEvent, object data)
        {
            this.userEvent = userEvent;
            this.data = data;
        }

        public UserEvent UserEvent
        {
            get
            {
                return userEvent;
            }
        }

        public object Data
        {
            get
            {
                return data;
            }
        }

    }
}
