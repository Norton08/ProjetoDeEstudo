using System;
using System.Globalization;

namespace exerciciofix3
{
    class Aluno
    {
      public string Nome;
      public double Nota1;
      public double Nota2;
      public double Nota3;

      public double Somatoria(){
          return Nota1+Nota2+Nota3;
      }
      public double NotaRestante(){
          return 60 - Somatoria();
      }

    }
}