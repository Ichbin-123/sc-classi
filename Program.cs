namespace sc_classi;

using sc_classi.cms;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Manager manager = new Manager();
        manager.CreaAutore("Marco", "Fuchs");
        manager.CreaAutore("Andrea", "Fuchs");        
        manager.CreaAutore("Andrea", "Fuchs");        
        manager.CreaAutore("Andrea", "Fuchs");        
        manager.CreaAutore("Andrea", "Fuchs");        
        manager.CreaAutore("Marco", "Fuchs");
        manager.MostraAutori();
    }
}