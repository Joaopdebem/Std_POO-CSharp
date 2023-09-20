using System;
using System.Linq;

namespace Payments
{
	// Tipos genéricos
	class Program {
		static void Main(string[] args)
		{
			IEnumerable<Payment> paymentsEnum = new List<Payment>();

			ICollection<string> lista = new List<string>();

			IList<Payment> payments = new List<Payment>();
			payments.Add(new Payment(2));
			payments.Add(new Payment(1));
			payments.Add(new Payment(3));

			foreach( var item in payments){
				Console.WriteLine(item.Id);
			}

			var paidPayments = new List<Payment>();
			paidPayments.AddRange(payments);

			var payment = payments.Where(x => x.Id == 3);


		}
	}

	public class Payment 
	{
		public int Id { get; set; }
		public Payment(int id)
		{
			Id = id;
		}
	}

}
