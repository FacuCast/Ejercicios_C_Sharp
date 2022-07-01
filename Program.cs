using System;

namespace EjerciciosCShart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicios!";
            int opcion = 0;
            do
            {
                string title = "|  Ejercicios en C#!  |";
                string border = new string('-', title.Length);
                Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
                Console.WriteLine(border);
                Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
                Console.WriteLine(title);
                Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
                Console.WriteLine(border);

                Console.WriteLine(" 1)- Imprimir la secuencia de números PARES, entre un Límite ");
                Console.WriteLine(" Inferior (I) y un Límite Superior(S) Ingresados por teclado");
                Console.WriteLine("\n");

                Console.WriteLine(" 2)- Imprimir la secuencia de números IMPARES, entre un Límite Inferior (I) y ");
                Console.WriteLine(" un Límite  Superior(S) Ingresados por teclado.");
                Console.WriteLine("\n");

                Console.WriteLine(" 3)- Imprimir todos los múltiplos entre 0 y 100 de un número(X) ingresado ");
                Console.Write(" por teclado.");
                Console.WriteLine("\n");

                Console.WriteLine(" 4)- Imprimir la cantidad de múltiplos entre 0 y 100 de un número (X) ");
                Console.Write(" ingresado por teclado");
                Console.WriteLine("\n");

                Console.WriteLine(" 5)- Listar la tabla de multiplicar de un numero ingresado por teclado de ");
                Console.WriteLine(" forma que se visualice");
                Console.WriteLine("\n");

                Console.WriteLine(" 6)- Ingresar 2 números, imprimir los números que hay entre ambos empezando por");
                Console.WriteLine(" el más pequeño, contar cuántos números hay y cuántos de ellos son pares");
                Console.WriteLine("\n");

                Console.WriteLine(" 7)- Diseñar un algoritmo que calcule la longitud de la circunferencia y el área");
                Console.WriteLine(" del círculo de un radio ingresado por teclado.");
                Console.WriteLine("\n");

                Console.WriteLine(" 8)- Ingresar una frase no más de 20 caracteres y mostrar cuantas vocales tiene ");
                Console.WriteLine("\n");

                Console.WriteLine(" 0)- Salir del programa!");
                Console.WriteLine("\n");

                Console.Write("\n\t\t|Elija una opcion!|");
                Console.WriteLine("\n");
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    Console.WriteLine("\n");

                    int n1, n2 = 0;
                    Console.WriteLine("  1) Ingresa un numero de inicio!");
                    n1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("\n");

                    Console.WriteLine("  2) Ingresa el numero para finalizar!");
                    n2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("\n");


                    while (n1 < n2)
                    {
                        n1 += 1;

                        if (n1 % 2 == 0)
                        {
                            Console.WriteLine(" Los pares son: " + n1);
                            Console.WriteLine(" ------------------------------");


                        }
                    }
                }
                else if (opcion == 2)
                {
                    Console.WriteLine("\n");

                    Console.WriteLine(" dime un numero");
                    int n3 = int.Parse(Console.ReadLine());
                    Console.WriteLine("\n");

                    Console.WriteLine(" dime tu segundo numero");
                    int n4 = int.Parse(Console.ReadLine());
                    Console.WriteLine("\n");

                    while (n3 < n4)
                    {
                        n3 += 1;

                        if (n3 % 2 == 1)
                        {
                            Console.WriteLine(" Los impares son: " + n3);
                            Console.WriteLine(" ------------------------------");

                        }


                    }
                }
                else if (opcion == 3)
                {
                    int x = 0;
                    Console.WriteLine("\n");
                    Console.WriteLine(" ingresa un numero");
                    x = int.Parse(Console.ReadLine());
                    int n = 100;

                    for (int x1 = x; x1 <= n; x1++)
                    {

                        if (x1 % x == 0)
                            Console.WriteLine(" múltiplos entre 0 y 100 son : " + x1);
                        Console.WriteLine(" ------------------------------");


                    }

                }
                else if (opcion == 4)
                {
                    int x = 0;
                    Console.WriteLine("\n");
                    Console.WriteLine(" ingresa tu numero");
                    x = int.Parse(Console.ReadLine());
                    int n = 200;
                    int cantidad = 0;

                    for (int i1 = x; i1 <= n; i1++)
                    {

                        if (i1 % x == 0)
                        {
                            cantidad += 1;
                        }

                    }
                    Console.WriteLine(" ------------------------------");

                    Console.Write(" la cantidad de multiplos son: " + cantidad);
                }
                else if (opcion == 5)
                {
                    Console.WriteLine(" indica el numero que desees ver la tabla");

                    int n5 = int.Parse(Console.ReadLine());

                    TablaMultiplicar(n5);
                }
                else if (opcion == 6)
                {
                    Console.Write("\n");

                    Console.WriteLine("ingresa tu primer numero");

                    int n6 = int.Parse(Console.ReadLine());
                    Console.Write("\n");

                    Console.WriteLine("ingresa tu segundo numero");

                    int n7 = int.Parse(Console.ReadLine());
                    Console.Write("\n");

                    int pares = 0;
                    int num = 0;

                    if (n6 == n7)
                    {
                        Console.Write(" los numeros son iguales");
                    }
                    else
                    {
                        Console.Write(" Numeros entre: " + n6 + " hasta e incluso: " + n7);
                        Console.Write("\n");

                    }

                    while (n6 < n7)
                    {
                        num++;
                        if (n6 % 2 == 0)
                        {
                            pares += 1;

                        }
                        n6 += 1;

                        Console.Write("  " + n6 + " ");
                        Console.Write("\n");

                        Console.WriteLine(" ------------------------");
                        Console.Write("\n");

                    }

                    Console.Write(" Cantidad de pares: " + pares);

                }
                else if (opcion == 7)
                {
                    Console.Write("\n");

                    Console.Write(" Escriba un numero y va a Muestrar el radio");
                    Console.Write("\n");


                    Double radio = int.Parse(Console.ReadLine());

                    Double area = radio * radio * 3.1415;

                    Double cicunferencia = (2 * 3.14 * radio);
                    Console.Write("\n");

                    Console.Write(" Tu area es " + area + " y tu circunferencia es de " + cicunferencia);
                }
                else if (opcion == 8)
                {
                    Console.Write("\n");
                    Console.Write(" Dime tu frase no mas de 20 caracteres");
                    Console.Write("\n");


                    string palabra = Console.ReadLine();
                    int vocales = 0;

                    palabra = palabra.ToLower();

                    for (int i = 0; i < palabra.Length; i++)
                    {
                        switch (palabra[i])
                        {
                            case 'a':
                                vocales += 1;
                                break;
                            case 'e':
                                vocales += 1;
                                break;
                            case 'i':
                                vocales += 1;
                                break;
                            case 'o':
                                vocales += 1;
                                break;
                            case 'u':
                                vocales += 1;
                                break;
                        }
                    }
                    Console.Write("\n");
                    Console.Write(" La cantidad de vocales de la palabra es: " + palabra + " Es: " + vocales);                   
                }
                Console.ReadKey();

                Console.Clear();
            } while (opcion != 0);
        }
        static void TablaMultiplicar(int j)
        {
            Console.WriteLine("\n");

            Console.Write(" Tabla de multiplicar del " + j + "");
            Console.WriteLine("\n");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(" ------------------------------");
                Console.Write(" "+ j + "x " + i + "= " + j * i);
                Console.Write("\n");
            }

            Console.Write("\n");
        }
    }
}

