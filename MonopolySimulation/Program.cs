using MonopolySimulation.ConsoleOutput;

namespace MonopolySimulation {
	public class Program {
		public static void Main() {
			var simulator = new ConsoleMonopolySimulator();
			simulator.AddPlayer("Nicholas");
			simulator.AddPlayer("Dylan");

			simulator.Run(100);
		}
	}
}