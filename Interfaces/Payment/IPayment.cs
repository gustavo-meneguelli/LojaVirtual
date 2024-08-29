namespace LojaVirtual.Interfaces.Payment
{
    /// <summary>
    /// Interface para definir contratos para a realização de pagamentos.
    /// </summary>
    /// <remarks>
    /// Essa interface fornece métodos para a checagem, realização de pagamento e exibição de nota fiscal.
    /// </remarks>
    internal interface IPayment
    {
        /// <summary>
        /// Realiza o pagamento.
        /// </summary>
        /// <remarks>
        /// Esse método realiza a validação do pagamento e a exibição da nota fiscal.
        /// </remarks>
        void Pay();
        /// <summary>
        /// Exibe na tela do console a nota fiscal do produto comprado.
        /// </summary>
        void ShowInvoice();
        /// <summary>
        /// Realiza a checagem para a verificação do saldo do usuário com o valor do produto correspondente. 
        /// </summary>
        /// <returns>Retorna <c>True</c> caso seja possível realizar o pagamento e <c>False</c> caso não for possível realizar o pagamento.</returns>
        bool CheckUserBalance();
    }
}
