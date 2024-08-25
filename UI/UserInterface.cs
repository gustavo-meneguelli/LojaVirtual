using LojaVirtual.Interfaces.Factory;
using LojaVirtual.Interfaces.Menus;
using LojaVirtual.Interfaces.Products;

namespace LojaVirtual.UI
{
    internal class UserInterface
    {
        private readonly IMenuHelper _menuHelper;
        private readonly IMenuFactory _menuFactory;
        private readonly IProductCollectionManager _productCollectionManager;

        /// <summary>
        /// Inicializa uma nova instância da classe <see cref="UserInterface"/>.
        /// </summary>
        /// <param name="menuHelper">Uma instância que fornece métodos auxiliares para renderização e validação de menus. Deve implementar <see cref="IMenuHelper"/>.</param>
        /// <param name="menuFactory">Uma instância que é responsável pela criação de menus. Deve implementar <see cref="IMenuFactory"/>.</param>
        /// <param name="productCollectionManager">Uma instância que gerencia as coleções de produtos. Deve implementar <see cref="IProductCollectionManager"/>.</param>
        public UserInterface(IMenuHelper menuHelper, IMenuFactory menuFactory, IProductCollectionManager productCollectionManager)
        {
            _menuHelper = menuHelper;
            _menuFactory = menuFactory;
            _productCollectionManager = productCollectionManager;
        }

        /// <summary>
        /// Inicializa e exibe o menu principal da interface do usuário.
        /// </summary>
        /// <remarks>
        /// Este método cria uma instância do menu principal usando o <see cref="IMenuFactory"/> fornecido e o inicializa com a coleção de produtos gerenciada por <see cref="IProductCollectionManager"/>.
        /// Em caso de erro durante a criação ou inicialização do menu, o erro é capturado e uma mensagem é exibida no console.
        /// </remarks>
        public void Start()
        {
            try
            {
                IMenu mainMenu = _menuFactory.CreateMainMenu(_productCollectionManager);
                mainMenu.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro ao tentar inicializar a interface: {ex.Message}");
            }
            
        }
    }
}
