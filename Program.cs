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
			Console.WriteLine();




			//--------------Float------------------

			// Float = Floating Point 
			float speed;
			float distanceTravelled;
			speed = 100.0f;
			distanceTravelled = 0.0f;
			Console.WriteLine("Speeddometer: " + speed);
			Console.WriteLine("odometer: " + distanceTravelled);

			//---------------Int vs Float--------------------
			int intTest;
			float floatTest2;
			float floatTest3; 

			intTest = 10 / 3;
			floatTest2 = 10 / 3;
			floatTest3 = 10.0f / 3.0f;
			Console.WriteLine(intTest);
			Console.WriteLine(floatTest2);
			Console.WriteLine(floatTest3);


			Console.ReadKey(true); // used for seeing key presses before closing


		}
	}
}
