namespace MonopolySimulation {
	public class Program {
		public static void Main() {
			var simulator = new ConsoleMonopolySimulator();
			simulator.AddPlayer(new Player{Name = "Nicholas"});
			simulator.AddPlayer(new Player{Name = "Dylan"});

			simulator.Run(100);
		}
	}
}