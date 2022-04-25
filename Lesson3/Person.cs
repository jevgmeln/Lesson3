using System;
namespace Lesson3
{
	public class Person
	{

		public Person(string name)
        {

			Name = name;

        }

		public string Name { get; set; }

		public int Age { get; set; }

		public bool IsMale { get; set; }


		public void Greeting()
        {

			Console.WriteLine($"Hello, My name is: {Name} and I am {Age} old");

        }



	}
}

