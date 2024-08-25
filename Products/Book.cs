using LojaVirtual.Enums;
using LojaVirtual.Interfaces.Products;

namespace LojaVirtual.Products
{
    internal class Book : IProduct
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public EProductsType ProductType { get; set; }
        public string Author { get; set; }

        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="Book"/> com o nome, autor e preço do livro.
        /// </summary>
        /// <param name="name">O nome do livro.</param>
        /// <param name="author">O autor do livro.</param>
        /// <param name="price">O preço do livro.</param>
        public Book(string name, string author, decimal price)
        {
            Name = name;
            Price = price;
            Author = author;
            ProductType = EProductsType.Book;
        }

        /// <summary>
        /// Exibe os detalhes do livro no console.
        /// </summary>
        public void ShowDetails()
        {
            Console.WriteLine("Exibindo Detalhes");
        }
    }
}
