/*using System;

namespace Payments
{
	class Program {
		static void Main(string[] args)
		{
			//Upcast
			//Downcast

			var pessoa1 = new Pessoa(1, "Joao Pedro");
			var pessoa2 = new Pessoa(1, "Joao Pedro");
	
			Console.WriteLine(pessoa1.Equals(pessoa2));

		}
	}

	public class Pessoa : IEquatable<Pessoa>
	{
		public Pessoa(int id, string nome)
		{
			Nome = nome;
			Id = id;
		}

		public int Id { get; set; }
		public string Nome { get; set; }

        public bool Equals(Pessoa? pessoa)
        {
            return Id == pessoa.Id;
        }
    }

}
*/