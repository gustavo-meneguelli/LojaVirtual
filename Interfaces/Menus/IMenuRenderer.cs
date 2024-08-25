namespace LojaVirtual.Interfaces.Menus
{
    internal interface IMenuRenderer
    {
        void Render(string menuTitle, List<string> listMenuOptions);
    }
}
