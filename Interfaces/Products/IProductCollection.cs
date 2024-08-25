namespace LojaVirtual.Interfaces.Products
{
    internal interface IProductCollection
    {
        public Dictionary<int, IProduct> GetAllProducts();
    }
}
