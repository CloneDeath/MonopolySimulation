namespace MonopolySimulation.PlayingSpace.SpaceTypes {
	public class RailroadSpace : ISpace {
		public RailroadSpace(string name) {
			Name = name;
		}
		public string Name { get; }
	}
}