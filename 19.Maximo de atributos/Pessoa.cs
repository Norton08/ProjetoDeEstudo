using System;
using System.Collections.Generic;
using _19.Maximo_de_atributos_Empresa;

namespace _19.Maximo_de_atributos_Pessoa
{
    public class Pessoa
    {
    
        public string Nome { get; set; }

        public int Idade { get; set; }

        public string Cpf { get; set; }

        public bool PossuiEmpressa { get; set; }

        public DateTime DatadeNascimento { get; set; }

        public float Altura { get; set; }

        public float Peso { get; set; }

        public string OrientacaoSexual { get; set; }

        public string Nacionalidade { get; set; }

        public string NomePai { get; set; }

        public string NomeMae { get; set; }

        public string Rg { get; set; }

        public List<string> CaracteristicasdePersonalidade { get; set; }

        public string TrabalhoAtual { get; set; }

        public string Estilo { get; set; }

        public string CordoCabelo { get; set; }

        public string TomdePele { get; set; }

        public List<string> EstiloFavoritodeMusica { get; set; }

        public string Comorbidades { get; set; }

        public List<string> VacinasAplicadas { get; set; }

        public double RendaMensal { get; set; }

        public bool IsNomeSujo { get; set; }

        public string Hobbies { get; set; }

        public List<string> Vicios { get; set; }

        public string SituacaoMental { get; set; }

        public string SituacaoDocumentos { get; set; }
        
        public Empresa NomeEmpresa { get; set; }
    
    }
}