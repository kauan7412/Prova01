using System;

namespace Prova01.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcao;
            do
            {
                Console.WriteLine("Identificador de triangulos");
                Console.WriteLine("Digite 1 para continuar");
                Console.WriteLine("Digite S para sair");
                opcao = Console.ReadLine();
                if (opcao == "S")
                    break;
                if (opcao == "1" || opcao == "S")
                {
                    Console.WriteLine("digite o valor do x triangulo");
                    double valor1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("digite o valor do y triangulo");
                    double valor2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("digite o valor do z triangulo");
                    double valor3 = Convert.ToDouble(Console.ReadLine());
                    if (valor1 < valor2 + valor3 && valor2 < valor1 + valor3 && valor3 < valor1 + valor2)
                    {
                        if (valor1 == valor2 && valor2 == valor3)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("seu triangulo é um triangulo Eqüilátero");
                            Console.ResetColor();
                            Console.ReadLine();
                        }
                        else if (valor1 == valor2 && valor2 != valor3 || valor1 == valor3 && valor1 != valor2 || valor2 == valor3 && valor3 != valor1)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("seu triangulo é um triangulo Isósceles");
                            Console.ResetColor();
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("seu triangulo é um triangulo Escaleno");
                            Console.ResetColor();
                            Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("seu triangulo é invalido");
                        Console.ResetColor();
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("esta tecla não se encontra no menu, digite novamente");
                    Console.ResetColor();
                    Console.ReadLine();
                }           
            }
            while (opcao != "s");
        }
    }
}
