using MonopolySimulation.PlayingSpace;
using MonopolySimulation.RandomDice;

namespace MonopolySimulation {
	public class MonopolySimulator {
		public Board Board { get; set; } = new Board();
		public Players Players { get; set; } = new Players();
		public DicePair Die { get; set; } = new DicePair();

		public void AddPlayer() {
			Players.Add(new Player());
		}

		public void Run(int rounds) {
			foreach (var player in Players) {
				RunTurn(player);
			}
		}

		private void RunTurn(Player player) {
			var roll = Die.Roll();
			player.Location += roll.Total;
			if (player.Location >= Board.NumberOfSpaces) {
				player.Location -= Board.NumberOfSpaces;
				player.Money += 200;
			}

			if (roll.IsDoubles) {
				RunTurn(player);
			}
		}
	}
}