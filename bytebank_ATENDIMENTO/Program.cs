using System.Transactions;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");
//array
percorreArray();

void percorreArray()
{
    int[] idades = new int[5];
    idades[0] = 30;
    idades[1] = 40;
    idades[2] = 17;
    idades[3] = 21;
    idades[4] = 18;

    Console.WriteLine($"Tamanho do Array {idades.Length}");

    int totalIdades = 0;

    for(int i = 0; i < idades.Length; i++)
    {
        int idade = idades[i];
        Console.WriteLine($"Índice [{i}] = {idades[i]}");
        totalIdades+=idades[i];   
    }
    double mediaIdades = (double)totalIdades / idades.Length;
    Console.WriteLine($"A média das idades é {mediaIdades:F2}");

}
