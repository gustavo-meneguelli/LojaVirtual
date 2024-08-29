using LojaVirtual.Interfaces.Menus;

namespace LojaVirtual.Utilities
{
    /// <summary>
    /// Classe auxiliar para realizar operações genéricas relacionadas ao menu, como renderizar, obter entrada e validar entrada do usuário.
    /// </summary>
    /// <remarks>
    /// A classe <see cref="MenuHelper"/> implementa a interface <see cref="IMenuHelper"/> e fornece métodos para renderizar menus, 
    /// obter e validar a entrada do usuário. Ela facilita a interação com o usuário ao lidar com opções de menu e validação de entrada.
    /// </remarks>
    internal class MenuHelper : IMenuHelper
    {
        /// <summary>
        /// Renderiza o menu no console, exibindo o título e as opções do menu.
        /// </summary>
        /// <param name="menuTitle">O título do menu a ser exibido.</param>
        /// <param name="listMenuOptions">A lista de opções do menu a ser exibida.</param>
        public void Render(string menuTitle, List<string> listMenuOptions)
        {
            Console.WriteLine("------------------------");
            Console.WriteLine($"{menuTitle}");
            Console.WriteLine("------------------------");
            for (int i = 0; i < listMenuOptions.Count; i++)
                Console.WriteLine($"[{i + 1}] {listMenuOptions[i]}");
            Console.WriteLine("-----------------------");
            Console.WriteLine("[0] Sair / Voltar ao menu principal");
            Console.WriteLine("-----------------------");
        }

        /// <summary>
        /// Obtém a entrada do usuário a partir do console.
        /// </summary>
        /// <returns>
        /// O valor digitado pelo usuário como um <c>int</c>. Retorna -1 se a entrada não for um número válido.
        /// </returns>
        public int GetUserInput()
        {
            Console.Write("Digite a opção desejada: ");
            string? input = Console.ReadLine();

            if(string.IsNullOrEmpty(input) || !(int.TryParse(input, out _)))
                return -1;

            return int.Parse(input);
        }

        /// <summary>
        /// Valida a entrada do usuário, garantindo que ela esteja dentro do intervalo permitido.
        /// </summary>
        /// <param name="input">O valor de entrada do usuário a ser validado.</param>
        /// <param name="numberOptionsMenu">O número total de opções disponíveis no menu.</param>
        /// <returns>
        /// <c>true</c> se a entrada for válida; caso contrário, <c>false</c>.
        /// </returns>
        /// <remarks>
        /// Se a entrada não estiver no intervalo de 0 a <paramref name="numberOptionsMenu"/>, uma mensagem de erro é exibida.
        /// </remarks>
        public bool InputValidate(int input, int numberOptionsMenu)
        {
            if (input >= 0 && input <= numberOptionsMenu) 
                return true;

            Console.WriteLine($"Erro. O valor digitado precisa ser entre 0 e {numberOptionsMenu}");
            Console.ReadKey();
            return false;
        }
    }
}
