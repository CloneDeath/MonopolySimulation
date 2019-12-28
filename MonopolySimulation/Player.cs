using MonopolySimulation.PlayingSpace;
using MonopolySimulation.PlayingSpace.SpaceTypes;
using MonopolySimulation.RandomDice;

namespace MonopolySimulation {
	public class Player {
		protected readonly Board Board;

		public Player(Board board) {
			Board = board;
		}
		
		public string Name { get; set; }
		public int Money { get; set; } = 1_500;
		public int Location { get; private set; }

		public virtual void Move(int spaces) {
			Location += spaces;
			if (Location < Board.NumberOfSpaces) return;
			
			Location -= Board.NumberOfSpaces;
			Money += 200;
		}

		public virtual void SetLocation(int location) {
			Location = location;
		}

		protected virtual DicePairResult RollDie() => Board.RollDie();

		public virtual void RunTurn() {
        	var roll = RollDie();
        	Move(roll.Total);
        	ActivateSpace();

        	if (roll.IsDoubles) {
        		RunTurn();
        	}
        }

        private void ActivateSpace() {
        	var space = Board.GetSpace(Location);
        	if (space is EventSpace eventSpace) {
        		eventSpace.TriggerEventFor(this);
        	}
        }
	}
}