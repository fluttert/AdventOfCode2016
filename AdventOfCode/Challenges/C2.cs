using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Challenges
{
	class C2
	{
		public int Part1(string[] input) {
			int total = 0;
			foreach (string package in input) {
				if (string.IsNullOrWhiteSpace(package)) { continue; }

				// convert to integers
				int[] sides = Array.ConvertAll(package.Split('x'), a => Int32.Parse(a));
				Array.Sort(sides); // smallest side first

				// smallest*secondsmallest + 2*l*w + 2*w*h + 2*h*l
				total += 3 * sides[0] * sides[1] + 2 * sides[1] * sides[2] + 2 * sides[0] * sides[2];

			}
			return total;
		}

		public int Part2(string[] input) {
			int total = 0;
			foreach (string package in input)
			{
				if (string.IsNullOrWhiteSpace(package)) { continue; }

				// convert to integers
				int[] sides = Array.ConvertAll(package.Split('x'), a => Int32.Parse(a));
				Array.Sort(sides); // smallest side first

				// smallest face + body
				total += 2 * sides[0] + 2 * sides[1] + sides[0] * sides[1] * sides[2];

			}
			return total;
		}
	}
}
