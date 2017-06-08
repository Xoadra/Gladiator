



using System;
using System.Collections.Generic;

namespace Gladiator {
    public class Hero {

		public string name { get; set; }
		private static string heroType;
		


		public Hero(string label, string hero) {
			name = label;
			heroType = hero;
		}

    }
}



