namespace MonopolySimulation.PlayingSpace.SpaceTypes {
	public class BlankSpace : ISpace {
		public BlankSpace(string name) {
			Name = name;
		}
		public string Name { get; }
	}
}