int[] arrayInteiros = new int[3]; // definindo o tamanho do array em 3 itens

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;
// arrayInteiros[3] = 1 // vai quebrar, pois é acima do tamanho definido

for(int contador = 0; contador < arrayInteiros.Length; contador++) {
    Console.WriteLine($"Posição N° {contador} - {arrayInteiros[contador]}");
}
