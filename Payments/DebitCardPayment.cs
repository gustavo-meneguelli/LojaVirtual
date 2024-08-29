using LojaVirtual.Interfaces.Entities;
using LojaVirtual.Interfaces.Payment;
using LojaVirtual.Interfaces.Products;

namespace LojaVirtual.Payments
{
    /// <summary>
    /// Representa uma forma de pagamento com o cartão de débito.
    /// </summary>
    /// <remarks>
    /// <see cref="DebitCardPayment"/> implementa a interface <see cref="IPayment"/> que fornece métodos de checagem, pagamento e exibição de nota fiscal.
    /// </remarks>
    internal class DebitCardPayment : IPayment
    {
        private readonly DateTime _paymentDate;
        private readonly IUser _user;
        private readonly IProduct _product;


        /// <summary>
        /// Inicializa uma instância de <see cref="DebitCardPayment"/>.
        /// </summary>
        /// <param name="product">Representa uma instância do produto a ser comprado.</param>
        public DebitCardPayment(IUser user, IProduct product)
        {
            _paymentDate = DateTime.Now;
            _user = user;
            _product = product;
        }

        /// <summary>
        /// Responsável se o usuário possui saldo para realizar a compra.
        /// </summary>
        /// <returns><c>True</c> caso o usuário possuir saldo suficiente, <c>False</c> para o contrário</returns>.
        public bool CheckUserBalance()
            => _user.DebitCardBalance >= _product.Price;
            
        /// <summary>
        /// Responsável por realizar a checagem, fazer o pagamento e exibir a nota fiscal.
        /// </summary>
        public void Pay()
        {
            if (CheckUserBalance())
            {
                ShowInvoice();
                _user.DebitCardBalance -= _product.Price;
            }
            else
                Console.WriteLine("Pagamento não realizado por falta de saldo no cartão.");

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        /// <summary>
        /// Exibe na tela do console a nota fiscal do produto comprado com os detalhes da compra.
        /// </summary>
        public void ShowInvoice()
        {
            Console.Clear();
            Console.WriteLine("---------------------------");
            Console.WriteLine("       NOTA FISCAL         ");
            Console.WriteLine("---------------------------");
            Console.WriteLine(
                $"Forma de Pagamento: Cartão de Débito \n" +
                $"Produto: {_product.Name} \n" +
                $"Tipo do produto: {_product.ProductType} \n" +
                $"Preço do produto R${_product.Price} \n" +
                $"Nome do titular: {_user.Name} \n" +
                $"Data do pagamento: {_paymentDate}");


        }
    }
}
