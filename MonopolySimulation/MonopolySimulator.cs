using MonopolySimulation.PlayingSpace;
using MonopolySimulation.PlayingSpace.SpaceTypes;
using MonopolySimulation.RandomDice;

namespace MonopolySimulation {
	public class MonopolySimulator {
		public Board Board { get; set; } = new Board();
		public Players Players { get; set; } = new Players();
		public DicePair Die { get; set; } = new DicePair();

		public void AddPlayer(Player player) {
			Players.Add(player);
		}

		public void Run(int rounds) {
			for (var round = 0; round < rounds; round++) {
				RunRound(round);
			}
		}

		protected virtual void RunRound(int roundNumber) {
			foreach (var player in Players) {
				RunTurn(player);
			}
		}

		protected virtual void RunTurn(Player player) {
			var roll = Die.Roll();
			MovePlayer(player, roll.Total);
			ActivateSpace(player);

			if (roll.IsDoubles) {
				RunTurn(player);
			}
		}

		private void ActivateSpace(Player player) {
			var space = Board.GetSpace(player.Location);
			if (space is EventSpace eventSpace) {
				eventSpace.TriggerEventFor(player);
			}
		}

		protected virtual void MovePlayer(Player player, int spaces) {
			player.Location += spaces;
			if (player.Location < Board.NumberOfSpaces) return;
			
			player.Location -= Board.NumberOfSpaces;
			player.Money += 200;
		}
	}
}