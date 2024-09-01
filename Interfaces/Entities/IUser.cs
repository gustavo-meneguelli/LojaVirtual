namespace LojaVirtual.Interfaces.Entities
{
    internal interface IUser
    {
        /// <summary>
        /// Define ou obtém o nome do usuário.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Define ou obtém o saldo no cartão de débito do usuário
        /// </summary>
        public decimal DebitCardBalance { get; set; }

        /// <summary>
        /// Define ou obtém o limite no cartão de crédito do usuário
        /// </summary>
        public decimal CreditCardBalance { get; set; }

        /// <summary>
        /// Define ou obtém uma lista de produtos comprados.
        /// </summary>
        /// <remarks>
        /// Essa lista deve conter o nome do produto, preço, data do pagamento, tipo do produto e forma de pagamento.
        /// </remarks>
        public List<List<object>> PurchasedProducts { get; set; }

        /// <summary>
        /// Exibe os detalhes do usuário.
        /// </summary>
        /// <remarks>
        /// Esse método exibe na tela do console as informações do usuário, mostrando nome, saldo em sua carteira.
        /// </remarks>
        void ShowDetails();

        /// <summary>
        /// Exibe uma lista de produtos comprados pelo usuário.
        /// </summary>
        /// <remarks>
        /// Esse método exibe informações como <c>nome do poduto, preço, data da compra, tipo do produto e forma de pagamento realizada na compra</c>. 
        /// </remarks>
        void ShowPurchasedProducts();
    }
}
