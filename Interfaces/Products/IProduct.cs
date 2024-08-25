using LojaVirtual.Enums;

namespace LojaVirtual.Interfaces.Products
{
    internal interface IProduct
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public EProductsType ProductType { get; set; }

        void ShowDetails();
    }
}
