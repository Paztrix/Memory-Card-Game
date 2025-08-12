using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCardGame.Model.Repositories {
    public interface IGameStatsRepo {
        public List<GameStats> GetTopTenScores();
        public GameStats? GetStats(string playerName);
        public void AddGame(GameStats gameStats);
    }
}
