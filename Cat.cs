using System;
namespace TestConsole
{
	public class Cat : Animal
	{
       
        private int NumberLegs { get; set; } = 4;
		//not a creepy hairless cat
        private Boolean furry { get; set; } = true;

        public Cat()
		{
		}
	}
}

