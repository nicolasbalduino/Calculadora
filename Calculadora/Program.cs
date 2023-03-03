float n1, n2;

Console.WriteLine("Dgite o primeiro numero: ");
n1 = float.Parse(Console.ReadLine());

Console.WriteLine("Dgite o primeiro numero: ");
n2 = float.Parse(Console.ReadLine());

Console.WriteLine("A soma é igual a " + (n1 + n2));
Console.WriteLine("A subtracao é igual a " + (n1 - n2));
Console.WriteLine("A multiplicacao é igual a " + (n1 * n2));

if (n2 == 0)
    Console.WriteLine("Impossivel dividir por ZERO!");
else
    Console.WriteLine("A dvisao é igual a " + (n1 / n2));