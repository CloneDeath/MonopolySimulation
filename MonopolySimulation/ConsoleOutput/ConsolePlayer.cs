using System;
using MonopolySimulation.PlayingSpace;
using MonopolySimulation.RandomDice;

namespace MonopolySimulation.ConsoleOutput {
	public class ConsolePlayer : Player {
		public ConsolePlayer(Board board) : base(board) { }

		protected override DicePairResult RollDie() {
			var result = base.RollDie();
			Console.WriteLine($"{Name} rolls a {result.Total} ({result.Roll1} and {result.Roll2}).");
			return result;
		}

		public override void Move(int spaces) {
			var start = Location;
			base.Move(spaces);

			var startName = Board.GetSpace(start).Name;
			var endName = Board.GetSpace(Location).Name;
			Console.WriteLine($"{Name} moves {spaces} spaces from {startName} to {endName}.");
		}

		public override void SetLocation(int location) {
			var start = Location;
			base.SetLocation(location);
			
			var startName = Board.GetSpace(start).Name;
			var endName = Board.GetSpace(Location).Name;
			Console.WriteLine($"{Name} jumps from {startName} to {endName}.");
		}
	}
}