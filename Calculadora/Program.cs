double num1, num2;
int opcao = 0;

int Menu()
{
    Console.Clear();
    Console.WriteLine("1 - Somar");
    Console.WriteLine("2 - Subtrair");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    Console.WriteLine("5 - Sair");
    Console.WriteLine("Escolha uma opção: ");

    return int.Parse(Console.ReadLine());
}

void CalcularSoma()
{
    Console.WriteLine("A soma dos numeros é: " + (num1 + num2));
}

void CalcularSubtracao()
{
    Console.WriteLine("A subtração dos numeros é: " + (num1 - num2));
}

void CalcularMultiplicacao()
{
    Console.WriteLine("O produto dos numeros é: " + (num1 * num2));
}

void CalcularDivisao()
{
    if (num2 == 0)
        Console.WriteLine("Não e possivel dividir um numero por 0");
    else
        Console.WriteLine("A divisão dos numeros é: " + (num1 / num2));
}

Console.WriteLine("Informe o primeiro numero: ");
num1 = double.Parse(Console.ReadLine());

Console.WriteLine("Informe o segundo numero: ");
num2 = double.Parse(Console.ReadLine());

while (opcao != 5)
{
    opcao = Menu();

    switch (opcao)
    {
        default:
            Console.WriteLine("Opção inválida!");
            break;
        case 1:
            CalcularSoma();
            break;
        case 2:
            CalcularSubtracao();
            break;
        case 3:
            CalcularMultiplicacao();
            break;
        case 4:
            CalcularDivisao();
            break;
        case 5:
            Console.WriteLine("Até logo!");
            break;
    }

    Console.ReadLine();
}