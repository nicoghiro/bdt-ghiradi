using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace btd_Ghirardi_Nicolas
{
    public class Socio : IComparable<Socio>
    {
        private static int NextId = 0;
        public int Id { get; private set; }
        public string Cognome { get; private set; }
        public string Nome { get; private set; }
        public string Telefono { get; private set; }
        public bool FaParteSegreteria { get; private set; }
        public int ore { get; private set; }

        public List<Prestazioni> Pres { get; private set; }
        
        public Socio(string cognome, string nome, string telefono, bool faParteSegreteria = false)
        {
            Id = NextId++;
            Cognome = cognome;
            Nome = nome;
            Telefono = telefono;
            FaParteSegreteria = faParteSegreteria;
            Pres = new List<Prestazioni>();
            ore = 0;
        }

        public Socio(int id, string cognome, string nome, string telefono, int ore, bool faParteSegreteria = false)
        {
            Id = id;
            Cognome = cognome;
            Nome = nome;
            Telefono = telefono;
            FaParteSegreteria = faParteSegreteria;
            Pres = new List<Prestazioni>();
            this.ore = ore;
        }

        [JsonConstructor]
        public Socio(int id, string cognome, string nome,List<string>categorie, int ore, string telefono, bool faParteSegreteria = false)
        {
            Id = NextId++;
            Cognome = cognome;
            Nome = nome;
            Telefono = telefono;
            FaParteSegreteria = faParteSegreteria;
            Pres = new List<Prestazioni>();
            this.ore = ore;
          
            

        }
       

        public void Aumentaore(int aumento)
        {
            if (aumento > 0)
            {
                this.ore += aumento;
            }
            else
            {
                throw new Exception("Il numero di ore deve essere positivo");
            }
        }

        public void DiminuisciOre(int diminuzione)
        {
            if (diminuzione > 0)
            {
                ore -= diminuzione;
            }
            else
            {
                throw new Exception("Il numero di ore deve essere positivo");
            }
        }

        public void AggiungiPrestazione(Prestazioni prestazione)
        {
            Pres.Add(prestazione);
        }

        public override string ToString()
        {
            return Id + " " + Nome + " " + Cognome + " " + Telefono + " " + FaParteSegreteria;
        }

        public int CompareTo(Socio other)
        {
            return this.Id.CompareTo(other.Id);
        }
    }
}
