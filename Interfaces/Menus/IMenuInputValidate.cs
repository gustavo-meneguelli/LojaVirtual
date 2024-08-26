namespace LojaVirtual.Interfaces.Menus
{
    /// <summary>
    /// Define o contrato para a validação do input inserido pelo usuário no sistema.
    /// </summary>
    /// <remarks>
    /// Esta interface deve ser implementada por classes que validam as entradas do usuário em menus.
    /// A validação é necessária para garantir que o input do usuário esteja dentro do intervalo esperado de opções
    /// disponíveis no menu.
    /// </remarks>
    internal interface IMenuInputValidate
    {
        /// <summary>
        /// Valida o input do usuário com base no número de opções disponíveis no menu.
        /// </summary>
        /// <param name="input">O input inserido pelo usuário.</param>
        /// <param name="numberOptionsMenu">O número total de opções disponíveis no menu.</param>
        /// <returns>
        /// Retorna <c>true</c> se o input do usuário for válido (dentro do intervalo de opções); 
        /// caso contrário, <c>false</c>.
        /// </returns>
        /// <remarks>
        /// Este método deve ser utilizado para garantir que o input do usuário seja adequado antes de processá-lo.
        /// Implementações específicas podem incluir verificações adicionais, como limites de intervalo ou 
        /// restrições de formato.
        /// </remarks>
        bool InputValidate(int input, int numberOptionsMenu);
    }
}
