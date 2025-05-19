namespace sc_classi.cms;

public class Categoria
{
    public Categoria() : this(string.Empty, new List<Articolo>())
    {

    }
    public Categoria(string? titolo, List<Articolo>? numeroArticoli)
    {
        this.Titolo = (titolo == null || titolo == string.Empty) ? "Categoria Ignota" : titolo;
        this.NumeroArticoli = numeroArticoli ?? new List<Articolo>();
    }

    public string Titolo { get; set; }
    public List<Articolo> NumeroArticoli { get; set; }
}

    // Versione richiesta
    // public Categoria(string titolo, List<Articolo> numeroArticoli)
    //     {
    //         this.Titolo = titolo;
    //         this.NumeroArticoli = numeroArticoli;
    //     }

    // public string Titolo { get; set; } = string.Empty;
    // public List<Articolo> NumeroArticoli { get; set; } = new List<Articolo> ();