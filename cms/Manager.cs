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

    public Articolo CreaArticolo(string? titolo, string? testo, DateTime? dataPubblicazione, Categoria? categoria, Autore? autore)
    {
        categoria ??= new Categoria();
        
        autore ??= new Autore();

        Articolo articolo = new Articolo(titolo, testo, dataPubblicazione, categoria, autore);

        if (this.EsiteCategoria(categoria) == (-1))
        {
            categorie.Add(categoria);
            categoria.NumeroArticoli.Add(articolo);
        } 
        if (this.EsisteAutore(autore) == (-1)) autori.Add(autore);

        return articolo;
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
    

}