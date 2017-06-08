



using System;
using System.Collections.Generic;

namespace Gladiator {
	public class Deck {

		private static int cardAmount = 52;

		private static int blackCards = 26;
		private static int redCards = 26;

		private static int totalClubs = 13;
		private static int totalDiamonds = 13;
		private static int totalHearts = 13;
		private static int totalSpades = 13;

		private static int allKings = 4;
		private static int allQueens = 4;
		private static int allJacks = 4;
		private static int all10s = 4;
		private static int all9s = 4;
		private static int all8s = 4;
		private static int all7s = 4;
		private static int all6s = 4;
		private static int all5s = 4;
		private static int all4s = 4;
		private static int all3s = 4;
		private static int all2s = 4;
		private static int allAces = 4;


		protected static Card[] fullDeck { get; set; }
		protected static Card[] royalDeck { get; set; }


		public void shuffle() {
			Random rng = new Random();
		}
/*
		private static Card[] genDeck(Card[] deck) {
			for (int idx = 0; idx < cardAmount; idx++) {
				for (int blacks = 0; blacks < blackCards; blackCards++ ) {
					deck[idx] = new Card( "Black", "King", "Clubs", 13 );


				}
			}
		}


		public Deck() {
			fullDeck = return genDeck(fullDeck);
		}
*/
	}
}



