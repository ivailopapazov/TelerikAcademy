using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillEmAll.Common
{
    public class GameManager
    {
        private Location currentLocation;

        public Player Player
        {
            get
            {
                return Player.Instance;
            }
        }

        public Location CurrentLocation
        {
            get
            {
                return currentLocation;
            }
        }

        public event EventHandler Render;
        public event EventHandler UserInput;

        public GameManager()
        {
            currentLocation = World.Init();
        }

        public GameState Run()
        {
            GameState gameState = GameState.NewGame;

            while (true)
            {
                // Draw world event
                if (Render != null)
                {
                    this.OnRender();
                }

                // Take action event
                if (UserInput != null)
                {
                    this.OnUserInput();
                }

                if (gameState != GameState.NewGame)
                {
                    return gameState;
                }
            }
        }

        public void ChangeLocation(Location newLocation)
        {
            // TODO: Validation of newLocation (is it reachable)
            this.currentLocation = newLocation;
        }

        public void TryAttack()
        {
            //List<IFighter> enemies = new List<IFighter>(this.CurrentLocation.Characters);
            //foreach (var enemy in this.CurrentLocation.Characters)
            //{
            //    if (enemy.isag)
            //    {
                    
            //    }
            //    enemy.Attack(this.Player);
            //}
        }

        private void OnRender()
        {
            Render(this, new EventArgs());
        }

        private void OnUserInput()
        {
            UserInput(this, new EventArgs());
        }
    }
}
