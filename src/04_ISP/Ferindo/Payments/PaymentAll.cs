using System;
using Ferindo.Contracts;

namespace Ferindo.Payments
{
    public class PaymentAll : IPayment
    {
        public void PaymentCreditCard()
        {
            Console.WriteLine("Pagamento efetuado com Cartão de Credito");
        }

        public void PaymentPaypal()
        {
            Console.WriteLine("Pagamento efetuado com Paypal");
        }

        public void PaymentPicPay()
        {
            Console.WriteLine("Pagamento efetuado com PicPay");
        }
    }
}