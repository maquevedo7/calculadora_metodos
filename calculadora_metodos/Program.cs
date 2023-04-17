using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora_metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Contamos con 4 posibles operaciones: \n 1. Suma \n 2. Resta \n 3. Multiplicación \n 4. División  \n 5. Elevar al cuadrado  \n 6. Raiz Cuadrada");
            Console.WriteLine("Por favor ingrese las operación que quiere, seleccionando el respectivo número del 1 al 4");
            Console.WriteLine(" ");
            int operation = int.Parse(Console.ReadLine());
            calcular(operation);

            //LLamar Operation
            //printMessage(0);

            //Imprimir un resultado
        }

        private static void calcular(int operation)
        {

            Console.Clear();
            switch (operation)
            {
                case 1:
                    {
                        Console.WriteLine("Suma");
                        Console.WriteLine("");
                        answer(operation);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Resta");
                        Console.WriteLine("");
                        answer(operation);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Multiplicación");
                        Console.WriteLine("");
                        answer(operation);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("División");
                        Console.WriteLine("");
                        answer(operation);
                        break;
                    }

                case 5:
                    {
                        Console.WriteLine("Elevar al cuadrado");
                        Console.WriteLine("");
                        answer(operation);
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Raíz cuadrada");
                        Console.WriteLine("");
                        answer(operation);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Operacion no asignada en la lista de opciones");
                        Console.ReadKey();
                        break;
                    }
            }

        }

        //Agregar metodo para imprimir el resultado

        private static void answer(int numOperacion)
        {
            Console.Write("Ingrese el primer número: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            int number2 = int.Parse(Console.ReadLine());

            if (numOperacion == 1)
            {
                double ans = number1 + number2;
                Console.WriteLine($"La suma es igual a: {ans}", number1, number2, ans);
            }
            if (numOperacion == 2)
            {
                double ans = number1 - number2;
                Console.WriteLine($"La resta es igual a: {ans}", number1, number2, ans);
            }
            if (numOperacion == 3)
            {
                double ans = number1 * number2;
                Console.WriteLine($"La multiplicación es igual a: {ans}", number1, number2, ans);
            }
            if (numOperacion == 4)
            {
                if (number2 == 0)
                {
                    Console.WriteLine("No se puede dividir entre {0}", number2);
                }
                else
                {
                    double ans = number1 / number2;
                    Console.WriteLine($"La división es igual a: {ans}", number1, number2, ans);
                }
            }
            if (numOperacion == 5)
            {
                double ans = number1 * number1;
                Console.WriteLine($"El cuadrado es igual a: {ans}", number1, number2, ans);
            }
            if (numOperacion == 6)
            {
                double ans = Math.Sqrt(number1);
                Console.WriteLine($"La raíz cuadrada es igual a: {ans}", number1, number2, ans);
            }
            Console.ReadKey();
        }
    
    }
}
