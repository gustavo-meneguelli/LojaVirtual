using LojaVirtual.Interfaces.Entities;
using LojaVirtual.Interfaces.Factory;
using LojaVirtual.Interfaces.Menus;
using LojaVirtual.Interfaces.Products;

namespace LojaVirtual.Menus
{
    /// <summary>
    /// Representa o menu principal da aplicação, responsável por exibir opções e permitir a navegação para outros menus.
    /// </summary>
    /// <remarks>
    /// A classe <see cref="MainMenu"/> gerencia a interação do usuário com o menu principal, incluindo a exibição das opções disponíveis e a navegação para o menu de categorias.
    /// </remarks>
    internal class MainMenu : IMenu
    {
        private readonly IUser _user;
        private readonly IProductCollectionManager _productCollectionManager;
        private readonly IMenuHelper _menuHelper;
        private readonly IMenuFactory _menuFactory;

        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="MainMenu"/>.
        /// </summary>
        /// <param name="user">Uma instância que fornece o usuário que estará logado no sistema. Deve implementar de <see cref="IUser"/>.</param>
        /// <param name="menuHelper">Uma instância que fornece métodos auxiliares para renderização e validação de menus. Deve implementar <see cref="IMenuHelper"/>.</param>
        /// <param name="menuFactory">Uma instância que é responsável pela criação de menus. Deve implementar <see cref="IMenuFactory"/>.</param>
        /// <param name="productCollectionManager">Uma instância que gerencia as coleções de produtos. Deve implementar <see cref="IProductCollectionManager"/>.</param>
        public MainMenu(IUser user, IMenuHelper menuHelper, IMenuFactory menuFactory, IProductCollectionManager productCollectionManager)
        {
            _user = user;
            _menuHelper = menuHelper;
            _productCollectionManager = productCollectionManager;
            _menuFactory = menuFactory;
        }

        /// <summary>
        /// Obtém as opções disponíveis no menu principal.
        /// </summary>
        /// <returns>
        /// Uma lista de opções do menu principal que são exibidas para o usuário.
        /// </returns>
        private List<string> GetMenuOptions() 
            => new List<string> { "Produtos Disponíveis ", "Produtos Comprados" };

        /// <summary>
        /// Exibe o menu no console e recebe o valor digitado pelo usuário.
        /// </summary>
        /// <returns>
        /// Um número inteiro que representa a seleção do usuário, dentro das opções disponíveis no menu.
        /// </returns>
        private int GetUserSelection()
        {
            int input;
            var menuOptions = GetMenuOptions();

            // Loop para exibir o menu enquanto o input do usuário for falso.
            while (true)
            {
                Console.Clear();
                _user.ShowDetails();
                _menuHelper.Render("Menu Principal", menuOptions);
                input = _menuHelper.GetUserInput();

                if (_menuHelper.InputValidate(input, menuOptions.Count))
                    break;
            }
            return input;
        }

        /// <summary>
        /// Inicializa e exibe o menu principal, e navega para o menu de categorias se a opção apropriada for selecionada.
        /// </summary>
        /// <remarks>
        /// Este método lida com a seleção do usuário e, se a opção escolhida for válida, cria e inicializa o menu de categorias usando o <see cref="IMenuFactory"/>.
        /// Em caso de erro ao inicializar o menu de categorias, uma mensagem de erro é exibida no console.
        /// </remarks>
        public void Start()
        {
            int selectOption;

            while (true)
            {
                selectOption = GetUserSelection();

                switch (selectOption)
                {
                    case 1:
                        {
                            try
                            {
                                IMenu categoryMenu = _menuFactory.CreateCategoryMenu(_productCollectionManager);
                                categoryMenu.Start();
                            }
                            catch (Exception ex)
                            {

                                Console.WriteLine($"Ocorreu um erro ao tentar iniciliazar a interface do menu de categoria: {ex.Message}");
                                Console.ReadKey();
                            }
                            break;
                        }
                    case 2:
                        _user.ShowPurchasedProducts();
                        break;
                    case 0:
                        Console.WriteLine("Programa Encerrado."); 
                        Environment.Exit(0);
                        break;
                }

            
            }
        }

    }
}
