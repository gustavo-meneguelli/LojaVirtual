using LojaVirtual.Enums;
using LojaVirtual.Interfaces.Menus;
using LojaVirtual.Interfaces.Products;

namespace LojaVirtual.Interfaces.Factory
{
    internal interface IMenuFactory
    {
        IMenu CreateMainMenu(IProductCollectionManager productCollectionManager);
        IMenu CreateCategoryMenu(IProductCollectionManager productCollectionManager);
        IMenu CreateProductListMenu(IProductCollection productCollection, EProductsType eProductsType);

    }
}
