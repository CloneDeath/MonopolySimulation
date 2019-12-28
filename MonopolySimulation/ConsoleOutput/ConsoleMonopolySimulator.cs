using System;

namespace MonopolySimulation.ConsoleOutput {
	public class ConsoleMonopolySimulator : MonopolySimulator {
		protected override void RunRound(int roundNumber) {
			Console.WriteLine($"Round {roundNumber}:");
			base.RunRound(roundNumber);
			Console.WriteLine();
		}

		protected override Player CreatePlayer(string name) {
			return new ConsolePlayer(Board) {Name = name};
		}
	}
}