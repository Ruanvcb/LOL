// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite seu nome:");
        string nome = Console.ReadLine();

        Console.WriteLine("Olá " + nome);

        Console.WriteLine(); // linha em branco; <br> não funciona

        Console.WriteLine("Escolha uma posição para jogar:");
        Console.WriteLine();
        
        Console.WriteLine("Escolha 1: TOP");
        Console.WriteLine("Escolha 2: MID");
        Console.WriteLine("Escolha 3: JG");
        Console.WriteLine("Escolha 4: ADC");
        Console.WriteLine("Escolha 5: SUPPORT");

        int escolha = int.Parse(Console.ReadLine());

        Console.WriteLine();

        switch (escolha)
        {
            case 1:
                Console.WriteLine("Você escolheu jogar no TOP.");
                Console.WriteLine("Estes são os campeões recomendados: Aatrox, Irelia, Yorick, Darius, Garen.");

                Console.WriteLine();

                Console.WriteLine("Escolha um campeão da lista:");
                string campeaoEscolhido = Console.ReadLine();
                Console.WriteLine("Você escolheu jogar com o campeão: " + campeaoEscolhido);

                break;

            case 2:
                Console.WriteLine("Você escolheu jogar no MID.");

                break;

            case 3:
                Console.WriteLine("Você escolheu jogar no JG.");

                break;

            case 4:
                Console.WriteLine("Você escolheu jogar no ADC.");

                break;

            case 5:
                Console.WriteLine("Você escolheu jogar no SUPPORT.");

                break;

            default:
                Console.WriteLine("Escolha inválida.");
                break;
        }

        Console.ReadLine(); 
    }
}

