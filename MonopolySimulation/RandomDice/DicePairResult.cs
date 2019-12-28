namespace MonopolySimulation.RandomDice {
	public class DicePairResult {
		public int Roll1 { get; }
		public int Roll2 { get; }
		
		public DicePairResult(int roll1, int roll2) {
			Roll1 = roll1;
			Roll2 = roll2;
		}

		public int Total => Roll1 + Roll2;
		public bool IsDoubles => Roll1 == Roll2;
	}
}