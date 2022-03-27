double largura, comprimento , area;

Console.WriteLine("-----------------");
Console.WriteLine("- Calcular Área -");
Console.WriteLine("-----------------");
Console.Write("\nDigite a largura da sala: ");
largura = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite o comprimentro da sala: ");
comprimento = Convert.ToDouble(Console.ReadLine());
area = largura * comprimento;
Console.WriteLine($"\nA área da sala é {area}");
