using System;

namespace MonopolySimulation.RandomDice {
	public class Dice {
		private static readonly Random _random = new Random();

		public int Roll() {
			return _random.Next(6) + 1;
		}
	}
}