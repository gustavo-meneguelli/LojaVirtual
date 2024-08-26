using LojaVirtual.Enums;

namespace LojaVirtual.Interfaces.Products
{
    /// <summary>
    /// Define o contrato para gerenciar coleções de produtos no sistema.
    /// </summary>
    /// <remarks>
    /// Esta interface deve ser implementada por classes que são responsáveis por gerenciar múltiplas coleções de produtos, 
    /// organizadas por tipo de produto. Ela fornece métodos para recuperar uma coleção específica ou todas as coleções de produtos.
    /// </remarks>
    internal interface IProductCollectionManager
    {
        /// <summary>
        /// Obtém a coleção de produtos para um tipo específico de produto.
        /// </summary>
        /// <param name="productsType">O tipo de produto para o qual a coleção deve ser recuperada.</param>
        /// <returns>
        /// Uma instância de <see cref="IProductCollection"/> que contém os produtos do tipo especificado.
        /// </returns>
        IProductCollection GetProductCollectionAtType(EProductsType productsType);

        /// <summary>
        /// Obtém todas as coleções de produtos, organizadas por tipo de produto.
        /// </summary>
        /// <returns>
        /// Um dicionário onde as chaves são do tipo <see cref="EProductsType"/> e os valores são instâncias de <see cref="IProductCollection"/>.
        /// </returns>
        /// <remarks>
        /// O método <c>GetAllProductsCollections</c> deve ser implementado para retornar todas as coleções de produtos, 
        /// permitindo o acesso a todas as coleções disponíveis no sistema de forma organizada e eficiente.
        /// </remarks>
        Dictionary<EProductsType, IProductCollection> GetAllProductsCollections();
    }
}
