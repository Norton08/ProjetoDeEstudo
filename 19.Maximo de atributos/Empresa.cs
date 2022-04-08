using System;
using System.Collections.Generic;
using _19.Maximo_de_atributos_Pessoa;

namespace _19.Maximo_de_atributos_Empresa
{
    public class Empresa
    {
       
        public string Cnpj { get; set; }

        public string Funcao { get; set; }

        public bool TrabalhacomPessoas { get; set; }

        public string TrabalhamEmQualArea { get; set; }

        public bool AreConhecidos { get; set; }

        public List<string> Regras { get; set; }

        public DateTime DatadeCriacao { get; set; }

        public int QuantidadedePessoasContratadas { get; set; }

        public bool IsEmpresaGrande { get; set; }

        public string NomedosFundadores { get; set; }

        public bool PossuiFranquias { get; set; }
        
        public int QuantidadedeFranquias { get; set; }

        public Pessoa DonodaEmpresa { get; set; }

        public List<Pessoa> Funcionarios { get; set; } 

        public Pessoa QualificacaoEmpresa { get; set; }   
    }
}   