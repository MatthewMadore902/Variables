using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variables
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Variables");

			// variable :


			// -------------------integer---------------

			int score; // can store whole numbers
			score = 100; // assigned a integer to score


			Console.WriteLine(score); // accessing aid variables
			Console.WriteLine("Score");

			score = score + 100;

			Console.WriteLine(score);

			//----------------------String-------------------

			string name;
			name = "NameNameName"; // setting string variable 
			Console.WriteLine(name);
			name = "NoName";
			Console.WriteLine(name);


			Console.ReadKey(true); // used for seeing key presses before closing 

		}
	}
}
