using System;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {

                string opcao;

                do
                {
                    Console.WriteLine("Digite 1 para verificar");

                    Console.WriteLine("Digite S para sair");

                    opcao = Console.ReadLine();

                    if (opcao == "s")
                        break;

                    else if (opcao != "1")
                        continue;

                    Console.WriteLine("digite a medida x: ");
                    double x = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("digite a medida y: ");
                    double y = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("digite a medida z: ");
                    double z = Convert.ToDouble(Console.ReadLine());

                    if (x > y + z || y > x + z || z > x + y) // Verificação condição de existencia do triângulo
                    {
                        Console.WriteLine("inválido");
                    }
                    else
                    {
                        if (x == y && x == z)
                            Console.WriteLine("Triangulo equilatero");

                        else if (x != y && x != z && y != z)
                            Console.WriteLine("Triangulo escaleno");

                        else Console.WriteLine("Triangulo isósceles");
                    }
                }
                while (opcao == "1");


            }
        }
    }
}