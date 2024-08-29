using LojaVirtual.Interfaces.Entities;
using LojaVirtual.Interfaces.Payment;
using LojaVirtual.Interfaces.Products;

namespace LojaVirtual.Payments
{
    internal class CreditCardPayment : IPayment
    {
        private readonly IUser _user;
        private readonly IProduct _product;
        private readonly DateTime _paymentDate;
        public CreditCardPayment(IUser user, IProduct product)
        {
            _paymentDate = DateTime.Now;
            _user = user;
            _product = product;
        }

        public bool CheckUserBalance()
            => _user.CreditCardBalance >= _product.Price;

        public void Pay()
        {
            if (CheckUserBalance())
            {
                ShowInvoice();
                _user.CreditCardBalance -= _product.Price;
            }
            else
                Console.WriteLine("Pagamento não realizado por falta de limite no cartão.");

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        public void ShowInvoice()
        {
            Console.Clear();
            Console.WriteLine("---------------------------");
            Console.WriteLine("       NOTA FISCAL         ");
            Console.WriteLine("---------------------------");
            Console.WriteLine(
                $"Forma de Pagamento: Cartão de Crédito \n" +
                $"Produto: {_product.Name} \n" +
                $"Tipo do produto: {_product.ProductType} \n" +
                $"Preço do produto R${_product.Price} \n" +
                $"Nome do titular: {_user.Name} \n" +
                $"Data do pagamento: {_paymentDate}");
        }
    }
}
