using EntendendoEstruturaDeUmProjeto.Models;

// ----- Introdução a condicionais -----

int quantidadeEmEstoque = 10;
int quantidadeCompra = 4;
bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;

Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
Console.WriteLine($"É possível realizar a venda?: {possivelVenda}");

if (quantidadeEmEstoque >= quantidadeCompra)
{
    Console.WriteLine("Venda realizada!");
}
else
{
    Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");
}





// ----- Conversão do tipo de variáveis (Cast - Casting) -----

// int a = Convert.ToInt32("5");
// int b = int.Parse("5");

// Console.WriteLine(a);
// Console.WriteLine(b);

// int c1 = Convert.ToInt32(null); // 0
// int c2 = int.Parse(null); // error

// int inteiro = 5;
// string a = inteiro.ToString();
// Console.WriteLine(a);

// ----- Convertendo de maneira segura (TryParse) -----

// string a = "15-"; 
// int b = 0; 

// int.TryParse(a, out b); // Se a conversão funcionar, o b recebe o valor de a. Se for inválida, ele permanece com o valor original.
// Console.WriteLine(b);
// Console.WriteLine("Conversão realizada com sucesso!");





// ----- Utilizando datas -----

// DateTime dataAtual = DateTime.Now;
// DateTime dataDaquiCincoDias = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual);
// Console.WriteLine(dataDaquiCincoDias.ToString("dd/MM/yyyy"));





// ----- Tipos de variáveis -----

// string apresentacao = "Olá, seja bem-vindo!";

// int quantidade = 1;
// quantidade = 10;

// double altura = 1.80;

// decimal preco = 1.80M; // se o valor for direto, é necessário usar o M. Decimal é usado para representar valores monetários.

// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variável quantidade: " + quantidade);
// Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
// Console.WriteLine("Valor da variável preco: " + preco); // decimal sempre terá duas casas decimais
// Console.WriteLine("Valor da variável condicao: " + condicao);





// ----- Utilização da Classe -----

// Pessoa p = new Pessoa(); // variáveis usam camelCase

// p.Nome = "Lucas";
// p.Idade = 26;
// p.Apresentar();