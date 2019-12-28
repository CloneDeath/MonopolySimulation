namespace MonopolySimulation.PlayingSpace {
	public class EventSpace : ISpace {
		public EventSpace(string name) {
			Name = name;
		}
		public string Name { get; }
	}
}