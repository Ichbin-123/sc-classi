using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace sc_classi.cms;

public class Manager
{

    public Manager()
    {

    }
    // public List<Autore> Autori { get; private set; } = new List<Autore>();
    // public List<Categoria> Categorie { get; private set; } = new List<Categoria>();
    // public List<Articolo> Articoli { get; private set; } = new List<Articolo>();
    private List<Autore> autori = new List<Autore>();
    public List<Autore> Autori
    {
        get { return new List<Autore>(autori); }
    }

    private List<Categoria> categorie = new List<Categoria>();
    public List<Categoria> Categorie
    {
        get { return new List<Categoria>(categorie); }
    }

    private List<Articolo> articoli = new List<Articolo>();
    public List<Articolo> Articoli
    {
        get { return new List<Articolo>(articoli); }
    }

    public Autore CreaAutore(string? nome, string? cognome)
    {
        Autore nuovoAutore = new Autore(nome ?? string.Empty, cognome ?? string.Empty);
        if (this.EsisteAutore(nuovoAutore) == (-1)) autori.Add(nuovoAutore);
        return nuovoAutore;
    }

    public Categoria CreaCategoria(string? titolo, List<Articolo>? numeroArticoli)
    {
        numeroArticoli ??= new List<Articolo>();
        Categoria nuovaCategoria = new Categoria(titolo ?? string.Empty, numeroArticoli);
        if (this.EsiteCategoria(nuovaCategoria) == (-1)) categorie.Add(nuovaCategoria);
        return nuovaCategoria;
    }

    public Articolo CreaArticolo(string? titolo, string? testo, DateTime? dataPubblicazione, Categoria? categoria, Autore? autore)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        categoria ??= new Categoria();
        Console.WriteLine($"Test categoria: {categoria.Titolo}");

        autore ??= new Autore();
        Console.WriteLine($"Test autore: {autore.Cognome}");

        Articolo nuovoArticolo = new Articolo(titolo, testo, dataPubblicazione, categoria, autore);
        Console.WriteLine($"Test articolo: {nuovoArticolo.Titolo}");

        int esisteCategoria = this.EsiteCategoria(categoria);

        if (esisteCategoria == (-1))
        {
            categorie.Add(categoria);
            Console.WriteLine($"Test inserimento se esistente");
        }
        else
        {
            categoria = categorie[esisteCategoria];
            Console.WriteLine($"Test inserimento se INesistente");
        }
        categoria.InserisciArticolo(nuovoArticolo);
        articoli.Add(nuovoArticolo);

        if (this.EsisteAutore(autore) == (-1)) autori.Add(autore);
        Console.ResetColor();

        return nuovoArticolo;
    }

    public int EsisteAutore(Autore autore)
    {
        for (int i = 0; i < autori.Count; i++)
        {
            if (autori[i].Nome == autore.Nome && autori[i].Cognome == autore.Cognome)
            {
                return i;
            }
        }
        ;
        return -1;
    }

    public int EsiteCategoria(Categoria categoria)
    {
        for (int i = 0; i < categorie.Count; i++)
        {
            if (categorie[i].Titolo == categoria.Titolo)
            {
                return i;
            }
        }
        ;
        return -1;
    }

    public void MostraAutori()
    {

        Services.Instestazione("AUTORI", "primo");
        this.autori.ForEach(author =>
        {
            author.MostraAutore();
        });
        System.Console.WriteLine("\n");
    }

    public void MostraCategorie()
    {
        Services.Instestazione("CATEGORIE", "primo");
        this.categorie.ForEach(categoria =>
        {
            categoria.MostraCategoria();
        });
        System.Console.WriteLine("\n");
    }

    public void MostraArticoli()
    {
        Services.Instestazione("ARTICOLI", "primo");
        this.articoli.ForEach(articolo =>
        {
            articolo.MostraArticolo();
        });
        System.Console.WriteLine("\n");
    }

    public void CaricaArticoliDaFile(string percorsoFile)
    {
        List<Articolo>? articoliDaFile = Services.LeggiArticoliDaFile(percorsoFile);
        if (articoliDaFile == null) return;

        int maxIndex = 0;
        foreach (var articolo in articoliDaFile)
        {
            if (EsisteAutore(articolo.Autore!) == -1)
            {
                this.autori.Add(articolo.Autore!);
            }

            int indiceCategoria = EsiteCategoria(articolo.Categoria!);
            if (indiceCategoria == -1)
                this.categorie.Add(articolo.Categoria!);
            else
                articolo.Categoria = this.categorie[indiceCategoria];

            this.articoli.Add(articolo);
            if (articolo.Id > maxIndex) maxIndex = articolo.Id;
        }
        Articolo.SetCounter(maxIndex + 1);
        
    }

}