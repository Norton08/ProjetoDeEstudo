using System;
using System.Collections.Generic;
using _19.Maximo_de_atributos_Pessoa;
using _19.Maximo_de_atributos_Familia;

namespace _19.Maximo_de_atributos_Casa
{
    public class Casa
    {
       
        public bool Isfinanciada { get; set; }

        public bool PossuiAlguel { get; set; }
        
        public int MetroQuadrado { get; set; }

        public bool IsCondominio { get; set; }

        public bool IsApartamento { get; set; }
        
        public bool PossuiGeladeira { get; set; }

        public int QuantidadeGeladeiras { get; set; }

        public bool PossuiFreezer { get; set; }

        public bool PossuiCozinha { get; set; }

        public int QuantidadeTelevisoes { get; set; }

        public int QuantidadedeComodos { get; set; }

        public int QuantidadeQuartos { get; set; }

        public int QuantidadedeBanheiros { get; set; }

        public float ValordaCasa { get; set; }

        public int QuantidadeMoradores { get; set; }
        
        public List<Pessoa> Moradores { get; set; }

    }
}