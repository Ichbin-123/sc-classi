namespace sc_classi.cms;

public class Autore
{
    public Autore() : this(string.Empty, string.Empty)
    {

    }
    public Autore(string? nome, string? cognome)
    {
        this.Nome = (nome == null || nome == string.Empty) ? "Autore" : nome;
        this.Cognome = (cognome == null || cognome == string.Empty) ? "Ignoto" : cognome;
    }

    public string Nome { get; set; }
    public string Cognome { get; set; }
    
    public void MostraAutore()
    {
       Console.WriteLine($"{this.Nome} {this.Cognome}");
    }
}

    // Versione richiesta
    // public Autore(string nome, string cognome)
    //     {
    //         this.Nome = nome;
    //         this.Cognome = cognome;
    //     }

    // public string? Nome { get; set; } = string.Empty;
    // public string? Cognome { get; set; } = string.Empty;