/*using System;

namespace Payments
{
	// Tipos genéricos
	class Program {
		static void Main(string[] args)
		{
			var context = new DataContext<Person, Payment, Subscription>();
			var person = new Person("Joao");

			context.Save(person);
		}
	}

	public class DataContext<P, PA, S>
		where P : Person
		where PA : Payment
		where S : Subscription
	{
		public void Save(P entity)
		{

		}
		public void Save(PA entity)
		{

		}
		public void Save(S entity)
		{

		}
	}

	public class Person 
	{
		public string Nome { get; set; }

		public Person(string nome)
		{
			Nome = nome;
		}
	}

	public class Payment {}

	public class Subscription {}


}
*/