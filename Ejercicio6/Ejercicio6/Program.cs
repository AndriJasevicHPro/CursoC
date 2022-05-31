using System;

namespace Ejercicio6
{

    //////////////////////////////////
    //      CLASE 6 - TAREA 2       //
    // ALUMNO:  ANDRIJASEVICH LEO   //
    // FECHA:   15/05/2022          //
    //////////////////////////////////
    class program
    {

        static void Main(String[] args)
        {
            Random numero = new Random();

            int aleatorio = numero.Next(0, 20);

            int minumero;

            int intentos = 0;

            string welcomeLogoAscii =
           @"                                        
                                      _ _
                                 _(,_/ \ \____________
                                 |`. \_@_@   `.     ,'
                                 |\ \ .        `-,-'
                                 || |  `-.____,-'
                                 || /  /
                                 |/ |  |
                            `..     /   \
                              \\   /    |
                              ||  |      \
                               \\ /-.    |
                               ||/  /_   |
                               \(_____)-'_)                            
                  BIENVENIDO AL JUEGO DEL NÚMERO SECRETO!!           
                                              
";
            Console.WriteLine(welcomeLogoAscii);
            Console.ResetColor();
            int secretNumber = new Random(DateTime.Now.Millisecond).Next(1, 21);
            do
            {


                Console.WriteLine("Introduce un n° entre 0 y 20");

                intentos++;

                try
                {
                    minumero = int.Parse(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("El programa no toma valores de texto, solo númericos");
                    minumero = 0;
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("El programa no toma valores muy alto, por favor introducir entre el 0 y 20");
                    minumero = 0;
                }


                if (minumero > aleatorio) Console.WriteLine("El número es mas bajo");



                if (minumero < aleatorio) Console.WriteLine("El número es más alto");




            } while (aleatorio != minumero);



            string winMessageAscii =
     @"
                             ▄▀▀ ▄▀▄ █▄░█ ▄▀▄ ▄▀▀ ▀█▀ █▀▀ █ █
                             █░█ █▄█ █▀██ █▄█ ░▀▄ ░█░ █▀▀ ▀ ▀
                             ░▀▀ ▀░▀ ▀░░▀ ▀░▀ ▀▀░ ░▀░ ▀▀▀ ▀ ▀
    ";
            Console.WriteLine($"Felicitaciones!!! la cantidad de  intentos fueron {intentos}");
            Console.WriteLine("Juego finalizado");
            Console.Write(winMessageAscii);

        }
    }
}