double desconto, precoProduto;

Console.WriteLine("-------------------");
Console.WriteLine("- Valor monetario -");
Console.WriteLine("-------------------");
Console.Write("\nDigite o preço do produto: ");
precoProduto = Convert.ToDouble(Console.ReadLine());
desconto = precoProduto - (precoProduto * 5) /100;
Console.WriteLine($"O Valor do produto com desconto de 5% é de {desconto}");


