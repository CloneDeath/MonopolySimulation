namespace MonopolySimulation.RandomDice {
	public class DicePair {
		private readonly Dice _dice = new Dice();

		public DicePairResult Roll() {
			return new DicePairResult(_dice.Roll(), _dice.Roll());
		}
	}
}