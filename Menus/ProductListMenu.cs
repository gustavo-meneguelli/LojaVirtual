using LojaVirtual.Enums;
using LojaVirtual.Interfaces.Entities;
using LojaVirtual.Interfaces.Factory;
using LojaVirtual.Interfaces.Menus;
using LojaVirtual.Interfaces.Products;

namespace LojaVirtual.Menus
{
    /// <summary>
    /// Representa o menu de lista de produtos para um tipo específico de produto, permitindo ao usuário selecionar um produto da lista.
    /// </summary>
    /// <remarks>
    /// A classe <see cref="ProductListMenu"/> gerencia a exibição de uma lista de produtos e a navegação para a exibição de detalhes de um produto específico.
    /// </remarks>
    internal class ProductListMenu : IMenu
    {
        private readonly IUser _user;
        private readonly IMenuHelper _menuHelper;
        private readonly IMenuFactory _menuFactory;
        private readonly IProductCollection _productCollection;
        private readonly EProductsType _productType;

        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="ProductListMenu"/>.
        /// </summary>
        /// <param name="user">Uma instância que fornece o usuário que estará logado no sistema. Deve implementar de <see cref="IUser"/>.</param>
        /// <param name="menuHelper">Uma instância que fornece métodos auxiliares para renderização e validação de menus. Deve implementar <see cref="IMenuHelper"/>.</param>
        /// <param name="menuFactory">Uma instância responsável pela criação de menus. Deve implementar <see cref="IMenuFactory"/>.</param>
        /// <param name="productCollection">Uma instância que fornece acesso à coleção de produtos. Deve implementar <see cref="IProductCollection"/>.</param>
        /// <param name="eProductType">O tipo de produto para o qual a lista de produtos será exibida. Deve ser um valor da enumeração <see cref="EProductsType"/>.</param>
        public ProductListMenu(IUser user, IMenuHelper menuHelper, IMenuFactory menuFactory, IProductCollection productCollection, EProductsType eProductType)
        {
            _user = user;
            _menuHelper = menuHelper;
            _menuFactory = menuFactory;
            _productCollection = productCollection;
            _productType = eProductType;
        }

        /// <summary>
        /// Obtém a lista de produtos baseada na coleção injetada.
        /// </summary>
        /// <returns>
        /// Uma lista de nomes de todos os produtos na coleção de produtos fornecida.
        /// </returns>
        private List<string> GetListProducts()
            => _productCollection.GetAllProducts().Values.Select(products => products.Name).ToList();

        /// <summary>
        /// Obtém as opções visíveis no menu de lista de produtos.
        /// </summary>
        /// <returns>
        /// Uma lista de opções que representa os nomes dos produtos disponíveis na coleção.
        /// </returns>
        private List<string> GetMenuOptions()
            => GetListProducts();

        /// <summary>
        /// Exibe o menu no console e recebe a seleção do usuário.
        /// </summary>
        /// <returns>
        /// Um número inteiro que representa a seleção do usuário dentro das opções disponíveis no menu.
        /// </returns>
        private int GetUserSelection()
        {
            int input;
            var menuOptions = GetMenuOptions();

            while (true)
            {
                Console.Clear();
                _user.ShowDetails();
                _menuHelper.Render($"Produtos do tipo: [{_productType}]", menuOptions);
                input = _menuHelper.GetUserInput();

                if (_menuHelper.InputValidate(input, menuOptions.Count))
                    break;
            }
            return input;
        }

        /// <summary>
        /// Inicializa o menu de lista de produtos.
        /// </summary>
        /// <remarks>
        /// Este método lida com a seleção do usuário, exibindo, obtendo a entrada do usuário e o produto selecionado. 
        /// Em caso de erro, uma mensagem genérica é exibida.
        /// </remarks>
        public void Start()
        {
            try
            {
                int selectOption = GetUserSelection();

                if (selectOption == 0) //Voltar ao menu principal
                    return;

                IProduct product = _productCollection.GetProductAtId(selectOption);
                IMenu productOptionsMenu = _menuFactory.CreateProductOptionsMenu(product);
                productOptionsMenu.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro ao tentar inicializar as opções do menu de listagem de produtos: {ex.Message}");
                Console.ReadKey();
            }
            
        }
    }
}
