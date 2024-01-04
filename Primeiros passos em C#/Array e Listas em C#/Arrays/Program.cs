// ----- ARRAYS -----

int[] arrayInteiros = new int[3]; // definindo o tamanho do array em 3 itens

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;
// arrayInteiros[3] = 1 // vai quebrar, pois é acima do tamanho definido

// Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2); // dobrando o tamanho do array

int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

Console.WriteLine("percorrendo o array com o FOR");
for(int contador = 0; contador < arrayInteiros.Length; contador++) {
    Console.WriteLine($"Posição N° {contador} - {arrayInteiros[contador]}");
}

Console.WriteLine("Percorrendo o Array com o FOREACH");
foreach(int valor in arrayInteiros) {
    Console.WriteLine(valor);
}

// ----- LIST -----

List<string> listaString = new List<string>();
listaString.Add("SP");
listaString.Add("PE");
listaString.Add("MG");

Console.WriteLine("Percorrendo a lista com FOR");
for(int contador = 0 ; contador < listaString.Count ; contador++) {
    Console.WriteLine($"Posição n° {contador} - {listaString[contador]}");
}

Console.WriteLine("Percorrendo a lista com FOREACH");

foreach(string estados in listaString) {
    Console.WriteLine(estados);
}