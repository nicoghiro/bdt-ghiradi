using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btd_Ghirardi_Nicolas
{
    public class Zona
    {
        
        public string Nome { get; set; }
        public List<Socio> SociInZona { get; set; }

        public Zona(string nome)
        {
          
            Nome = nome;
            SociInZona = new List<Socio>();
        }

        // Aggiunge un socio all'elenco dei soci in questa zona
        public void AggiungiSocio(Socio socio)
        {
            if (socio != null && !SociInZona.Contains(socio))
            {
                SociInZona.Add(socio);
            }
        }

        // Rimuove un socio dall'elenco dei soci in questa zona
        public void RimuoviSocio(Socio socio)
        {
            if (socio != null && SociInZona.Contains(socio))
            {
                SociInZona.Remove(socio);
            }
        }

        // Restituisce l'elenco dei soci in questa zona
        public List<Socio> GetSociInZona()
        {
            return SociInZona;
        }
    }
}

