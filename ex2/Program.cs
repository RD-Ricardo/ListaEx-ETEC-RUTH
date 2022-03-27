double largura, comprimento , area, perimetro;

Console.WriteLine("-----------------");
Console.WriteLine("- Calcular Área e Perimetro-");
Console.WriteLine("-----------------");
Console.Write("\nDigite a largura: ");
largura = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite o comprimentro: ");
comprimento = Convert.ToDouble(Console.ReadLine());
area = largura * comprimento;
perimetro = (largura*2) + (comprimento*2);
Console.WriteLine($"\nA área da sala é {area} e o perimentro é {perimetro}");
