using System;
using System.Collections.Generic;
using _19.Maximo_de_atributos_Pessoa;

namespace _19.Maximo_de_atributos_Familia 
{ 
    public class Familia
    {
        public List<Pessoa> Familiares { get; set; }

        public string HerançaGenetica { get; set; }

        public string RendaFamiliar { get; set; }

        public bool MoramPerto { get; set; }

        public bool IsProximos { get; set; }

        public bool IsReligiosos { get; set; }

        public string Religiao { get; set; }

        public bool AreMenteAberta { get; set; }

        public bool ComemFeijaoporCimadoArroz { get; set; }

        public bool ISFumam { get; set; }

        public bool AreCaseiros { get; set; }

        public List<string> Profissoes { get; set; }

        public bool AreFesteiros { get; set; }
    
    }
}