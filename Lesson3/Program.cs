// See https://aka.ms/new-console-template for more information
using Lesson3;


string myName = "Oskars" ;
Person person = new Person(myName);

//person.Name = "Jevgenijs";
person.Age = 33;
person.IsMale = true;

person.Greeting();


Console.WriteLine("========================");


Person jeff = new("FSFDF");

//jeff.Name = "Andris";
jeff.Age = 18;

jeff.Greeting();

