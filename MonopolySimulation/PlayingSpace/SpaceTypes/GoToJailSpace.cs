namespace MonopolySimulation.PlayingSpace.SpaceTypes {
	public class GoToJailSpace : EventSpace {
		public GoToJailSpace() : base("Go to Jail") { }

		public override void TriggerEventFor(Player player) {
			player.Location = -1;
		}
	}
}