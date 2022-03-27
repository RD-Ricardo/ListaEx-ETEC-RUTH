double vlReal, vlDolar, cot;
Console.WriteLine("---------------------------------");
Console.WriteLine("- Calcular Valor dolar em real --");
Console.WriteLine("---------------------------------");
Console.Write("Digite o valor que possui no cofre em DOLAR $: ");
vlDolar = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite o valor da cotação do dolar atual: ");
cot = Convert.ToDouble(Console.ReadLine());
vlReal = vlDolar * cot;
Console.WriteLine($"\nVocê  tem R$ {vlReal}");

