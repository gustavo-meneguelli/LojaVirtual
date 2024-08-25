using LojaVirtual.Enums;

namespace LojaVirtual.Interfaces.Products
{
    internal interface IProductCollectionManager
    {
        IProductCollection GetProductCollectionAtType(EProductsType productsType);
        Dictionary<EProductsType, IProductCollection> GetAllProductsCollections();
    }
}
