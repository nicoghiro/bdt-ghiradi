using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace btd_Ghirardi_Nicolas
{
    public class Prestazioni
    {
        public string Categoria { get; private set; }
        public bool occupato { get; private set; }
        public string lavoro { get; private set; }
        public Socio datore { get; private set; }
        public Socio richedente { get; private set; }
        public int ore { get; private set; }
        public DateTime creazione { get; private set; }
        public DateTime occupazione { get; private set; }   

        public Prestazioni(string categoria, string lavoro, Socio datore, int ore)
        {
            this.Categoria = categoria;
            this.occupato = false;
            this.lavoro = lavoro;
            this.datore = datore;
            this.richedente = richedente;
            this.ore = ore;
            this.creazione = DateTime.Now;
            
        }
        public void Occupa(Socio rich)
        {
            occupato = true;
            richedente=rich;
            datore.Aumentaore(ore);
            richedente.DiminuisciOre(ore);
            occupazione = DateTime.Now;
        }
    }
}
