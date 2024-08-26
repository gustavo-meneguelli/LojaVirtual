namespace LojaVirtual.Enums
{
    /// <summary>
    /// Define os diferentes tipos de produtos disponíveis na aplicação.
    /// </summary>
    /// <remarks>
    /// O enum <see cref="EProductsType"/> categoriza os produtos em tipos distintos, permitindo que o sistema 
    /// trate e diferencie produtos com base em suas categorias. Os valores são atribuídos explicitamente para facilitar 
    /// a identificação e manipulação dos tipos de produtos.
    /// </remarks>
    internal enum EProductsType
    {
        /// <summary>
        /// Representa um livro físico.
        /// </summary>
        Book = 1,

        /// <summary>
        /// Representa um livro digital.
        /// </summary>
        Ebook = 2,
    }
}
