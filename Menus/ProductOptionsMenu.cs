using LojaVirtual.Interfaces.Factory;
using LojaVirtual.Interfaces.Menus;
using LojaVirtual.Interfaces.Products;

namespace LojaVirtual.Menus
{
    /// <summary>
    /// Representa o menu de opções de produtos, permitindo ao usuário exibir detalhes ou realizar a compra do produto.
    /// </summary>
    /// <remarks>
    /// A classe <see cref="ProductOptionsMenu"/> implementa a interface <see cref="IMenu"/> e fornece a funcionalidade de exibir opções para 
    /// o usuário interagir com um produto específico. Ela utiliza uma fábrica de menus e um auxiliar de menus para facilitar a renderização 
    /// e validação das entradas do usuário.
    /// </remarks>
    internal class ProductOptionsMenu : IMenu
    {
        private readonly IMenuFactory _menuFactory;
        private readonly IMenuHelper _menuHelper;
        private readonly IProduct _product;

        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="ProductOptionsMenu"/>.
        /// </summary>
        /// <param name="menuHelper">Uma instância que fornece métodos auxiliares para renderização e validação de menus. Deve implementar <see cref="IMenuHelper"/>.</param>
        /// <param name="menuFactory">Uma instância que é responsável pela criação de menus. Deve implementar <see cref="IMenuFactory"/>.</param>
        /// <param name="product">Uma instância do produto cujas opções são exibidas no menu. Deve implementar <see cref="IProduct"/>.</param>
        public ProductOptionsMenu(IMenuHelper menuHelper, IMenuFactory menuFactory, IProduct product)
        {
            _menuHelper = menuHelper;
            _menuFactory = menuFactory;
            _product = product;
        }

        /// <summary>
        /// Obtém as opções disponíveis no menu para o produto.
        /// </summary>
        /// <returns>Uma lista de opções de menu como strings.</returns>
        private List<string> GetMenuOptions()
            => new List<string> { "Exibir Detalhes", "Comprar" };

        /// <summary>
        /// Obtém a seleção do usuário para o menu de opções do produto.
        /// </summary>
        /// <returns>O valor da opção selecionada pelo usuário.</returns>
        private int GetUserSelection()
        {
            int input;
            var menuOptions = GetMenuOptions();

            while (true)
            {
                Console.Clear();
                _menuHelper.Render($"Menu de opções: {_product.Name}", menuOptions);
                input = _menuHelper.GetUserInput();

                if (_menuHelper.InputValidate(input, menuOptions.Count))
                    break;
            }
            return input;
        }

        /// <summary>
        /// Inicia a exibição do menu de opções do produto e processa a seleção do usuário.
        /// </summary>
        public void Start()
        {
            try
            {
                int selectOption = GetUserSelection();

                switch (selectOption)
                {
                    case 1:
                        _product.ShowDetails();
                        break;
                    case 2:
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro ao tentar inicializar o menu de compra: {ex.Message}");
            }
        }
    }
}
