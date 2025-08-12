using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCardGame.Model.Repositories {
    public class GameResultsRepo : IGameStatsRepo {
        private readonly string _filePath;
        public GameResultsRepo(string filePath) {
            _filePath = filePath;
            
            if(!File.Exists(_filePath)) {
                File.Create(_filePath).Close();
            }
        }

        public void AddGame(GameStats gameStats) {
            try {
                using(StreamWriter sw = new StreamWriter(_filePath, true)) {
                    sw.WriteLine(gameStats.ToString());
                }
            } catch(IOException ex) {
                Console.WriteLine($"Fejl ved at skrive til fil: {ex.Message}");
            }
        }
        
        public List<GameStats> GetTopTenScores() {
            try {
                List<GameStats> gameStats = new();

                using(StreamReader sw = new StreamReader(_filePath)) {
                    string line;
                    while((line = sw.ReadLine()) != null) {
                        var gameStat = GameStats.FromString(line);
                        if(gameStats != null) {
                            gameStats.Add(gameStat);
                        }
                    }
                    return gameStats;
                }
            } catch(IOException ex) {
                Console.WriteLine($"Fejl ved læsning af fil: {ex.Message}");
                return null;
            }
        }

        public GameStats? GetStats(string playerName) {
            try {
                var gameStats = GetTopTenScores();
                return gameStats.FirstOrDefault(p => p.PlayerName == playerName);
            } catch(ArgumentNullException ex) {
                Console.WriteLine($"Spiller blev ikke fundet: {ex.Message}");
                return null;
            }

        }

    }
}
