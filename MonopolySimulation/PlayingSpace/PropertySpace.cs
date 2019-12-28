namespace MonopolySimulation.PlayingSpace {
	public class PropertySpace : ISpace {
		public PropertySpace(string name) {
			Name = name;
		}
		public string Name { get; }
		public int Price { get; set; }
		public int Rent { get; set; }
	}
}