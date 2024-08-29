namespace LojaVirtual.Enums
{
    /// <summary>
    /// Define os diferentes tipos de pagamentos na aplicação.
    /// </summary>
    /// <remarks>
    /// <see cref="EPaymentType"/> categoriza as formas de pagamentos em tipos distintos, permitindo que o sistema identifique e trate as formas de pagamentos
    /// baseadas em suas categorias.
    /// </remarks>
    internal enum EPaymentType
    {
        CartãoDébito = 1,
        CartãoCrédito = 2
    }
}
