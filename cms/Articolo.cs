namespace sc_classi.cms;

public class Articolo
{
    public Articolo() : this(string.Empty, string.Empty, DateTime.Now, new Categoria(), new Autore())
    {

    }
    public Articolo(string? titolo, string? testo, DateTime? dataPubblicazione, Categoria? categoria, Autore? autore)
    {
        this.Titolo = (titolo == null || titolo == string.Empty) ? "Senza Titolo" : titolo;
        this.Testo = (testo == null || testo == string.Empty) ? "Testo non disponibile" : testo;
        this.DataPubblicazione = dataPubblicazione ?? DateTime.Now;
        this.Categoria = categoria;
        this.Autore = autore;
    }

    public string Titolo { get; set; } = string.Empty;
    public string Testo { get; set; } = string.Empty;
    public DateTime DataPubblicazione { get; set; } = DateTime.Now;

    public Categoria? Categoria { get; set; } // = null; implicito
    public Autore? Autore { get; set; } // = null; implicito
}


    // public Articolo(string titolo, string testo, DateTime dataPubblicazione, Categoria? categoria, Autore? autore)
    // {
    //     this.Titolo = titolo;
    //     this.Testo = testo;
    //     this.DataPubblicazione = dataPubblicazione;
    //     this.Categoria = categoria;
    //     this.Autore = autore;
    // }

    // public string Titolo { get; set; } = string.Empty;
    // public string Testo { get; set; } = string.Empty;
    // public DateTime DataPubblicazione { get; set; } = DateTime.Now;

    // public Categoria? Categoria { get; set; } // = null; implicito
    // public Autore? Autore { get; set; } // = null; implicito