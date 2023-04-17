using System;
using System.Globalization;
using System.Runtime.InteropServices;

internal class Program
{
    static int Main(string[] args)
    {
        double resultado;
        int y;
        int x;
        char cont = 's';

        Console.WriteLine();
        Console.WriteLine("Qual operação matemática você gostaria de fazer?");
        Console.WriteLine("1. Adição;");
        Console.WriteLine("2. Subtração;");
        Console.WriteLine("3. Divisão;");
        Console.WriteLine("4. Multiplicação;");
        Console.WriteLine("5. Porcentagem;");

        while (cont == 's' || cont == 'S')
        {
            Console.Write("Digite aqui o número da Operação: ");
            int op = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (op)
            {
                case 1:
                    Console.WriteLine("Ok, você escolheu adição.");
                    Console.WriteLine("Agora vamos decidir os valores da operação!");
                    Console.Write("Digite o Valor de X: ");
                    x = int.Parse(Console.ReadLine());
                    Console.Write("Digite o Valor de Y: ");
                    y = int.Parse(Console.ReadLine());
                    resultado = x + y;
                    Console.WriteLine("O valor da operação é: " + resultado);
                    break;
                case 2:
                    Console.WriteLine("Ok, você escolheu subtração.");
                    Console.WriteLine("Agora vamos decidir os valores da operação!");
                    Console.Write("Digite o Valor de X: ");
                    x = int.Parse(Console.ReadLine());
                    Console.Write("Digite o Valor de Y: ");
                    y = int.Parse(Console.ReadLine());
                    resultado = x - y;
                    Console.WriteLine("O valor da operação é: " + resultado);
                    break;
                case 3:
                    Console.WriteLine("Ok, você escolheu divisão.");
                    Console.WriteLine("Agora vamos decidir os valores da operação!");
                    Console.Write("Digite o Valor de X: ");
                    x = int.Parse(Console.ReadLine());
                    Console.Write("Digite o Valor de Y: ");
                    y = int.Parse(Console.ReadLine());
                    resultado = (double)x / y;
                    Console.WriteLine("O valor da operação é: " + resultado.ToString("F2"));
                    break;
                case 4:
                    Console.WriteLine("Ok, você escolheu multiplicação.");
                    Console.WriteLine("Agora vamos decidir os valores da operação!");
                    Console.Write("Digite o Valor de X: ");
                    x = int.Parse(Console.ReadLine());
                    Console.Write("Digite o Valor de Y: ");
                    y = int.Parse(Console.ReadLine());
                    resultado = x * y;
                    Console.WriteLine("O valor da operação é: " + resultado);
                    break;
                case 5:
                    Console.WriteLine("Ok, você escolheu porcentagem.");
                    Console.WriteLine("Agora vamos decidir os valores da operação!");
                    Console.Write("Digite o Valor de X: ");
                    x = int.Parse(Console.ReadLine());
                    Console.Write("Digite o Valor de Y: ");
                    y = int.Parse(Console.ReadLine());
                    resultado = ((double)x/100) * (double)y;
                    Console.WriteLine("O valor da operação é: " + resultado.ToString("F2"));
                    break;
            }

            Console.WriteLine("Gostaria de continuar a fazer operações matemáticas? S/N");
            cont = char.Parse(Console.ReadLine());
        }

        return 0;
    }
}
