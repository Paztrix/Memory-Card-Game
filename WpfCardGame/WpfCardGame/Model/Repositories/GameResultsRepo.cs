using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCardGame.Model.Repositories {
    public class GameResultsRepo {
        private readonly string _filePath;
        public GameResultsRepo(string filePath) {
            _filePath = filePath;
            
            if(!File.Exists(_filePath)) {
                File.Create(_filePath).Close();
            }
        }

        public void AddGame(GameStats result) {
            try {
                using(StreamWriter sw = new StreamWriter(_filePath, true)) {
                    sw.WriteLine(result.ToString());
                }
            } catch(IOException ex) {
                Console.WriteLine($"Fejl ved at skrive til fil: {ex.Message}");
            }
        }
    }
}
