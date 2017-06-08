



using System;
using System.Collections.Generic;

namespace Gladiator {
    public class Card {

		public string title { get; set; }
		public int stack { get; set;  }

		public string colorCard { get; set; }
		public string typeCard { get; set; }
		public string suitCard { get; set; }

		public bool isHand { get; set; }

		public int power { get; set; }


		public Card(string color, string type, string suit, int level) {

			title = color + " " + type + " of " + suit;
			power = level;

			colorCard = color;
			typeCard = type;
			suitCard = suit;

		}

    }
}



