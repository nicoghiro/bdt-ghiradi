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
        [JsonIgnore] 
        public Zona Zona { get; set; }



        public Socio(string cognome, string nome, string telefono, bool faParteSegreteria = false)
        {
            Id = NextId++;
            Cognome = cognome;
            Nome = nome;
            Telefono = telefono;
            FaParteSegreteria = faParteSegreteria;
            
            ore = 0;
        }

        public Socio(int id, string cognome, string nome, string telefono, int ore, bool faParteSegreteria = false)
        {
            Id = id;
            Cognome = cognome;
            Nome = nome;
            Telefono = telefono;
            FaParteSegreteria = faParteSegreteria;
           
            this.ore = ore;
        }

        [JsonConstructor]
        public Socio(int id, string cognome, string nome, int ore, string telefono, bool faParteSegreteria = false)
        {
            Id = NextId++;
            Cognome = cognome;
            Nome = nome;
            Telefono = telefono;
            FaParteSegreteria = faParteSegreteria;
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
        public override string ToString()
        {
            return Id + " " + Nome + " " + Cognome + " " + Telefono + " " + FaParteSegreteria;
        }

        public int CompareTo(Socio other)
        {
            return this.Id.CompareTo(other.Id);
        }
        public List<Prestazioni> GetPrestazioni(List<Prestazioni> allPrestazioni)
        {

            if (allPrestazioni == null)
            {
                return new List<Prestazioni>(); 
            }

            var attivitaAssociate = allPrestazioni.Where(p => p.IdDatore == Id);

            if (attivitaAssociate.Any())
            {
                return attivitaAssociate.ToList();
            }
            else
            {
                return new List<Prestazioni>();
            }
        }
    }
}
