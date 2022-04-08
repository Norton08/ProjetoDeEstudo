using System;
using System.Collections.Generic;
using System.Globalization;

class Pessoa
{
    public Pessoa()
    {

    }
    
    public Pessoa( string nome, int idade ) 
    {
        this.Nome = nome;
        this.Idade = idade;
    }

    public string Nome { get; set; }

    public int Idade { get; set; } 

    
}
