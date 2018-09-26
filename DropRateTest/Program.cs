using System;

namespace DropRateTest
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int totaldrops = 0;
			int noDrops = 0;
			int commons = 0;
			int uncommons = 0;
			int rares = 0;
			int veryrares = 0;
			int legendaries = 0;

			do
			{
				Random r = new Random();
				totaldrops++;
				// Order is Common, Uncommon, Rare, Very Rare, Legendary //
				double[] rates = new double[] { 41, 28, 17, 10, 4 };
				string[] rateName = new string[] { "Common", "Uncommon", "Rare", "Very Rare", "Legendary" };
				double valueDrop = r.NextDouble() * 100;
				Console.WriteLine("Drop Rates: {0}Common - 41 %{0}Uncommon - 28 %{0}Rare - 17%{0}Very Rare - 10 %{0}Legendary - 4 %", Environment.NewLine);
				Console.WriteLine("");
				Console.WriteLine("Drop Rate Generarted: " + valueDrop);
				Console.WriteLine("");

				if (valueDrop > rates[0])
				{
					Console.WriteLine("No drops");
					noDrops++;
				}
				// Checking if it's a common //
				else if (valueDrop >= rates[0] || valueDrop > rates[1])
				{
					Console.WriteLine("Drop found! It's {0}", rateName[0]);
					commons++;
				}
				// Checking if's an Uncommon //
				else if (valueDrop >= rates[1] || valueDrop > rates[2])
				{
					Console.WriteLine("Drop found! It's {0}", rateName[1]);
					uncommons++;
				}
				// Checking if it's an Rare //
				else if (valueDrop >= rates[2] || valueDrop > rates[3])
				{
					Console.WriteLine("Drop found! It's {0}", rateName[2]);
					rares++;
				}
				// Checking if it's an very Rare //
				else if (valueDrop >= rates[3] || valueDrop > rates[4])
				{
					Console.WriteLine("Drop found! It's {0}", rateName[3]);
					veryrares++;
				}
				// Checking if it's an legendary //
				else if (valueDrop >= rates[4] || valueDrop > 0)
				{
					Console.WriteLine("Drop found! It's {0}", rateName[4]);
					legendaries++;
				}

				Console.WriteLine("");
				Console.WriteLine("------------------------------------------------------------");
				Console.WriteLine("So far you have earned: {0} # of Common: {1}{0} # of Uncommon: {2}{0} # of Rare: {3}{0} # of Very Rare: {4}{0} # of Legendary: {5}{0}# times nothing dropped: {6}{0}", Environment.NewLine, commons, uncommons, rares, veryrares, legendaries, noDrops);
				Console.WriteLine("Total Drops: " + totaldrops);
				Console.WriteLine("------------------------------------------------------------");
				Console.WriteLine("Press Enter to Drop again:");

				Console.ReadLine();
			}
			while (true);
		}
	}
}

//    double[] chances = {1, 0.85, 50, 0.1, 0.05, 0.01, 0.001};
//Random r = new Random();
//double sum = 0;
//double value = r.nextDouble() * 100;
//boolean dropped = false;
//    for (int i = 0; i<chances.length; i++) {
//        if ((value > sum) && (value<sum + chances[i])) {
//            System.out.println("Item with " + chances[i] + " chance is dropped");
//dropped = true;
//            break;
//        }
//        sum += chances[i];
//    }
//    if (dropped == false) {
//        System.out.println("Dropping default item");
//    }
