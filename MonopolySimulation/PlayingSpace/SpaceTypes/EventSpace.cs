namespace MonopolySimulation.PlayingSpace.SpaceTypes {
	public class EventSpace : ISpace {
		public EventSpace(string name) {
			Name = name;
		}
		public string Name { get; }

		public virtual void TriggerEventFor(Player player) {
			
		}
	}
}