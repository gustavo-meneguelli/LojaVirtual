using LojaVirtual.Enums;
using LojaVirtual.Interfaces.Products;

namespace LojaVirtual.Products
{
    /// <summary>
    /// Representa um livro como um produto na aplicação.
    /// </summary>
    /// <remarks>
    /// A classe <see cref="Book"/> implementa a interface <see cref="IProduct"/> e adiciona propriedades específicas 
    /// de um produto como, nome, preço e tipo do produto. Cada instância da classe <see cref="Book"/> representa um livro com um nome, autor, preço e tipo de produto.
    /// </remarks>
    internal class Book : IProduct
    {
        /// <summary>
        /// Obtém ou define o nome do livro.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Obtém ou define o preço do livro.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Obtém ou define o tipo do produto. Neste caso, sempre será <see cref="EProductsType.Book"/>.
        /// </summary>
        public EProductsType ProductType { get; set; }

        /// <summary>
        /// Obtém ou define o autor do livro.
        /// </summary>
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
        /// <remarks>
        /// Este método exibe as principais informações sobre o livro, incluindo nome, autor e preço, 
        /// proporcionando ao usuário uma visão clara do produto.
        /// </remarks>
        public void ShowDetails()
        {
            Console.Clear();
            Console.WriteLine("------------------------");
            Console.WriteLine("   Exibindo Detalhes    ");
            Console.WriteLine("------------------------");
            Console.WriteLine(
                $"Titulo: {Name} \n" +
                $"Autor: {Author} \n" +
                $"Preço: R${Price} \n" +
                $"Tipo do produto: {ProductType}");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
