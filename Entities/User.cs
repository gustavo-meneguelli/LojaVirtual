using LojaVirtual.Interfaces.Entities;

namespace LojaVirtual.Entities
{
    /// <summary>
    /// Representa um usuário do sistema, implementando métodos e atributos de <see cref="IUser"/>.
    /// </summary>
    internal class User : IUser
    {
        /// <summary>
        /// Define ou obtém o nome do usuário
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Define ou obtém o saldo no cartão de débito.
        /// </summary>
        public decimal DebitCardBalance { get; set; }

        /// <summary>
        /// Define ou obtém o saldo no cartão de crédito.
        /// </summary>
        public decimal CreditCardBalance { get; set; }

        /// <summary>
        /// Define ou obtém uma Lista de objetos que possui listas de produtos comprados no sistema
        /// </summary>
        public List<List<object>> PurchasedProducts { get; set; }

        /// <summary>
        /// Inicializa a instância da classe <see cref="User"/>
        /// </summary>
        /// <param name="name">Nome do usuário</param>
        /// <param name="debitCardBalance">Saldo no cartão de débito.</param>
        /// <param name="credidCardBalance">Saldo no cartão de crédito.</param>
        public User(string name, decimal debitCardBalance, decimal credidCardBalance)
        {
            Name = name;
            DebitCardBalance = debitCardBalance;
            CreditCardBalance = credidCardBalance;
            PurchasedProducts = new List<List<object>>();
        }

        /// <summary>
        /// Exibe na tela do console os detalhes do usuário logado, mostrando o nome em suas carteiras.
        /// </summary>
        public void ShowDetails()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"Usuário: {Name}  \nCartão de Débito R${DebitCardBalance}  \nCartão de Crédito R${CreditCardBalance}");
            Console.ForegroundColor = ConsoleColor.White;
        }

        /// <summary>
        /// Exibe da tela do console uma lista de todos os produtos comprados.
        /// </summary>
        /// <remarks>
        /// Esse método vai exibir todos os produtos comprados pelo usuário, informando o produto, preço, horário da compra, tipo do produto
        /// e a forma de pagamento.
        /// </remarks>
        public void ShowPurchasedProducts()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("                     Produtos Comprados                             ");
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Nome do Produto   Preço   Data da Compra   Tipo do Produto   Forma de Pagamento");

            if (PurchasedProducts.Count == 0)
                Console.WriteLine("Nenhum produto comprado...");
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                for (int i = 0; i < PurchasedProducts.Count; i++)
                {
                    Console.WriteLine("-------------------------------------------------------------------------------");
                    for (int j = 0; j < PurchasedProducts[i].Count; j++)
                    {
                        Console.Write($"{PurchasedProducts[i][j]}   ");
                    }
                    Console.WriteLine();
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
    }
}
