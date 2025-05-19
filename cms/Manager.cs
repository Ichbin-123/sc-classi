using System.Net;
using System.Reflection.Metadata.Ecma335;

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
        autori.Add(nuovoAutore);
        return nuovoAutore;
    }

    public Categoria CreaCategoria(string? titolo, List<Articolo>? numeroArticoli)
    {
        numeroArticoli ??= new List<Articolo>();
        Categoria nuovaCategoria = new Categoria(titolo ?? string.Empty, numeroArticoli);
        categorie.Add(nuovaCategoria);
        return nuovaCategoria;
    }

    public Articolo CreaArticolo(string titolo, string testo, DateTime dataPubblicazione, Categoria categoria, Autore autore)
    {
        return new Articolo();
    }


}