using btd_Ghirardi_Nicolas;
using System;
using System.Linq;

public class Prestazioni
{
    public string Categoria { get; private set; }
    public bool Occupato { get; private set; }
    public string Lavoro { get; private set; }
    public int IdDatore { get; private set; }
    public int IdRichiedente { get; private set; }
    public int Ore { get; private set; }
    public DateTime Creazione { get; private set; }
    public DateTime Occupazione { get; private set; }

    public Prestazioni(string categoria, string lavoro, int idDatore, int ore)
    {
        Categoria = categoria;
        Occupato = false;
        Lavoro = lavoro;
        IdDatore = idDatore;
        IdRichiedente = -1; // Nessun richiedente inizialmente
        Ore = ore;
        Creazione = DateTime.Now;
    }

    public void Occupa(int richiedenteId, BTD banca)
    {
        if (Occupato)
            throw new InvalidOperationException("Questa attività è già occupata.");

        Socio richiedente = banca.Soci.FirstOrDefault(s => s.Id == richiedenteId);
        if (richiedente == null)
            throw new InvalidOperationException("Il socio richiedente non esiste.");

        if (richiedente.ore < Ore)
            throw new InvalidOperationException("Il richiedente non ha abbastanza ore disponibili.");

        Occupato = true;
        IdRichiedente = richiedenteId;
        banca.AggiungiOreSocio(IdDatore, Ore);
        banca.DiminuisciOreSocio(richiedenteId, Ore);
        Occupazione = DateTime.Now;
    }
    public void ModificaPrestazione(string nuovaCategoria, string nuovoLavoro, int nuoveOre)
    {
        Categoria = nuovaCategoria;
        Lavoro = nuovoLavoro;
        Ore = nuoveOre;
    }
}
