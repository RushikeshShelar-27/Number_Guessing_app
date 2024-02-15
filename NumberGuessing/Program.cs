using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessing
{
	public class Program
	{
		static void Main(string[] args)
		{
			Random r = new Random();
			int winNum = r.Next(0, 100);
			bool win = false;
			do
			{
				Console.Write("Guess a number between 0-100: ");
				string s = Console.ReadLine();
				int i = int.Parse(s);
				if(i> winNum)
				{
					Console.WriteLine("Too High! Guess lower..");

				}
				else if(i< winNum)
				{
					Console.WriteLine("Too Low! Guess Higher...");
				}
				else if(i == winNum)
				{
					Console.WriteLine("You Win! Hurray");
					win = true;
				}
				Console.WriteLine();
			}
			while (!win);
			Console.WriteLine("Thank you for playing the Game");
			Console.Write("Press any key to to finish");
			Console.ReadKey(true);
		}
	}
}
