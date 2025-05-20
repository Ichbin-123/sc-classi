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

    public void InserisciArticolo(Articolo articolo)
    {
        if (articolo.Categoria!.Titolo == this.Titolo)
        {
            if (this.EsiteArticolo(articolo) == (-1))
            {
                this.NumeroArticoli.Add(articolo);                
            }
        }
    }

    public void MostraCategoria()
    {
        Services.Instestazione($"CATEGORIA: {this.Titolo}", "secondo");
        this.NumeroArticoli.ForEach(art =>
        {
            Console.WriteLine($"{art.Id} - {art.Titolo}");
        });
    }

    public int EsiteArticolo(Articolo articolo)
    {
        for (int i = 0; i < this.NumeroArticoli.Count; i++)
        {
            if (this.NumeroArticoli[i].Id == articolo.Id)
            {
                return i;
            }
        };
        return -1;
    }
}

    // Versione richiesta
    // public Categoria(string titolo, List<Articolo> numeroArticoli)
    //     {
    //         this.Titolo = titolo;
    //         this.NumeroArticoli = numeroArticoli;
    //     }

    // public string Titolo { get; set; } = string.Empty;
    // public List<Articolo> NumeroArticoli { get; set; } = new List<Articolo> ();