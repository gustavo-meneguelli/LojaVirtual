using LojaVirtual.Enums;
using LojaVirtual.Interfaces.Entities;
using LojaVirtual.Interfaces.Factory;
using LojaVirtual.Interfaces.Menus;
using LojaVirtual.Interfaces.Products;
using LojaVirtual.Menus;

namespace LojaVirtual.Factory
{
    /// <summary>
    /// Implementa a fábrica responsável pela criação de instâncias de diferentes menus no sistema.
    /// </summary>
    /// <remarks>
    /// A classe <see cref="MenuFactory"/> fornece métodos para criar menus principais, de categorias e de listas de produtos, utilizando o auxílio de uma instância de <see cref="IMenuHelper"/>.
    /// </remarks>
    internal class MenuFactory : IMenuFactory
    {
        private readonly IUser _user;
        private readonly IMenuHelper _menuHelper;

        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="MenuFactory"/>.
        /// </summary>
        /// <param name="menuHelper">Uma instância que fornece métodos auxiliares para renderização e validação de menus. Deve implementar <see cref="IMenuHelper"/>.</param>
        /// <param name="user">Uma instância que fornece o usuário do sistema, fornecendo propriedades e métodos relacionados ao mesmo.</param>
        public MenuFactory(IUser user, IMenuHelper menuHelper)
        {
            _user = user;
            _menuHelper = menuHelper;
        }

        /// <summary>
        /// Cria uma instância do menu principal.
        /// </summary>
        /// <param name="productCollectionManager">Uma instância que gerencia as coleções de produtos. Deve implementar <see cref="IProductCollectionManager"/>.</param>
        /// <returns>Uma instância de <see cref="IMenu"/> representando o menu principal.</returns>
        public IMenu CreateMainMenu(IProductCollectionManager productCollectionManager)
            => new MainMenu(_user, _menuHelper, this, productCollectionManager);

        /// <summary>
        /// Cria uma instância do menu de categorias de produtos.
        /// </summary>
        /// <param name="productCollectionManager">Uma instância que gerencia as coleções de produtos. Deve implementar <see cref="IProductCollectionManager"/>.</param>
        /// <returns>Uma instância de <see cref="IMenu"/> representando o menu de categorias de produtos.</returns>
        public IMenu CreateCategoryMenu(IProductCollectionManager productCollectionManager)
            => new CategoryMenu(_user, _menuHelper, this,  productCollectionManager);

        /// <summary>
        /// Cria uma instância do menu de lista de produtos.
        /// </summary>
        /// <param name="productCollection">Uma instância que fornece acesso à coleção de produtos. Deve implementar <see cref="IProductCollection"/>.</param>
        /// <param name="eProductsType">O tipo de produto a ser exibido no menu de lista de produtos. Deve ser um valor da enumeração <see cref="EProductsType"/>.</param>
        /// <returns>Uma instância de <see cref="IMenu"/> representando o menu de lista de produtos.</returns>
        public IMenu CreateProductListMenu(IProductCollection productCollection, EProductsType eProductsType)
            => new ProductListMenu(_user, _menuHelper, this, productCollection, eProductsType);

        /// <summary>
        /// Cria uma instância do menu do produto escolhido pelo usuário.
        /// </summary>
        /// <param name="product">Uma instância que fornece o produto escolhido.</param>
        /// <returns>Uma instância de <see cref="IMenu"/> representando o menu de opções do produto.</returns>
        public IMenu CreateProductOptionsMenu(IProduct product)
            => new ProductOptionsMenu(_user, _menuHelper, this, product);

        /// <summary>
        /// Cria uma instância do menu de pagamento escolhido pelo usuário.
        /// </summary>
        /// <param name="product">Uma instância que forne o produto que vai ser comprado.</param>
        /// <returns>Uma instância de <see cref="IMenu"/> que representa o menu de pagamento.</returns>
        public IMenu CreatePaymentMenu(IProduct product)
            => new PaymentMenu(_user, _menuHelper, product);
    }
}
