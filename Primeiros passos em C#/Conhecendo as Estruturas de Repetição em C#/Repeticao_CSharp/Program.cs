using Repeticao_CSharp.Models;

Tabuada tabuada = new Tabuada();

// tabuada.TabuadaFor(10);
// tabuada.TabuadaWhile(10);
// tabuada.TabuadaDoWhile(10);

Console.WriteLine("TABUADA C#\n");

bool condicao = false;
int n, opcao;

while (condicao != true) {
    
    Console.WriteLine("\n1. For");
    Console.WriteLine("2. While");
    Console.WriteLine("3. Do While");
    Console.WriteLine("4. Fechar programa");

    Console.Write("\nEscolha qual tipo de Estrutura de Repetição você deseja utilizar: ");
    opcao = Convert.ToInt32(Console.ReadLine());

    switch (opcao) {
        case 1:
            Console.Write("Insira um número: ");
            n = Convert.ToInt32(Console.ReadLine());
            tabuada.TabuadaFor(n);
            break;
        case 2:
            Console.Write("Insira um número: ");
            n = Convert.ToInt32(Console.ReadLine());
            tabuada.TabuadaWhile(n);
            break;
        case 3:
            Console.Write("Insira um número: ");
            n = Convert.ToInt32(Console.ReadLine());
            tabuada.TabuadaDoWhile(n);
            break;
        case 4:
            Console.WriteLine("\nEncerrando programa...");
            condicao = true;
            break;
        default:
            Console.WriteLine("Insira uma opção válida!");
            break;
    }

}