using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCardGame.Model {
    public class Card {
        public int Id { get; set; }
        A1 + B1
        A2 + B2
        A3 + B3
        A4 + B4
        A5 + B5
        A6 + B6
        A7 + B7
        A8 + B8 


        public string PairKey { get; set; }
        1, 2, 3, 4



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
