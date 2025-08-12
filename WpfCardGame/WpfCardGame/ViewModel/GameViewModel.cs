using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Numerics;
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

        public GameViewModel() 
        {
            Cards = new ObservableCollection<Card>();
            Cards.Add(new Card("A", "1"));
            Cards.Add(new Card("B", "1"));
            Cards.Add(new Card("C", "2"));
            Cards.Add(new Card("D", "2"));
            Cards.Add(new Card("E", "3"));
            Cards.Add(new Card("F", "3"));
            Cards.Add(new Card("G", "4"));
            Cards.Add(new Card("H", "4"));
            Cards.Add(new Card("I", "5"));
            Cards.Add(new Card("J", "5"));
            Cards.Add(new Card("K", "6"));
            Cards.Add(new Card("L", "6"));
            Cards.Add(new Card("M", "7"));
            Cards.Add(new Card("N", "7"));
            Cards.Add(new Card("O", "8"));
            Cards.Add(new Card("P", "8"));
        }


        public void FlipCardCommand() {

        }

        public void NewGameCommand() 
        {
            //Oprette nye kort med tilfældige symbole
            //Blande kort positions
            //Nulstille counters


        }

        public void SaveStatsCommand() {

        }
    }
}
