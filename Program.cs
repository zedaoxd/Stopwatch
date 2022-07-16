using System;
using System.Threading;

namespace Stopwatch
{
	class Program
	{
		private static void Main(string[] args)
		{
			Menu();
		}
		
		private static void Menu()
		{
			Console.Clear();
			Console.WriteLine("S = Seconds => 10s = 10 seconds");			
			Console.WriteLine("M = Minutes => 10m = 10 minutes");
			Console.WriteLine("0 = Exit");
			Console.WriteLine("How long do you want to count?");
			
			var data = Console.ReadLine().ToUpper();
			
			if (data.Length <= 1)
				System.Environment.Exit(0);
			
			var type = data.Substring(data.Length - 1, 1);
			var time = int.Parse(data.Substring(0, data.Length - 1));

			if (type == "S")
				StartStopwatch(time);
			
			if (type == "M")
				StartStopwatch(time * 60);
			
		}
		
		private static void PreStart()
		{
			Sleep1s("Ready...");
			Sleep1s("Set...");
			Sleep1s("Go...");
		}
		
		private static void StartStopwatch(int time)
		{
			PreStart();
			int currentTime = 0;
			
			while (currentTime < time)
			{
				Console.Clear();
				currentTime++;
				Sleep1s((time - currentTime).ToString());
			}
			
			Console.Clear();
			Console.WriteLine("Stopwacth finished!");
			Thread.Sleep(2500);
		}
		
		private static void Sleep1s(string message)
		{
			Console.Clear();
			Console.WriteLine(message);
			Thread.Sleep(1000);
		}
	}
}
