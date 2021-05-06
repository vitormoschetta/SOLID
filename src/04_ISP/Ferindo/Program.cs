using System;
using Ferindo.Payments;

namespace Ferindo
{
    class Program
    {
        static void Main(string[] args)
        {
            new CreditCard().PaymentCreditCard();
            new Picpay().PaymentPicPay();
            new Paypal().PaymentPaypal();

            // A interface 'IPayment' possui contrato para três tipos de pagamento: 
            // CreditCard, Paypal e PicPay. 
            // Na pasta 'Payments' estão as classes que implementam a interface IPayment.
            // Uma dessas classes de fato implementa todos os métodos, todas as formas de pagamento.
            // As demais classes, porém, implementam apenas um dos métodos do contrato.
            // Ferimos o princípio ISP, uma vez que essas classes estão sendo forçadas a implementar
            // métodos que não utilizam.
        }
    }
}
