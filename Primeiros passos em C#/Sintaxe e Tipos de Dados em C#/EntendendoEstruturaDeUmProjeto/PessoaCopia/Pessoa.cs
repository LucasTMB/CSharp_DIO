using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntendendoEstruturaDeUmProjeto.PessoaCopia // organização das classes
{
    public class Pessoa // Classe - usa PascalCase
    {
        public string Nome { get; set; } // propriedades também usam PascalCase
        public int Idade { get; set; }

        public void Apresentar() // Método
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos."); // console é uma Classe, WriteLine é um método
        }
    }
}