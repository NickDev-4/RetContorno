Console.Clear();

int altura, largura;

Console.Write("Digite o tamanho da altura: ");
altura = int.Parse(Console.ReadLine());

Console.Write("Digite o tamanho da largura: ");
largura = int.Parse(Console.ReadLine());

Console.WriteLine();

for (int y = 0; y < altura; y++) {
    for (int x = 0; x < largura; x++) {
        if (y == 0 || y == altura - 1 || x == 0 || x == largura - 1) {
            Console.Write("*");
        }
        else {
            Console.Write(" ");
        }
    }
    
    Console.WriteLine();
}