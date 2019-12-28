using System;

namespace MonopolySimulation {
	public class Program {
		public static void Main() {
			var simulator = new MonopolySimulator();
			simulator.AddPlayer();
			simulator.AddPlayer();

			simulator.Run(1);
			
			Console.WriteLine("Player 1: " + simulator.Board.Spaces[simulator.Players[0].Location].Name);
			Console.WriteLine("Player 2: " + simulator.Board.Spaces[simulator.Players[1].Location].Name);
		}
	}
}