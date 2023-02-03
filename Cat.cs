using System;
using System.ComponentModel;

namespace TestConsole
{
	public class Cat : Animal
	{

		//override - i.e. change behavior of parent, the parent is virtual
		public override int NumberLegs { get; set; } = 4;

        //new - completely hide the parent and replace behavior
        new public Boolean furry { get; set; } = true;

        public Cat()
		{
		}
	}
}

