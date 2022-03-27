double anoNascimento,anoAtual, idade;
Console.WriteLine("------------------");
Console.WriteLine("- Calcular Idade -");
Console.WriteLine("------------------");
Console.Write("\nDigite o ano de nascimento: ");
anoNascimento  = Convert.ToDouble(Console.ReadLine());
Console.Write("\nDigite o ano de atual: ");
anoAtual  = Convert.ToDouble(Console.ReadLine());
idade = anoAtual - anoNascimento ;
Console.WriteLine($"Sua idade é: {idade}");


