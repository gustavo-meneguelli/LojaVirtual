namespace LojaVirtual.Interfaces.Entities
{
    internal interface IUser
    {
        public string Name { get; set; }
        public decimal DebitCardBalance { get; set; }
        public decimal CreditCardBalance { get; set; }

        void ShowDetails();
    }
}
