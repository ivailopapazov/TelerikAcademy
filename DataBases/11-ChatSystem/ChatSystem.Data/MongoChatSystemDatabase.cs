using ChatSystem.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatSystem.Data
{
    public class MongoChatSystemDatabase
    {
        private MongoDatabase db;

        public MongoChatSystemDatabase(string connectionString)
        {
            MongoClient client = new MongoClient(connectionString);
            MongoServer server = client.GetServer();
            this.db = server.GetDatabase("ChatSystem");
        }

        public void AddNewMessage(string messageText, string username)
        {
            var message = new Message
            {
                Text = messageText,
                User = new User(username),
                Date = DateTime.Now
            };

            MongoCollection<Message> messageCollection = db.GetCollection<Message>("Message");
            messageCollection.Insert<Message>(message);
        }

        public IEnumerable<Message> GetAllMessages()
        {
            MongoCollection<Message> messageCollection = db.GetCollection<Message>("Message");
            var messages = messageCollection.FindAll().ToList();

            return messages;
        }
    }
}
