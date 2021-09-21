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


			//-----------Formulas ( order of execution )-------------------


			//order of execution 
			int lives;
			lives = 3;
			lives = 5;
			lives = 10;
			Console.WriteLine("Lives: " + lives);
			lives = lives - 1;
			Console.WriteLine("Lives: " + lives); // usfull debugging tools

			//----------formula--------------

			//int score; //already declared
			int enemyPoints;
			enemyPoints = 100; // you want to save/store "magic number" into varables

			
			score = 0;
			Console.WriteLine("score: " + score);
			score = score + enemyPoints; // formula
			Console.WriteLine("score: " + score);


			Console.ReadKey(true); // used for seeing key presses before closing


		}
	}
}
