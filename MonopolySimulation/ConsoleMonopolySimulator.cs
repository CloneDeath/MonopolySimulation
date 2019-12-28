using System;

namespace MonopolySimulation {
	public class ConsoleMonopolySimulator : MonopolySimulator {
		protected override void RunRound(int roundNumber) {
			Console.WriteLine($"Round {roundNumber}");
			base.RunRound(roundNumber);
			Console.WriteLine();
		}

		protected override void MovePlayer(Player player, int spaces) {
			base.MovePlayer(player, spaces);
			Console.WriteLine(player.Name + ": " + Board.Spaces[player.Location].Name);
		}
	}
}