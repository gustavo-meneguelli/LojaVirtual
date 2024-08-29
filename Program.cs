using LojaVirtual.Entities;
using LojaVirtual.Factory;
using LojaVirtual.Interfaces.Entities;
using LojaVirtual.Interfaces.Factory;
using LojaVirtual.Interfaces.Menus;
using LojaVirtual.Interfaces.Products;
using LojaVirtual.ProductManagement;
using LojaVirtual.UI;
using LojaVirtual.Utilities;

namespace LojaVirtual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Inicialização dos objetos
            IUser user = new User("Gustavo", 99.99m, 129.99m);
            IProductCollectionManager productCollectionManager = new ProductCollectionManager();
            IMenuHelper menuHelper = new MenuHelper();
            IMenuFactory menuFactory = new MenuFactory(user, menuHelper);
            UserInterface userInterface = new UserInterface(menuHelper, menuFactory, productCollectionManager);

            //Inicialização do programa
            userInterface.Start();
        }
    }
}
