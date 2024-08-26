using LojaVirtual.Enums;

namespace LojaVirtual.Interfaces.Products
{
    /// <summary>
    /// Define o contrato para um produto no sistema.
    /// </summary>
    /// <remarks>
    /// Esta interface deve ser implementada por classes que representam produtos no sistema. 
    /// Um produto possui propriedades essenciais como nome, preço e tipo, além de um método para exibir seus detalhes.
    /// </remarks>
    internal interface IProduct
    {
        /// <summary>
        /// Obtém ou define o nome do produto.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Obtém ou define o preço do produto.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Obtém ou define o tipo do produto.
        /// </summary>
        public EProductsType ProductType { get; set; }

        /// <summary>
        /// Exibe os detalhes do produto.
        /// </summary>
        /// <remarks>
        /// Este método deve ser implementado para apresentar ao usuário as informações do produto, 
        /// como o nome, o preço e o tipo, de maneira clara e compreensível.
        /// </remarks>
        void ShowDetails();
    }
}
