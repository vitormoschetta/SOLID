using System;
using Ferindo.Contracts;

namespace Ferindo.Payments
{
    public class CreditCard : IPayment
    {
        public void PaymentCreditCard()
        {
            Console.WriteLine("Pagamento efetuado com Cartão de Credito");
        }

        public void PaymentPaypal()
        {
            throw new System.NotImplementedException();
        }

        public void PaymentPicPay()
        {
            throw new System.NotImplementedException();
        }
    }
}