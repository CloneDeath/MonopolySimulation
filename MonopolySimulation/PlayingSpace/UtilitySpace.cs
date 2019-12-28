namespace MonopolySimulation.PlayingSpace {
	public class UtilitySpace : ISpace {
		public UtilitySpace(string name) {
			Name = name;
		}
		public string Name { get; }
	}
}