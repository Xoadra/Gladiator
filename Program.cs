



using System;
using System.Collections.Generic;

namespace Gladiator {
    class Program {

		static void Main(string[] args) {
			Console.Clear();
			Console.WriteLine("Welcome to GLADIATOR - the premier arena battle standard card game!");
			Console.WriteLine("Dare you brave the arena?");
			Console.WriteLine("\n\nSteel yourselves, mighty champions!  Are you ready to take on the challenge?  Y | N");
			Console.WriteLine();

			string exe = Console.ReadLine();
			if ( exe == "Y" || exe == "y" ) { System.Console.WriteLine( "Yay!" ); Setup(); }
			else if (exe == "N" || exe == "n" ) { System.Console.WriteLine( "Boo!  You suck!!!" ); }
		}

		public static void Setup() {
			System.Console.WriteLine( "Welcome to the arena challenge!" );
			System.Console.WriteLine( "\nHow many players?" );
			System.Console.WriteLine( "\nYou may choose up to 4 players maximum." );
			Players();
		}

		public static void Players() {
			string playerTotal = Console.ReadLine();
			if (playerTotal == "1" || playerTotal == "2" || playerTotal == "3" || playerTotal == "4") {
				System.Console.WriteLine("Yay!");
				Heroes(playerTotal);
			}
			else {
				System.Console.WriteLine( "\n\nPlease choose a number between 1 and 4.\n" );
				Players();
			}
		}

		public static void Heroes(string playerTotal) {
			System.Console.WriteLine( "Build method!" );

			System.Console.WriteLine( "Time to choose your hero card!\n" );
			System.Console.WriteLine( "You can choose between a King, Queen, or Jack card of any suit and color, each with its own bonuses." );
			System.Console.WriteLine( "You can also simply choose your hero card at random, if you are brave enough..." );

			System.Console.WriteLine( "\n\nSo... Will you DECLARE or DARE!?" );
			Random heroGen = new Random();
			string declareOrDare = Console.ReadLine();

			do {
				if ( declareOrDare == "DECLARE" ) { Game(); }
				else if ( declareOrDare == "DARE" ) { Game(); }
				else { System.Console.WriteLine( "Invalid choice!  Try again, and in capital letters this time!" ); }
			}
			while ( declareOrDare != null );

		}



		public static void Game() {
			System.Console.WriteLine( "Game method!" );
		}

    }
}


