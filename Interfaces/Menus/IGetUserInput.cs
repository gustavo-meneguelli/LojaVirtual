namespace LojaVirtual.Interfaces.Menus
{
    /// <summary>
    /// Interface para definir o contrato de obtenção de input do usuário.
    /// </summary>
    /// <remarks>
    /// Esta interface deve ser implementada por classes que são responsáveis por capturar 
    /// e processar a entrada do usuário.
    /// <remarks>
    internal interface IGetUserInput
    {
        /// <summary>
        /// Obtém o input do usuário e o retorna como um número inteiro.
        /// </summary>
        int GetUserInput();
    }
}
