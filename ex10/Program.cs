int a, b, aux;
Console.WriteLine("--------------------");
Console.WriteLine("- Troca de Valores -");
Console.WriteLine("--------------------");
Console.Write("Digite o valor de A: ");
a = Convert.ToInt32(Console.ReadLine()); // 15
Console.Write("Digite o valor de B: ");
b = Convert.ToInt32(Console.ReadLine()); // 60 
aux = a; //15
a = b;   //60
b = aux; //15
Console.WriteLine($"\nO valor de A é {a}, o valor de B é {b}");

