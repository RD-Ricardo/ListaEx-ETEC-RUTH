double desconto, precoProduto, produtoPago;

Console.WriteLine("--------------------------------");
Console.WriteLine("- Valor monetario Produto Pago -");
Console.WriteLine("--------------------------------");
Console.Write("\nDigite o preço do produto: ");
precoProduto = Convert.ToDouble(Console.ReadLine());
Console.Write("\nDigite o valor do desconto: ");
desconto = Convert.ToDouble(Console.ReadLine());
produtoPago = precoProduto - ((precoProduto * desconto) / 100); 
Console.WriteLine($"O Valor do produto com desconto de {desconto}% é de {produtoPago}");
