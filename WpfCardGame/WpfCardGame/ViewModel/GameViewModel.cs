using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfCardGame.Model;

namespace WpfCardGame.ViewModel {
    public class GameViewModel {
        public ObservableCollection<Card> Cards { get; set; }
        public string PlayerName { get; set; }
        public int MoveCount { get; set; }
        public string GameTime { get; set; }
        public bool IsGameCompleted { get; set; }
        public Card FirstSelectedCard { get; set; }
        public Card SecondSelectedCard { get; set; }

        public void FlipCardCommand() {

        }

        public void NewGameCommand() {

        }

        public void SaveStatsCommand() {

        }
    }
}
