namespace LojaVirtual.Interfaces.Menus
{
    /// <summary>
    /// Define o contrato que todos os menus do sistema devem seguir.
    /// </summary>
    /// <remarks>
    /// Essa classe deverá ser implementada por todas as classes que representam menus interativos no sitema.
    /// Um menu típico pode exibir opções do usuário, capturar entrada do usuário e processar escolha para executar uma ação específica.
    /// </remarks>
    internal interface IMenu
    {
        /// <summary>
        /// Inicia o controle de fluxo de interação com o usuário.
        /// </summary>
        /// /// <remarks>
        /// Este método deve conter a lógica para exibir as opções do menu ao usuário, capturar a entrada 
        /// do usuário e executar a ação correspondente. Implementações específicas podem variar dependendo 
        /// do tipo de menu e das opções disponíveis.
        /// </remarks>
        void Start();
    }
}
