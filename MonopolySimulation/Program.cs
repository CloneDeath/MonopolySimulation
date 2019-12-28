using MonopolySimulation.PlayingSpace;

namespace MonopolySimulation {
	public class Program {
		public static void Main() {
			var simulator = new MonopolySimulator();
			simulator.AddPlayer();
		}
	}
}