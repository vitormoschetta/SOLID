namespace Ferindo.Contracts
{
    public interface IPayment
    {
        void PaymentCreditCard();
        void PaymentPicPay();
        void PaymentPaypal();
    }
}