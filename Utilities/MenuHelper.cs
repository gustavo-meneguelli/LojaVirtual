using LojaVirtual.Interfaces.Menus;

namespace LojaVirtual.Utilities
{
    internal class MenuHelper : IMenuHelper
    {
        public void Render(string menuTitle, List<string> listMenuOptions)
        {
            Console.WriteLine("------------------------");
            Console.WriteLine($"{menuTitle}");
            Console.WriteLine("------------------------");
            for (int i = 0; i < listMenuOptions.Count; i++)
                Console.WriteLine($"[{i + 1}] {listMenuOptions[i]}");
        }

        public int GetUserInput()
        {
            Console.WriteLine("------------------------");
            Console.Write("Digite a opção desejada: ");
            string? input = Console.ReadLine();

            if(string.IsNullOrEmpty(input) || !(int.TryParse(input, out _)))
                return -1;

            return int.Parse(input);
        }

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
