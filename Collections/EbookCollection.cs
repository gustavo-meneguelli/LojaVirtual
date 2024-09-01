using LojaVirtual.Interfaces.Products;
using LojaVirtual.Products;

namespace LojaVirtual.Collections
{
    internal class EbookCollection : IProductCollection
    {
        private Dictionary<int, IProduct> Ebooks { get; set; }

        public EbookCollection()
        {
            Ebooks = new Dictionary<int, IProduct>()
            {
                { 1, new Ebook("O Código Da Vinci", "Dan Brown", 24.90m) },
                { 2, new Ebook("A Guerra dos Tronos", "George R.R. Martin", 29.90m) },
                { 3, new Ebook("A Culpa é das Estrelas", "John Green", 19.90m) },
                { 4, new Ebook("O Pequeno Príncipe", "Antoine de Saint-Exupéry", 14.90m) },
                { 5, new Ebook("Sapiens: Uma Breve História da Humanidade", "Yuval Noah Harari", 34.90m) }
            };
        }
        public Dictionary<int, IProduct> GetAllProducts()
            => Ebooks;

        public IProduct GetProductAtId(int id)
            => Ebooks[id];
    }
}
