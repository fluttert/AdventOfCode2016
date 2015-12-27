using AdventOfCode.Challenges;
using System;
using System.Diagnostics;
using System.IO;

namespace AdventOfCode
{
	/// <summary>
	/// The advent of code challenge
	/// </summary>
	/// <remarks>Might contain voodoo code</remarks>
	/// <author>Ernst Fluttert / Camulos</author>
	internal class Program
	{
		private static void Main(string[] args)
		{
			// diagnostics
			var stopwatch = new Stopwatch(); stopwatch.Start();

			// input file, prevents input clutter
			string input = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + "input.txt");

			// challenge 1 + 2
			var challenge = new C1();
			var output = challenge.Part2(input);

			stopwatch.Stop();
			
			// make sure some output is there with or without debugging :P
			Console.WriteLine($"Calculation took {stopwatch.ElapsedMilliseconds} ms");
			Console.WriteLine($"Answer: {output}");
			Debug.WriteLine($"Calculation took {stopwatch.ElapsedMilliseconds} ms");
			Debug.WriteLine($"Answer: {output}");
		}
	}
}