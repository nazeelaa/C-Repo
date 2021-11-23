using System;

namespace Day13PracticeProgram_UC5
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("   5 variable were pass to check which is greater or you can pass as many you can.");
			Console.WriteLine("--------------------------------------------------------------------------------");

			Console.WriteLine(" Integers : 27, 52, 48, 73, 36");
			MaxCount<int> intValue = new MaxCount<int>(27, 52, 48, 73, 36);
			intValue.Values();
			Console.WriteLine(" Float : 64.2, 28.3, 83.3, 73.4, 93.3");
			MaxCount<float> floatValue = new MaxCount<float>(64.2f, 28.3f, 83.3f, 73.4f, 93.3f);
			floatValue.Values();
			Console.WriteLine(" Char : N, K, S, R, J");
			MaxCount<string> stringValue = new MaxCount<string>("N", "K", "S", "R", "J");
			stringValue.Values();
		}
	}
}