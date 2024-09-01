using LojaVirtual.Collections;
using LojaVirtual.Enums;
using LojaVirtual.Interfaces.Products;

namespace LojaVirtual.ProductManagement
{
    /// <summary>
    /// Gerencia as coleções de produtos, fornecendo acesso às coleções baseadas em tipos de produtos.
    /// </summary>
    /// <remarks>
    /// A classe <see cref="ProductCollectionManager"/> mantém um dicionário de coleções de produtos, onde cada coleção é associada a um tipo específico de produto.
    /// </remarks>
    internal class ProductCollectionManager : IProductCollectionManager
    {
        private Dictionary<EProductsType, IProductCollection> _productsCollections;

        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="ProductCollectionManager"/>.
        /// </summary>
        /// <remarks>
        /// O construtor cria um dicionário de coleções de produtos e adiciona uma coleção para o tipo de produto <see cref="EProductsType.Book"/>.
        /// </remarks>
        public ProductCollectionManager()
        {
            _productsCollections = new Dictionary<EProductsType, IProductCollection>
            {
                { EProductsType.Book, new BookCollection() },
                { EProductsType.Ebook, new EbookCollection() },
            };
        }

        /// <summary>
        /// Obtém todas as coleções de produtos gerenciadas.
        /// </summary>
        /// <returns>
        /// Um dicionário onde a chave é o tipo de produto <see cref="EProductsType"/> e o valor é a coleção de produtos correspondente <see cref="IProductCollection"/>.
        /// </returns>
        public Dictionary<EProductsType, IProductCollection> GetAllProductsCollections()
            => _productsCollections;

        /// <summary>
        /// Obtém a coleção de produtos para um tipo específico de produto.
        /// </summary>
        /// <param name="productsType">O tipo de produto para o qual a coleção deve ser retornada.</param>
        /// <returns>
        /// A coleção de produtos correspondente ao tipo especificado. Se o tipo de produto não estiver presente, pode lançar uma exceção.
        /// </returns>
        public IProductCollection GetProductCollectionAtType(EProductsType productsType)
            => _productsCollections[productsType];
            
    }
}
