/*using System;

namespace Payments
{
	class Program{
		static void Main(string[] args)
		{
			// Tipo de Referência
			// -> Endereço dos dados

			//Upcast
			//Downcast

		}
	}


	// private, protected, internal e public
	public interface IPagamento {
		DateTime Vencimento{get; set;}
		void Pagar(double valor);
	}
	public abstract class Pagamento : IPagamento
	{

		public DateTime Vencimento{get; set;}

		public virtual void Pagar(double valor)
		{
		}
	}
	public class PagamentoCartaoCredito : Pagamento
	{
		public override void Pagar(double valor)
		{
			base.Pagar(valor);
		}
	}
	public class PagamentoBoleto : Pagamento
	{
		public override void Pagar(double valor)
		{
			base.Pagar(valor);
		}
	}
	public class PagamentoApplePay : Pagamento
	{
		public override void Pagar(double valor)
		{
			base.Pagar(valor);
		}
	}


}
*/