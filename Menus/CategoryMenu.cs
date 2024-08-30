using LojaVirtual.Enums;
using LojaVirtual.Interfaces.Entities;
using LojaVirtual.Interfaces.Factory;
using LojaVirtual.Interfaces.Menus;
using LojaVirtual.Interfaces.Products;

namespace LojaVirtual.Menus
{
    /// <summary>
    /// Representa o menu de categorias de produtos, permitindo ao usuário selecionar um tipo de produto para visualizar sua lista.
    /// </summary>
    /// <remarks>
    /// A classe <see cref="CategoryMenu"/> gerencia a exibição do menu de categorias e a navegação para a lista de produtos baseada na seleção do usuário.
    /// </remarks>
    internal class CategoryMenu : IMenu
    {
        private readonly IUser _user;
        private readonly IMenuHelper _menuHelper;
        private readonly IMenuFactory _menuFactory;
        private readonly IProductCollectionManager _productCollectionManager;

        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="CategoryMenu"/>.
        /// </summary>
        /// <param name="user">Uma instância que fornece o usuário que estará logado no sistema. Deve implementar de <see cref="IUser"/>.</param>
        /// <param name="menuHelper">Uma instância que fornece métodos auxiliares para renderização e validação de menus. Deve implementar <see cref="IMenuHelper"/>.</param>
        /// <param name="menuFactory">Uma instância responsável pela criação de menus. Deve implementar <see cref="IMenuFactory"/>.</param>
        /// <param name="productCollectionManager">Uma instância que gerencia as coleções de produtos. Deve implementar <see cref="IProductCollectionManager"/>.</param>
        public CategoryMenu(IUser user, IMenuHelper menuHelper, IMenuFactory menuFactory, IProductCollectionManager productCollectionManager)
        {
            _user = user;
            _menuHelper = menuHelper;
            _menuFactory = menuFactory;
            _productCollectionManager = productCollectionManager;
        }

        /// <summary>
        /// Obtém as opções disponíveis no menu de categorias.
        /// </summary>
        /// <returns>
        /// Uma lista de opções que representa os tipos de produtos disponíveis para seleção.
        /// </returns>
        private List<string> GetMenuOptions()
            => new List<string> { "Book", "Ebook" };

        /// <summary>
        /// Exibe o menu no console e recebe a seleção do usuário.
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
                _menuHelper.Render("Categoria dos Produtos", menuOptions);
                input = _menuHelper.GetUserInput();

                if (_menuHelper.InputValidate(input, menuOptions.Count))
                    break;
            }

            return input;
        }

        /// <summary>
        /// Inicializa e exibe o menu de listagem de produtos baseados na categoria selecionada pelo usuário.
        /// </summary>
        /// <remarks>
        /// Este método lida com a seleção do usuário e, com base na seleção, cria e inicializa o menu de lista de produtos usando o <see cref="IMenuFactory"/>.
        /// Em caso de erro ao inicializar o menu de lista de produtos, uma mensagem de erro é exibida no console.
        /// </remarks>
        public void Start()
        {
            try
            {
                int selectOption = GetUserSelection();

                if (selectOption == 0) //Voltar ao menu principal
                    return;

                EProductsType productType = (EProductsType)selectOption;
                IProductCollection productCollection = _productCollectionManager.GetProductCollectionAtType(productType);
                IMenu productListMenu = _menuFactory.CreateProductListMenu(productCollection, productType);
                productListMenu.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro ao tentar inicializar a interface do Menu de Categoria: {ex.Message}");
                Console.ReadKey();
            }
            
        }
    }
}
