using btd_Ghirardi_Nicolas;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

public class Prestazioni
{
    private static int NextId = 0;
    public int Id { get; private set; }
    public string Categoria { get; private set; }
    public bool Occupato { get; private set; }
    public string Lavoro { get; private set; }
    public int IdDatore { get; private set; }
    public int IdRichiedente { get; private set; }
    public int Ore { get; private set; }
    public DateTime Creazione { get; private set; }
    public DateTime Occupazione { get; private set; }
    public string Zona { get; private set; }

    public Prestazioni(string categoria, string lavoro, int idDatore, int ore,string zone)
    {
        Id = NextId++;
        Categoria = categoria;
        Occupato = false;
        Lavoro = lavoro;
        IdDatore = idDatore;
        IdRichiedente = -1; // Nessun richiedente inizialmente
        Ore = ore;
        Creazione = DateTime.Now;
        Zona = zone;
    }
    [JsonConstructor]
    public Prestazioni(int id, string categoria, string lavoro, int idDatore, int ore, bool occupato, int idRichiedente,string zona,DateTime creazione,DateTime occupazione)
    {
        
        Id = NextId++;
        Categoria = categoria;
        Occupato = occupato;
        Lavoro = lavoro;
        IdDatore = idDatore;
        IdRichiedente = idRichiedente;
        Ore = ore;
        Creazione = creazione;
        Occupazione=occupazione;
        Zona= zona; 
    }
    
    public void Occupa(int richiedenteId, int datoreId, List<Socio> soci)
    {
        if (Occupato)
            throw new Exception("Questa attività è già occupata.");

        IdRichiedente = richiedenteId;
        Occupato = true;

        Socio richiedente = soci.FirstOrDefault(s => s.Id == IdRichiedente);
        if (richiedente != null)
        {
            richiedente.DiminuisciOre(Ore);
        }

        Socio datore = soci.FirstOrDefault(s => s.Id == datoreId);
        if (datore != null)
        {
            datore.Aumentaore(Ore);
        }

        Occupazione = DateTime.Now;
    }
    public void ModificaPrestazione(string nuovaCategoria, string nuovoLavoro, int nuoveOre)
    {
        Categoria = nuovaCategoria;
        Lavoro = nuovoLavoro;
        Ore = nuoveOre;
    }
}
