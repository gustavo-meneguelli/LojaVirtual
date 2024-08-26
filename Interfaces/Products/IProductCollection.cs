namespace LojaVirtual.Interfaces.Products
{
    /// <summary>
    /// Define o contrato para uma coleção de produtos no sistema.
    /// </summary>
    /// <remarks>
    /// Esta interface deve ser implementada por classes que gerenciam uma coleção de produtos. 
    /// Ela fornece um método para recuperar todos os produtos armazenados na coleção, permitindo que os produtos sejam acessados por seus identificadores únicos.
    /// </remarks>
    internal interface IProductCollection
    {
        /// <summary>
        /// Obtém todos os produtos na coleção.
        /// </summary>
        /// <returns>
        /// Um dicionário onde as chaves são identificadores únicos do tipo <c>int</c> e os valores são instâncias de <see cref="IProduct"/>.
        /// </returns>
        /// <remarks>
        /// O método <c>GetAllProducts</c> deve ser implementado para retornar todos os produtos armazenados na coleção. 
        /// O dicionário resultante permite acessar produtos individuais através de seus IDs únicos, facilitando a manipulação e exibição dos produtos.
        /// </remarks>.
        public Dictionary<int, IProduct> GetAllProducts();
    }
}
