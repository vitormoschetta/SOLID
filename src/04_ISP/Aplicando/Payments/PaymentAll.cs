using Aplicando.Contracts;

namespace Aplicando.Payments
{
    public class PaymentAll : IPaypal, IPicPay, ICreditCard
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
            throw new System.NotImplementedException();
        }
    }
}