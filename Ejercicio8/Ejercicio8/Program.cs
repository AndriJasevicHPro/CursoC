//////////////////////////////////
//      CLASE 8 - TAREA 4       //
// ALUMNO:  ANDRIJASEVICH LEO   //
// FECHA:   25/05/2022          //
//////////////////////////////////
using System;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {

            string welcomeLogoAscii =
           @"                                        
                                         .--'''''''''--.
                                     .'      .---.      '.
                                    /    .-----------.    \
                                   /        .-----.        \
                                   |       .-.   .-.       |
                                   |      /   \ /   \      |
                                    \    | .-. | .-. |    /
                                     '-._| | | | | | |_.-'
                                         | '-' | '-' |
                                          \___/ \___/
                                       _.-'  /   \  `-._
                                     .' _.--|     |--._ '.
                                     ' _...-|     |-..._ '
                                            |     |
                                            '.___.'
                                              
";
            Console.WriteLine(welcomeLogoAscii);
            Console.WriteLine("===================================");
            Console.WriteLine("        COLUMNAS Y FILAS           ");
            Console.WriteLine("Ingrese la cantidad de columnas:   ");
            Console.WriteLine("===================================");

            int columnas = int.Parse(Console.ReadLine());

            Console.WriteLine("===========================================");
            Console.WriteLine("Ingrese la cantidad de filas por columnas: ");
            Console.WriteLine("===========================================");

            int filas = int.Parse(Console.ReadLine());

            int[,] numeros = new int[filas, columnas];

            int lengthFilas = numeros.GetUpperBound(0) + 1;

            int lengthColumnas = numeros.GetUpperBound(1) + 1;

            double[] promedio = new double[lengthColumnas];

            for (int i = 0; i < lengthColumnas; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Numeros de la columna {i + 1}: ");
                double acuNumFilas = 0;
                for (int j = 0; j < lengthFilas; j++)
                {
                    Console.WriteLine($"Cargue el numero Nº{j + 1}:");
                    numeros[j, i] = int.Parse(Console.ReadLine());
                    acuNumFilas += numeros[j, i];
                }
                promedio[i] = acuNumFilas /= numeros.GetLength(0);
            }

            for (int i = 0; i < lengthColumnas; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Los números de la columna son: {i + 1}: ");

                for (int j = 0; j < lengthFilas; j++)
                {
                    Console.WriteLine($"El numero Nº {j + 1} es: {numeros[j,i]}");
                }
            }
              
                    Console.WriteLine("Los promedios de las respectivas columnas son: ");

            string welcomeLogoAsciis =
@"                                        
                                                             ░▀█▀░█▄█▒██▀░░▒██▀░█▄░█░█▀▄░░
                                                             ░▒█▒▒█▒█░█▄▄▒░░█▄▄░█▒▀█▒█▄▀▒░

";
            Console.WriteLine(welcomeLogoAsciis);
            Console.ResetColor();
            for (int i = 0; i < promedio.Length; i++)
                {
                Console.WriteLine(promedio[i]);
                }
                Console.ReadKey();
        }

     }
}


