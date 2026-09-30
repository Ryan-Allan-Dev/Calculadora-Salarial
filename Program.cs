double salario, salarioNovo, ferias, decimoTerceiro;
int opcao, meses;

do
{
    Console.WriteLine("================== Menu de opções ===================== \n Opções 1 -> Novo Salario \n Opções 2 -> Férias \n Opções 3 -> Décimo terceiro \n Opções 4 ->  Sair \n =========================================");
    Console.WriteLine("Digite uma Opções");

    opcao = int.Parse(Console.ReadLine());
    if(opcao < 1 || opcao > 4)
    {
        Console.WriteLine("\nOpção inválida! Digite um número de 1 a 4.\n");
    }
    if (opcao == 1)
    {
        Console.WriteLine("Digite o seu Salario: ");
        salario = double.Parse(Console.ReadLine());

        if (salario <= 350)
        {
            salarioNovo = salario + (salario * 0.15);
        }
        else if (salario >= 600)
        {
            salarioNovo = salario + (salario * 0.10);
        }
        else
        {
            salarioNovo = salario + (salario * 0.05);
        }
        Console.WriteLine($"Novo Salario e: {salarioNovo:F2}");
    }
    else if (opcao == 2)
    {
        Console.WriteLine("Digite o Seu Salario: ");
        salario = double.Parse(Console.ReadLine());
        ferias = salario + (salario / 3.0);
        Console.WriteLine($"Valor das férias: R$ {ferias:F2}");
    }
    else if (opcao == 3)
    {
        Console.WriteLine("Digite o seu Salario: ");
        salario = double.Parse(Console.ReadLine());

        Console.Write("Digite os meses trabalhados (máx 12): ");
        meses = int.Parse(Console.ReadLine());

        decimoTerceiro = (salario * meses) / 12.0;
        Console.WriteLine($"Valor do 13º: R$ {decimoTerceiro:F2}");
    }
    else if (opcao == 4)
    {
        Console.WriteLine("Saindo do programa...");
    }
} while (opcao != 4 );