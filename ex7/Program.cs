double raio, volume;
Console.WriteLine("-----------------------------");
Console.WriteLine("- Calcular Volume da Esfera -");
Console.WriteLine("-----------------------------");
Console.Write("\nDigite o raio da esfera: ");
raio = Convert.ToDouble(Console.ReadLine());
volume = 3.14 * Math.Pow(raio, 2);
Console.WriteLine($"o volume da esfera é de {volume}");