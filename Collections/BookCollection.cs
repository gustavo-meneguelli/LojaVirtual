using LojaVirtual.Interfaces.Products;
using LojaVirtual.Products;

namespace LojaVirtual.Collections
{
    /// <summary>
    /// Representa uma coleção de livros disponíveis para a loja.
    /// </summary>
    /// <remarks>
    /// A classe <see cref="BookCollection"/> implementa a interface <see cref="IProductCollection"/> e gerencia uma coleção de livros.
    /// </remarks>
    internal class BookCollection : IProductCollection
    {
        /// <summary>
        /// Obtém ou define um dicionário de livros, onde a chave é o identificador do livro e o valor é o objeto <see cref="IProduct"/> correspondente.
        /// </summary>
        public Dictionary<int, IProduct> Books { get; set; }

        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="BookCollection"/> com uma coleção de livros predefinidos.
        /// </summary>
        public BookCollection()
        {
            Books = new Dictionary<int, IProduct>()
            {
                { 1, new Book("O Senhor dos Anéis", "J.R.R. Tolkien", 49.90m) },
                { 2, new Book("1984", "George Orwell", 39.90m) },
                { 3, new Book("Dom Casmurro", "Machado de Assis", 29.90m) },
                { 4, new Book("Harry Potter e a Pedra Filosofal", "J.K. Rowling", 59.90m) },
                { 5, new Book("O Código Da Vinci", "Dan Brown", 34.90m) }
            };
        }

        /// <summary>
        /// Obtém todos os produtos da coleção de livros.
        /// </summary>
        /// <returns>Um dicionário de livros, onde a chave é o identificador do livro e o valor é o objeto <see cref="IProduct"/> correspondente.</returns>
        public Dictionary<int, IProduct> GetAllProducts() => Books;
    }
}
