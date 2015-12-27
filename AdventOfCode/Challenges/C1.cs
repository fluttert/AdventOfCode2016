using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Challenges
{
	class C1 
	{
		public int Part1(string input)
		{
			int output = 0;
			if (string.IsNullOrEmpty(input)) { return output; } // early exit

			// main loop
			foreach (char c in input) {
				if (c == '(') { output++; continue; }
				if (c == ')') { output--; }
			}
			return output;
		}

		public int Part2(string input)
		{
			int level = 0, output = 0;
			if (string.IsNullOrEmpty(input)) { return output; }
			foreach (char c in input)
			{
				output++;
				if (c == '(') { level++; }
				if (c == ')') { level--; }
				if (level < 0) { return output; }
			}
			return -1; // never hits the basement!
		}
	}
}
