using System;


namespace Ejercicio9
{
    class Program
    {

        static void Main(string[] args)
        {
            int filas = 3;
            int icolumnas = 9;
            int posicionFila = 0;
            int posicionColumna = 0;
            int decena = 0;
            int[,] miBingo = new int[filas, icolumnas];
            int[,] espaciosEnBlanco = new int[filas, icolumnas];
            Random numero = new Random();
            int numeroCarton = 1;



            Console.ForegroundColor = ConsoleColor.DarkCyan;
            string welcomeLogoAscii =
        @"              
                      $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$
                      $ ╔═══╗╔╗       ╔══╗ ╔══╗╔═╗ ╔╗╔═══╗╔═══╗    ╔╗   ╔═══╗╔═══╗╔═══╗ $
                      $ ║╔══╝║║       ║╔╗║ ╚╣╠╝║║╚╗║║║╔═╗║║╔═╗║    ║║   ║╔═╗║║╔═╗║║╔═╗║ $
                      $ ║╚══╗║║       ║╚╝╚╗ ║║ ║╔╗╚╝║║║ ╚╝║║ ║║    ║║   ║║ ║║║║ ╚╝║║ ║║ $
                      $ ║╔══╝║║ ╔╗    ║╔═╗║ ║║ ║║╚╗║║║║╔═╗║║ ║║    ║║ ╔╗║║ ║║║║ ╔╗║║ ║║ $
                      $ ║╚══╗║╚═╝║    ║╚═╝║╔╣╠╗║║ ║║║║╚╩═║║╚═╝║    ║╚═╝║║╚═╝║║╚═╝║║╚═╝║ $
                      $ ╚═══╝╚═══╝    ╚═══╝╚══╝╚╝ ╚═╝╚═══╝╚═══╝    ╚═══╝╚═══╝╚═══╝╚═══╝ $
                      $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$                                       
                                                               
";

            Console.WriteLine(welcomeLogoAscii);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼▼");
            Console.WriteLine("¿Desea generar un nuevo carton?");
            Console.WriteLine("▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲▲");
            Console.WriteLine("◄ S/N ►");
            Console.ForegroundColor = ConsoleColor.Green;
            string respuesta = Console.ReadLine();
            Console.Clear();



            while (respuesta.ToUpper() == "S")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                while (posicionColumna <= 7)

                {

                    int posicionAnterior = 0;
                    while (posicionFila <= 2)
                    {

                        miBingo[posicionFila, posicionColumna] = decena + (numero.Next(1, 10));

                        while (miBingo[posicionFila, posicionColumna] == posicionAnterior)
                        {
                            miBingo[posicionFila, posicionColumna] = decena + (numero.Next(1, 10));
                        }
                        posicionAnterior = miBingo[posicionFila, posicionColumna];
                        posicionFila++;
                    }
                    posicionColumna++;
                    posicionFila = 0;
                    decena = decena + 10;
                }
                decena = 0;

                if (posicionColumna == 8)

                {
                    int posicionAnterior = 0;
                    while (posicionFila <= 2)
                    {

                        miBingo[posicionFila, posicionColumna] = (numero.Next(80, 91));

                        while (miBingo[posicionFila, posicionColumna] == posicionAnterior)
                        {
                            miBingo[posicionFila, posicionColumna] = (numero.Next(80, 91));
                        }
                        posicionAnterior = miBingo[posicionFila, posicionColumna];
                        posicionFila++;
                    }
                }


                posicionFila = 0;
                int contadorCeros = 0;



                while (posicionFila <= 2)
                {
                    while (contadorCeros != 4)
                    {
                        contadorCeros = 0;
                        posicionColumna = 0;

                        while (posicionColumna <= 8)
                        {
                            espaciosEnBlanco[posicionFila, posicionColumna] = numero.Next(0, 2);
                            if (espaciosEnBlanco[posicionFila, posicionColumna] == 0)
                            {
                                contadorCeros++;
                            }
                            posicionColumna++;

                        }


                    }

                    contadorCeros = 0;
                    posicionFila++;

                }
                posicionFila = 0;
                posicionColumna = 0;


                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (espaciosEnBlanco[i, j] == 0)
                        {
                            miBingo[i, j] = 0;
                        }

                    }

                }

                //lo que se va a imprimir en pantalla

                Console.WriteLine("▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");
                Console.WriteLine(" " + "         █▓▒▒░░░  CARTON N° :  " + numeroCarton + "    ░░░▒▒▓█           ");
                Console.WriteLine("▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");

                for (int i = 0; i < 3; i++)
                {

                    for (int j = 0; j < 9; j++)
                    {
                        if (miBingo[i, j] == 0)
                        {
                            Console.Write("|    |");
                        }
                        else if (miBingo[i, j] < 10)

                        {
                            Console.Write($"| { miBingo[i, j]:00} |");
                        }
                        else
                        {
                            Console.Write($"| { miBingo[i, j]:00} |");
                        }


                    }
                    Console.WriteLine();
                    Console.WriteLine("--------------------------------------------------------");
                }

                numeroCarton++;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();


                Console.WriteLine("¿DESEA GENERAR OTRO CARTON? S/N");
                Console.ForegroundColor = ConsoleColor.Cyan;
                respuesta = Console.ReadLine();
            }

            if (respuesta.ToUpper() == "N")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("====================================================================");
                
                string welcomeLogoAsciis =
@"                                        
                 ░▒█▀▀▀░▀█▀░▒█▄░▒█░░░▒█▀▀▄░▒█▀▀▀░░░▒█░░░░█▀▀▄░░░░░░▒█░▒█░▒█░▒█▀▀█░█▀▀▄░▒█▀▀▄░█▀▀▄
                 ░▒█▀▀░░▒█░░▒█▒█▒█░░░▒█░▒█░▒█▀▀▀░░░▒█░░░▒█▄▄█░░░░░░▒█░▒█░▒█░▒█░▄▄▒█▄▄█░▒█░▒█▒█▄▄█
                 ░▒█░░░░▄█▄░▒█░░▀█░░░▒█▄▄█░▒█▄▄▄░░░▒█▄▄█▒█░▒█░░░▒█▄▄█░░▀▄▄▀░▒█▄▄▀▒█░▒█░▒█▄▄█▒█░▒█

";
                Console.WriteLine(welcomeLogoAsciis);
                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.WriteLine("====================================================================");

                Console.WriteLine("-- JUGAR COMPULSIVAMENTE ES PERJUDICIAL PARA LA SALUD  --");
                Console.WriteLine("-- SI NECESITA AYUDA COMUNICARSE AL: 0800-222-31234   --");



            }
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine();



        }

    }
}
