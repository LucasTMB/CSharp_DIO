using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repeticao_CSharp.Models
{
    public class Tabuada
    {
        public void TabuadaFor(int n) {
            for (int i = 0 ; i <= 10 ; i++) {
                Console.WriteLine($"{n} x {i} = {n * i}");
            }
        }

        public void TabuadaWhile(int n) {
            int i = 0;

            while (i <= 10) {
                Console.WriteLine($"{n} x {i} = {n * i}");
                i++;
            }
        }

        public void TabuadaDoWhile (int n) {
            int i = 0;

            do {
                Console.WriteLine($"{n} x {i} = {n * i}");
                i++;
            } while (i <= 10);
        }
    }
}