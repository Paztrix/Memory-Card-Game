using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCardGame.Model {
    public class GameStats {
        private string _playerName;
        private int _moves;
        private TimeSpan _gameTime;
        private DateTime _completedAt;

        public string PlayerName {  get; set; }
        public int Moves { get; set; }
        public TimeSpan GameTime { get; set; }
        public DateTime CompletedAt { get; set; }

        public GameStats(string playerName, int moves, TimeSpan gameTime, DateTime completedAt) {
            this._playerName = playerName;
            this._moves = moves;
            this._gameTime = gameTime;
            this._completedAt = completedAt;
        }

        public override string ToString() {
            return string.Join(",", 
                PlayerName, 
                Moves.ToString(), 
                GameTime.ToString("HH:mm:ss"), 
                CompletedAt.ToString("dd:MM:yyyy HH:mm:ss"));
        }

        public static GameStats FromString(string line) {
            var parts = line.Split(',');
            string playerName = parts[0];
            int moves = int.Parse(parts[1]);
            TimeSpan gameTime = TimeSpan.Parse(parts[2]);
            DateTime completedAt = DateTime.Parse(parts[3]);

            return new GameStats(playerName, moves, gameTime, completedAt);
        }
    }
}
