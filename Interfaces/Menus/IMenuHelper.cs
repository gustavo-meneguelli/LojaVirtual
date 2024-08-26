namespace LojaVirtual.Interfaces.Menus
{
    /// <summary>
    /// Define os contratos que todos os menus auxiliares devem seguir, implementando métodos das interfaces:
    /// <see cref="IMenuRenderer"/>, <see cref="IGetUserInput"/> e <see cref="IMenuInputValidate"/>.
    /// </summary>
    /// <remarks>
    /// A interface <see cref="IMenuHelper"/> combina funcionalidades relacionadas à renderização de menus, obtenção de entrada do usuário 
    /// e validação da entrada. Classes que implementam esta interface devem fornecer implementações para todos os métodos definidos 
    /// nas interfaces baseadas em <see cref="IMenuRenderer"/>, <see cref="IGetUserInput"/> e <see cref="IMenuInputValidate"/>.
    /// </remarks>
    internal interface IMenuHelper : IMenuRenderer, IGetUserInput, IMenuInputValidate
    {
        // A interface não precisa declarar métodos adicionais, pois herda todos os métodos das interfaces baseadas.
    }
}
