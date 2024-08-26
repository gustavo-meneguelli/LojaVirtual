namespace LojaVirtual.Interfaces.Menus
{
    /// <summary>
    /// Define o contrato para exibição do menu no sistema.
    /// </summary>
    /// <remarks>
    /// Esta interface deve ser implementada por classes que são responsáveis por exibir menus ao usuário.
    /// A exibição pode incluir o título do menu e uma lista de opções que o usuário pode selecionar.
    /// </remarks>
    internal interface IMenuRenderer
    {
        /// <summary>
        /// Exibe o menu no console.
        /// </summary>
        /// <param name="menuTitle">O título do menu a ser exibido.</param>
        /// <param name="listMenuOptions">A lista de opções do menu que serão apresentadas ao usuário.</param>
        /// <remarks>
        /// Este método deve ser implementado para renderizar o menu no console, garantindo que o título 
        /// e as opções do menu sejam apresentados de forma clara e organizada. O método pode incluir a 
        /// formatação adequada para melhorar a experiência do usuário.
        /// </remarks>
        void Render(string menuTitle, List<string> listMenuOptions);
    }
}
