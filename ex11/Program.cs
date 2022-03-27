double qtdTijolos, comprimentoTijolo, larguraTijolo, comprimentoParede, larguraParede;
Console.WriteLine("-------------------------");
Console.WriteLine("- Quantidade de Tijolos -");
Console.WriteLine("-------------------------");
Console.Write("Digite o comprimento de tijolo: ");
comprimentoTijolo = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite a largura do tijolo: ");
larguraTijolo = Convert.ToDouble(Console.ReadLine());
Console.Write("\nDigite o comprimento da Parede: ");
comprimentoParede = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite a largura da Parede: ");
larguraParede = Convert.ToDouble(Console.ReadLine());
qtdTijolos =   (comprimentoParede * larguraParede) / (comprimentoTijolo * larguraTijolo);
Console.WriteLine($"A quantidade de de tijolos necessaria é {Math.Round(qtdTijolos,2)}");

