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

        /// <summary>
        /// Obtém produto expecífico da coleção a partir do <c>Id</c>> inserido.
        /// </summary>
        /// <param name="id">Número de indentificação do produto na coleção.</param>
        /// <returns>
        /// Uma instância de <see cref="IProduct"/> dentro da coleção em <see cref="IProductCollection"/> indentificado pelo <c>Id</c> injetado.
        /// </returns>
        /// <remarks>
        /// O método <c>GetProductAtId</c> deve ser implementado para retornar um produto específico armazenado na coleção baseado em seu Id.
        /// A instância de <see cref="IProduct"/> resultante permite acessar o produto de forma individual, facilitando a manipulação. 
        /// </remarks>
        public IProduct GetProductAtId(int id);
    }
}
