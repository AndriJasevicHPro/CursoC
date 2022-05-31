                                                //////////////////////////////////
                                                //             CLASE 9.2        //
                                                // ALUMNO:  ANDRIJASEVICH LEO   //
                                                // FECHA:   31/05/2022          //
                                                //////////////////////////////////



//Con los conocimientos vistos hasta ahora en clase realizar un programa que haga lo siguiente
//1)      Pedir al usuario la longitud de un vector
//2)      Crear el vector del tamaño ingresado.
//3)      Llenar el mismo con datos aleatorios
//4)      Mostrar el vector por pantalla
//5)      Invertir el vector, de manera que el primer elemento quede al último y el útimo en el primero; el segundo en anteúltimo,
//el anteúltimo en el segundo y así sucesivamente. En otra palabras si el vector es de 5 posiciones y el usuario ingresó: 10, 20, 30, 40, 50, una vez invertido,
//el vector debe quedar así: 50, 40, 30, 20, 10.Se debe usar solo lo visto en clase hasta ahora y no los métodos que trae C# para estas cuestiones.
//6)      Mostrar el vector nuevamente.

bool valid;
int tamanioo;
Console.ForegroundColor = ConsoleColor.Cyan;
string welcomeLogoAscii =
@"                                        
                            
                                ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄
                                ██░▄▄▀█▄░▄██░▄▄▄██░▀██░██░███░██░▄▄▄██░▀██░█▄░▄██░▄▄▀██░▄▄▄░██░▄▄▄░
                                ██░▄▄▀██░███░▄▄▄██░█░█░███░█░███░▄▄▄██░█░█░██░███░██░██░███░██▄▄▄▀▀
                                ██░▀▀░█▀░▀██░▀▀▀██░██▄░███▄▀▄███░▀▀▀██░██▄░█▀░▀██░▀▀░██░▀▀▀░██░▀▀▀░
                                ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
";
Console.WriteLine(welcomeLogoAscii);
Console.ResetColor();
do
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("▌║█║▌│║▌│║▌║▌█║INGRESA POR FAVOR LA LONGITUD ▌│║▌║▌│║║▌█║▌║█");
    valid = int.TryParse(Console.ReadLine(), out tamanioo);
    if (!valid || tamanioo <= 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(" ¡¡¡¡¡¡¡¡ PELIGROOOOOOOOOOOOOO  !!!!!!!!!!");
        Console.WriteLine("La longitud ingresada es incorrecta. Debe ser un numero entero positivo distintos de 0. \n Presione cualquier tecla para continuar");
        Console.ReadKey();
        Console.Clear();
    }

} while (!valid || tamanioo <= 0);


int[] vector2 = new int[tamanioo];

Random nuemeroAleatorio = new Random();

for (int i = 0; i < tamanioo; i++)
{
    vector2[i] = nuemeroAleatorio.Next(500);

    
}

Console.WriteLine("================================");
Console.WriteLine();
Console.WriteLine("▌║█║▌│║▌│║▌║▌█║EL VECTOR GENERADO ES ▌│║▌║▌│║║▌█║▌║█");
Console.WriteLine();
Console.WriteLine("================================");
foreach (var i in vector2)
{
    Console.WriteLine(i);

}

int auxiliar = 0;
int primerIndice = 0;		
int segundoIndice = tamanioo - 1;


while (primerIndice < segundoIndice)
{
    auxiliar = vector2[segundoIndice];
    vector2[segundoIndice] = vector2[primerIndice];
    vector2[primerIndice] = auxiliar;
    primerIndice++;
    segundoIndice--;
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("NÚMEROS DE VECTORES INVERTIDOS");
Console.WriteLine();




foreach (var i in vector2)
{
    Console.WriteLine(i);
}

string ElviejoSape =
    
@"                                        
                                                         ╔═╗           ╔╗               ╔╗    
                                                         ║╔╝           ║║               ║║    
                    ╔══╗╔═╗╔══╗╔══╗╔═╗╔══╗ ╔╗╔╗╔══╗     ╔╝╚╗╔╗╔═╗ ╔══╗ ║║ ╔╗╔═══╗╔══╗ ╔═╝║╔══╗
                    ║╔╗║║╔╝║╔╗║║╔╗║║╔╝╚ ╗║ ║╚╝║╚ ╗║     ╚╗╔╝╠╣║╔╗╗╚ ╗║ ║║ ╠╣╠══║║╚ ╗║ ║╔╗║║╔╗║
                    ║╚╝║║║ ║╚╝║║╚╝║║║ ║╚╝╚╗║║║║║╚╝╚╗     ║║ ║║║║║║║╚╝╚╗║╚╗║║║║══╣║╚╝╚╗║╚╝║║╚╝║
                    ║╔═╝╚╝ ╚══╝╚═╗║╚╝ ╚═══╝╚╩╩╝╚═══╝     ╚╝ ╚╝╚╝╚╝╚═══╝╚═╝╚╝╚═══╝╚═══╝╚══╝╚══╝
                    ║║         ╔═╝║                                                           
                    ╚╝         ╚══╝                                                           


";
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine(ElviejoSape);
Console.ResetColor();


