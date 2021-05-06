using System;
using Ferindo.Contracts;

namespace Ferindo.Payments
{
    public class Paypal : IPayment
    {
        public void PaymentCreditCard()
        {
            throw new System.NotImplementedException();
        }

        public void PaymentPaypal()
        {
            Console.WriteLine("Pagamento efetuado com Paypal");
        }

        public void PaymentPicPay()
        {
            throw new System.NotImplementedException();
        }
    }
}