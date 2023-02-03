using System;
using System.ComponentModel;

namespace TestConsole
{
	public class Cat : Animal
	{


		public int NumberLegs { get; set; } = 4;


		//not a creepy hairless cat
        public Boolean furry { get; set; } = true;

        public Cat()
		{
		}
	}
}

