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




// Rebecca laver dem her
        public void FlipCardCommand(Card selectedCard) {
           
            selectedCard.IsFlipped = true;

            if (FirstSelectedCard == null)
            {
                FirstSelectedCard = selectedCard;
            }
            else
            {
                SecondSelectedCard = selectedCard;
                MoveCount++;

                if (FirstSelectedCard.PairKey == SecondSelectedCard.PairKey)
                {
                    FirstSelectedCard.IsMatched = true;
                    SecondSelectedCard.IsMatched = true;
                    ClearSelection();

                }
                else
                {
                    Task.Delay(1000).ContinueWith(_ =>
                    {
                        FirstSelectedCard.IsFlipped = false;
                        SecondSelectedCard.IsFlipped = false;
                        ClearSelection();
                    });
                }

            }
        }

        private void ClearSelection()
        {
            FirstSelectedCard = null;
            SecondSelectedCard = null;
        }


                    
                


                    IsFlipped = True
                Kan ikke trykkes på når True

                IsFlipped = false
                Kan trykkes på

                Når 2 kort er IsFlipped = True
                Initalisér IsMatched;
            Hvis IsMatched =! True
                Break
                    Sæt IsFlipped = False


        }

        public void NewGameCommand() {

        }

        public void SaveStatsCommand() {

        }
    }
}
