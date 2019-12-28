using MonopolySimulation.PlayingSpace;

namespace MonopolySimulation {
	public class MonopolySimulator {
		public Board Board { get; set; } = new Board();
		public Players Players { get; set; } = new Players();

		protected virtual Player CreatePlayer(string name) => new Player(Board) {Name = name};

		public virtual void AddPlayer(string name) {
			Players.Add(CreatePlayer(name));
		}

		public void Run(int rounds) {
			for (var round = 0; round < rounds; round++) {
				RunRound(round);
			}
		}

		protected virtual void RunRound(int roundNumber) {
			foreach (var player in Players) {
				player.RunTurn();
			}
		}
	}
}