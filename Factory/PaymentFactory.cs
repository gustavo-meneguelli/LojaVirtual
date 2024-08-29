using LojaVirtual.Enums;
using LojaVirtual.Interfaces.Entities;
using LojaVirtual.Interfaces.Payment;
using LojaVirtual.Interfaces.Products;
using LojaVirtual.Payments;

namespace LojaVirtual.Factory
{
    /// <summary>
    /// Fábrica responsável por criar diversos tipos de pagamentos.
    /// </summary>
    /// <remarks>
    /// <see cref="PaymentFactory"/> possui métodos para criar os mais diversos tipos de pagamentos, usando como identificação padrão em seus parâmetros <see cref="EPaymentType"/>.
    /// </remarks>
    internal class PaymentFactory
    {
        /// <summary>
        /// Responsável por criar pagamento.
        /// </summary>
        /// <param name="ePaymentType">Instância responsável por criar o tipo de pagamento a ser gerado. Instância de <see cref="EPaymentType"/>.</param>
        /// <param name="user">Instância responsável por criar o usuário que realizará a compra. Instância de <see cref="IUser"/>.</param>
        /// <param name="product">Instância responsável por definir o produto a ser comprado. Instância de <see cref="IProduct"/>.</param>
        /// <returns>Retorna uma instância de <see cref="IPayment"/> com a forma de pagamento selecionada pelo usuário.</returns>
        /// <exception cref="NotImplementedException">Erro a ser exibido caso não houver a forma de pagamento selecionada.</exception>
        public static IPayment CreatePayment(EPaymentType ePaymentType, IUser user, IProduct product)
        {
            switch (ePaymentType)
            {
                case EPaymentType.CartãoDébito:
                    return new DebitCardPayment(user, product);
                case EPaymentType.CartãoCrédito:
                    return new CreditCardPayment(user, product);
                default:
                        throw new NotImplementedException("Erro. Forma de pagamento desconhecida.");

            }
        }
    }
}
