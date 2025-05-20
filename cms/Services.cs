using System.Text.Json;

namespace sc_classi.cms;

public static class Services
{
    

    public static void ClearScreen()
    {
        Console.Clear();
        Console.ResetColor();
    }

    public static string GetArticoliPath()
    {
        DirectoryInfo currentDir = new DirectoryInfo(Environment.CurrentDirectory);             
        DirectoryInfo articoliDir = new DirectoryInfo(Path.Combine(currentDir.FullName, "articoli"));
        string percorso = Path.Combine(articoliDir.FullName, "articoli.json");
        return percorso;
    }

    // https://www.bytehide.com/blog/jsonserialization-csharp
    public static List<Articolo>? LeggiArticoliDaFile(string percorsoFile)
    {

        if (!File.Exists(percorsoFile)) return new List<Articolo>();

        string json = File.ReadAllText(percorsoFile);
        return JsonSerializer.Deserialize<List<Articolo>>(json);
    }

    public static void Instestazione(string intestazione, string livello)
    {
        if (livello == "primo")
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            System.Console.WriteLine($"\n-----------{intestazione}-----------");
        }
        else if (livello == "secondo")
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            System.Console.WriteLine($"\n------{intestazione}------");
        }
        else if (livello == "terzo")
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            System.Console.WriteLine($"\n------{intestazione}------");
        }

        Console.ResetColor();
    }
    

}