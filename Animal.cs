using System;
using System.ComponentModel;

namespace TestConsole
{
	

	public class Animal

	{

		public string Name { get; set; } = default!;
		public virtual int NumberLegs { get; set; } = default!;
        public Boolean furry { get; set; } = default!;
       

        public Animal()
		{
		}
	}
}

