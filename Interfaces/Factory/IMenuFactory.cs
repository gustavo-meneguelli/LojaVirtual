using LojaVirtual.Enums;
using LojaVirtual.Interfaces.Menus;
using LojaVirtual.Interfaces.Products;

namespace LojaVirtual.Interfaces.Factory
{
    /// <summary>
    /// Define o contrato para uma fábrica de menus no sistema.
    /// </summary>
    /// <remarks>
    /// Esta interface deve ser implementada por classes responsáveis por criar diferentes tipos de menus.
    /// O uso de uma fábrica para gerar menus permite a separação de responsabilidades e facilita a manutenção
    /// e expansão do sistema.
    /// </remarks>
    internal interface IMenuFactory
    {
        /// <summary>
        /// Cria o menu principal da aplicação.
        /// </summary>
        /// <param name="productCollectionManager">O gerenciador de coleção de produtos que será utilizado no menu.</param>
        /// <returns>Uma instância de <see cref="IMenu"/> que representa o menu principal.</returns>
        IMenu CreateMainMenu(IProductCollectionManager productCollectionManager);

        /// <summary>
        /// Cria o menu de categorias de produtos.
        /// </summary>
        /// <param name="productCollectionManager">O gerenciador de coleção de produtos que será utilizado no menu de categorias.</param>
        /// <returns>Uma instância de <see cref="IMenu"/> que representa o menu de categorias.</returns>
        IMenu CreateCategoryMenu(IProductCollectionManager productCollectionManager);

        /// <summary>
        /// Cria o menu de lista de produtos, filtrado por tipo de produto.
        /// </summary>
        /// <param name="productCollection">A coleção de produtos a ser exibida no menu.</param>
        /// <param name="eProductsType">O tipo de produto a ser filtrado e exibido no menu.</param>
        /// <returns>Uma instância de <see cref="IMenu"/> que representa o menu de lista de produtos.</returns>
        IMenu CreateProductListMenu(IProductCollection productCollection, EProductsType eProductsType);

    }
}
