using MonopolySimulation.PlayingSpace.SpaceTypes;
using MonopolySimulation.RandomDice;

namespace MonopolySimulation.PlayingSpace {
	public class Board {
		public DicePair Die { get; set; } = new DicePair();
		public Spaces Spaces { get; set; } = new Spaces { 
			new BlankSpace("Go"),
			new PropertySpace("Mediterranean Avenue") {
				Price = 60,
				Rent = 2
			},
			new EventSpace("Community Chest"),
			new PropertySpace("Baltic Avenue"),
			new EventSpace("Income Tax"),
			new RailroadSpace("Reading Railroad"),
			new PropertySpace("Oriental Avenue"),
			new EventSpace("Chance"),
			new PropertySpace("Vermont Avenue"),
			new PropertySpace("Connecticut Avenue"),
			new BlankSpace("Just Visiting"),
			new PropertySpace("St. Charles Place"),
			new UtilitySpace("Electric Company"),
			new PropertySpace("States Avenue"),
			new PropertySpace("Virginia Avenue"),
			new RailroadSpace("Pennsylvania Railroad"),
			new PropertySpace("St. James Place"),
			new EventSpace("Community Chest"),
			new PropertySpace("Tennessee Avenue"),
			new PropertySpace("New York Avenue"),
			new BlankSpace("Free Parking"),
			new PropertySpace("Kentucky Avenue"),
			new EventSpace("Chance"),
			new PropertySpace("Indiana Avenue"),
			new PropertySpace("Illinois Avenue"),
			new RailroadSpace("B. & O. Railroad"),
			new PropertySpace("Atlantic Avenue"),
			new PropertySpace("Ventnor Avenue"),
			new UtilitySpace("Water Works"),
			new PropertySpace("Marvin Gardens"),
			new GoToJailSpace(),
			new PropertySpace("Pacific Avenue"),
			new PropertySpace("North Carolina Avenue"),
			new EventSpace("Community Chest"),
			new PropertySpace("Pennsylvania Avenue"),
			new RailroadSpace("Short Line"),
			new EventSpace("Chance"),
			new PropertySpace("Park Place"),
			new EventSpace("Luxury Tax"),
			new PropertySpace("Boardwalk")
		};
		
		public int NumberOfSpaces => Spaces.Count;

		public ISpace GetSpace(int location) {
			return location == -1 ? new BlankSpace("In Jail") : Spaces[location];
		}

		public DicePairResult RollDie() => Die.Roll();
	}
}