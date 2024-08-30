using LojaVirtual.Enums;
using LojaVirtual.Factory;
using LojaVirtual.Interfaces.Entities;
using LojaVirtual.Interfaces.Menus;
using LojaVirtual.Interfaces.Payment;
using LojaVirtual.Interfaces.Products;

namespace LojaVirtual.Menus
{
    /// <summary>
    /// Representa o menu de pagamentos.
    /// </summary>
    internal class PaymentMenu : IMenu
    {
        private readonly IUser _user;
        private readonly IMenuHelper _menuHelper;
        private readonly IProduct _product;

        /// <summary>
        /// Cria uma instância da classe <see cref="PaymentMenu"/>.
        /// </summary>
        /// <param name="user">Uma instância que fornece o usuário que estará logado no sistema. Deve implementar de <see cref="IUser"/>.</param>
        /// <param name="menuHelper">Uma instância que fornece métodos auxiliares para renderização e validação de menus. Deve implementar <see cref="IMenuHelper"/>.</param>
        /// <param name="product"> Uma instância que fornece o produto a ser comprado. Deve implementar <see cref="IProduct"/>.</param>
        public PaymentMenu(IUser user, IMenuHelper menuHelper, IProduct product)
        {
            _user = user;
            _menuHelper = menuHelper;
            _product = product;
        }

        /// <summary>
        /// Obtém as opções disponíveis no menu principal.
        /// </summary>
        /// <returns>
        /// Uma lista de opções do menu principal que são exibidas para o usuário.
        /// </returns>
        private List<string> GetMenuOptions()
            => new List<string> { "Cartão de Débito", "Cartão de Crédito " };

        /// <summary>
        /// Exibe o menu no console e recebe o valor digitado pelo usuário.
        /// </summary>
        /// <returns>
        /// Um número inteiro que representa a seleção do usuário, dentro das opções disponíveis no menu.
        /// </returns>
        private int GetUserSelection()
        {
            int selectionOption;
            var menuOptions = GetMenuOptions();

            while (true)
            {
                Console.Clear();
                _user.ShowDetails();
                _menuHelper.Render(
                    $"Menu de Pagamento: {_product.Name}\n" +
                    $"Preço {_product.Price}", 
                    menuOptions);
                selectionOption = _menuHelper.GetUserInput();

                if (_menuHelper.InputValidate(selectionOption, menuOptions.Count))
                    break;
            }
            return selectionOption;
        }

        /// <summary>
        /// Inicia o processo de exibição e obtem a escolha do usuário referente ao método de pagamento.
        /// </summary>
        /// <remarks>
        /// Esse método lida com a exibição, seleção e validação do usuário referente ao menu de pagamento.
        /// Em caso de erro, uma mensagem genérica será exibida no console.
        /// </remarks>
        public void Start()
        {
            try
            {
                int selectOption = GetUserSelection();

                if (selectOption == 0) //Voltar ao menu principal
                    return;

                EPaymentType paymentType = (EPaymentType)selectOption;
                IPayment payment = PaymentFactory.CreatePayment(paymentType, _user, _product);
                payment.Pay();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro ao tentar inicializar as opções do menu de pagamento: {ex.Message}");
                Console.ReadKey();
            }
            
        }
    }
}
