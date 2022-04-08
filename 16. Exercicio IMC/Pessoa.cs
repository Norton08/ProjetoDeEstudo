using System;

    class Pessoa
    {
        //Atributos
        public string Nome;
        public double Peso;
        public double Altura;
        //Imc
        public double ObterImc()
        {
            return Peso/(Altura*Altura);
        }
        //Situacao
       public string ObterSituacao(double Imc)
       {
           string situacao= new string(" sua situação é de") ;

           if (Imc<18.5)
           {
                situacao = situacao + " abaixo do peso";
                //string.Concat(situacao, " abaixo do peso" );
           }
           else if (Imc<25)
           {
               situacao = situacao + " peso normal";
           }
           else if (Imc<30)
           {
               situacao = situacao +" acima do peso";
           }
           else if (Imc<35)
           {
                situacao = situacao +" obesidade I";
           }
           else if (Imc<40)
           {
                situacao = situacao +" obesidade II";
           }
           else if (Imc>=40)
           {
                situacao = situacao +" obesidade III";
           }

           return situacao;
       }   

       //Mensagem
       public void Mensagem()
       {
            //Obter Imc
            double imc = ObterImc();

            //Obter situacao
            string situacao = ObterSituacao(imc);
            
            //Mensagem
            Console.Write(Nome + "," + situacao + " com Imc de " + imc);
       }
    }