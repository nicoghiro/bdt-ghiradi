using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace btd_Ghirardi_Nicolas
{
    [JsonObject]
    public class BTD
    {
   
        public List<Prestazioni> Pres { get; private set; }
        public List<Socio> Soci { get; private set; }
        public List<string> CategoriePrestazioni { get; private set; }
        public List<string> zone { get; private set; }

        [JsonConstructor]
        public BTD()
        {
            Soci = new List<Socio>();
            CategoriePrestazioni = new List<string>();
            Pres = new List<Prestazioni>();
            zone = new List<string>();
            
            
        }
        public void Contiene(string nuova)
        {
            if(nuova != null)
            {
                if (zone.Contains(nuova))
                {
                    throw new Exception("Questa zona è gia presente");
                }
            }
           
        }
        public List<Socio> Indebitati()
        {
            List<Socio> indebit = new List<Socio>();

            foreach (Socio socio in Soci)
            {
                if (socio.ore < 0)
                {
                    indebit.Add(socio);
                }
            }
            return indebit;
        }

        public void Occupaprestazione(Prestazioni pres, Socio richiedente)
        {
            pres.Occupa(richiedente.Id, pres.IdDatore, Soci);
        }
        public void AggiungiSocio(Socio nuovo)
        {
            if (nuovo != null)
            {
                Soci.Add(nuovo);
            }
        }
        public void AggiungiCategoria(string categoria)
        {
            if (!CategoriePrestazioni.Contains(categoria))
            {
                CategoriePrestazioni.Add(categoria);
            }
        }

        public void ModificaCategoria(string vecchiaCategoria, string nuovaCategoria)
        {
            int index = CategoriePrestazioni.IndexOf(vecchiaCategoria);
            if (index >= 0)
            {
                CategoriePrestazioni[index] = nuovaCategoria;
            }
        }

        public void EliminaCategoria(string categoria)
        {
            CategoriePrestazioni.Remove(categoria);
        }
        public void AggiungiOreSocio(int socioId, int ore)
        {
            Socio socio = Soci.FirstOrDefault(s => s.Id == socioId);
            if (socio != null)
            {
                socio.Aumentaore(ore);
            }
        }

        public void DiminuisciOreSocio(int socioId, int ore)
        {
            Socio socio = Soci.FirstOrDefault(s => s.Id == socioId);
            if (socio != null)
            {
                socio.DiminuisciOre(ore);
            }
        }
        public void AggiungiPrestazione(string categoria, string lavoro, int idDatore, int ore)
        {
            Prestazioni nuovaPrestazione = new Prestazioni(categoria, lavoro, idDatore, ore);
            Pres.Add(nuovaPrestazione);
        }

        public void ModificaPrestazione(int idDatore, string nuovaCategoria, string nuovoLavoro, int nuoveOre)
        {
            Prestazioni prestazioneDaModificare = Pres.FirstOrDefault(p => p.IdDatore == idDatore);
            if (prestazioneDaModificare != null)
            {
                prestazioneDaModificare.ModificaPrestazione(nuovaCategoria, nuovoLavoro, nuoveOre);
            }
        }

        public void EliminaPrestazione(int idPrestazione)
        {
  Prestazioni prestazioneDaEliminare = Pres.FirstOrDefault(p => p.Id == idPrestazione);
    if (prestazioneDaEliminare != null)
    {
        Pres.Remove(prestazioneDaEliminare);
    }
        }
    }
   
}
