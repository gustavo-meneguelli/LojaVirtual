using LojaVirtual.Enums;
using LojaVirtual.Interfaces.Products;

namespace LojaVirtual.Products
{
    internal class Ebook : IProduct
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public EProductsType ProductType { get; set; }
        public string Author { get; set; }

        public Ebook(string name, string author, decimal price)
        {
            Name = name;
            Author = author;
            Price = price;
            ProductType = EProductsType.Ebook;

        }

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
