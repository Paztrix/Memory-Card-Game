using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCardGame.Model {
    public class Card 
    {
        public string Id { get; set; } //skal det kun være get
        public int PairKey { get; set; } //skal det kun være get

        public Card(string id, string pairKey)
        {
            Id = id;
            PairKey = pairKey;
        }
       
                   
        public bool IsFlipped { get; set; }
        Kan ikke trykkes på når IsFlipped = True;
        Kan trykkes på når IsFlipped = False
        Afventer et andet korts Isflipped = true
            Hvis 2 kort er Isflipped = true,
            1: Tjek om IsMatched
            2: Ellers Break, og sæt IsFlipped til False.





        public bool IsMatched { get; set; }
        first.PairKey == second.PairKey
            Deaktivér de tilhørende ID's
            Tillæg point til spilleren - Samt registrér hvilket PairKey der blev fundet.


    }
}
