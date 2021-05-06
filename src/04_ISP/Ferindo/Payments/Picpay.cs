using System;
using Ferindo.Contracts;

namespace Ferindo.Payments
{
    public class Picpay : IPayment
    {
        public void PaymentCreditCard()
        {
            throw new System.NotImplementedException();
        }

        public void PaymentPaypal()
        {
            throw new System.NotImplementedException();
        }

        public void PaymentPicPay()
        {
            Console.WriteLine("Pagamento efetuado com PicPay");
        }
    }
}