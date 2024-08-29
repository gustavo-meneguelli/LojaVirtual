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
    }
}
