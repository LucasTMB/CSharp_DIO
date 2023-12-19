using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntendendoEstruturaDeUmProjeto.Models // organização das classes
{
    public class Pessoa // Classe
    {
        public string Nome { get; set; } // Propriedades
        public int Idade { get; set; }

        public void Apresentar() // Método
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos."); // console é uma Classe, WriteLine é um método
        }
    }
}