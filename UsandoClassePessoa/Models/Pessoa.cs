using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsandoClassePessoa.Models
{
    public class Pessoa
    {
       public string Nome { get; set; }
       public int Idade { get; set; } 

       public void Apresentar()
       {
            console.Writeline($"Olá meu nome é {Nome} e tenho {Indade} ");

       }
    }
}