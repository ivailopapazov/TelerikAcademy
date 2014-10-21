namespace BullsAndCows.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Game
    {
        private ICollection<Guess> guesses;
        private ICollection<Notification> notifications;

        public Game()
        {
            this.guesses = new HashSet<Guess>();
            this.notifications = new HashSet<Notification>();
        }
        
        public int Id { get; set; }

        public GameState GameState { get; set; }

        public string Name { get; set; }

        public string RedNumber { get; set; }

        public string BlueNumber { get; set; }

        public DateTime DateOfCreation { get; set; }

        public string RedPlayerId { get; set; }

        public virtual ApplicationUser RedPlayer { get; set; }

        public string BluePlayerId { get; set; }

        public virtual ApplicationUser BluePlayer { get; set; }

        public virtual ICollection<Guess> Guesses
        {
            get { return guesses; }
            set { guesses = value; }
        }

        public virtual ICollection<Notification> Notifications
        {
            get { return notifications; }
            set { notifications = value; }
        }
    }
}
