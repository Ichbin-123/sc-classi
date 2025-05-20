namespace sc_classi;

using sc_classi.cms;

class Program
{
    static void Main(string[] args)
    {
        Services.ClearScreen();
        string pathFileArticoli = Services.GetArticoliPath();

        Manager manager = new Manager();
        manager.CaricaArticoliDaFile(pathFileArticoli);
        manager.MostraArticoli();
        manager.MostraCategorie();
        manager.MostraAutori();
    }
}