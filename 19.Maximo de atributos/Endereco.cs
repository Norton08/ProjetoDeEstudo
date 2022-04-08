using System;
using System.Collections.Generic;
using _19.Maximo_de_atributos_Casa;
using _19.Maximo_de_atributos_Empresa;
using _19.Maximo_de_atributos_Pessoa;

namespace _19.Maximo_de_atributos_Endereco
{
    public class Enderecos
    {

        public string Setor { get; set; }

        public int Numero { get; set; }

        public string Logradouro { get; set; }

        public string Cep { get; set; }

        public int Lote { get; set; }

        public string Localizacao { get; set; }

        public string LugarReferencial { get; set; }

        public bool IsLocalBom { get; set; }
        
        public Pessoa Residencia { get; set; }
        
        public Casa EnderecoCasa { get; set; }

        public Empresa EnderecoEmpresa { get; set; }
    
    }
}    