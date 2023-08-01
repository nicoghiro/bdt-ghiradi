﻿using Newtonsoft.Json;
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
        public List<Socio> Soci { get; private set; }
        public List<string> CategoriePrestazioni { get; private set; }

        [JsonConstructor]
        public BTD()
        {
            Soci = new List<Socio>();
            CategoriePrestazioni = new List<string>();
        }

        public List<Socio> Indebitati()
        {
            List<Socio> indebit = new List<Socio>();

            foreach(Socio socio in Soci)
            {
                if(socio.ore < 0)
                {
                    indebit.Add(socio);
                }
            }
            return indebit;
        }
        public List<Prestazioni> GetPrestazioni()
        {
            List<Prestazioni> prestazioni = new List<Prestazioni>();
            foreach(Socio s in Soci)
            {
               foreach(Prestazioni p in s.Pres)
                {
                    prestazioni.Add(p); 
                }
            }
            return prestazioni;
        }
        public void Occupaprestazione(Prestazioni pres , Socio richiedente)
        {
            pres.Occupa(richiedente);
        }
        public List<Prestazioni> FiltroCategoria(string categoria)
        {
            List<Prestazioni> list = new List<Prestazioni>();
            foreach(Socio s in Soci)
            {
                foreach(Prestazioni pres in s.Pres)
                {
                    if (pres.Categoria == categoria)
                    {
                        list.Add(pres);
                    }
                }
            }
            return list;

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
    }
}
