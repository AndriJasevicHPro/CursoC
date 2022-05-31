//////////////////////////////////
//             CLASE 7           //
// ALUMNO:  ANDRIJASEVICH LEO   //
// FECHA:   25/05/2022          //
//////////////////////////////////

string welcomeLogoAscii =
@"                                        
                  ░▒█▀▀▄░▀█▀░▒█▀▀▀░▒█▄░▒█░▒█░░▒█░▒█▀▀▀░▒█▄░▒█░▀█▀░▒█▀▀▄░▒█▀▀▀█
                  ░▒█▀▀▄░▒█░░▒█▀▀▀░▒█▒█▒█░░▒█▒█░░▒█▀▀▀░▒█▒█▒█░▒█░░▒█░▒█░▒█░░▒█
                  ░▒█▄▄█░▄█▄░▒█▄▄▄░▒█░░▀█░░░▀▄▀░░▒█▄▄▄░▒█░░▀█░▄█▄░▒█▄▄█░▒█▄▄▄█
   
";
Console.WriteLine(welcomeLogoAscii);
Console.ResetColor();
bool valid;
Console.WriteLine("      INGRESE 10 NÚMEROS           ");

int[] numero = new int[10];//El 10 indica la cantidad de elementos

for (int i = 0; i < numero.Length; i++)
{
    Console.WriteLine($"Ingrese el valor: {i + 1}");
    valid = int.TryParse(Console.ReadLine(), out numero[i]);

    if (valid == false || numero[i] < 0)
    {
        Console.WriteLine("Debe ingresar un valor numérico. \nPresione cualquier tecla para Continuar");
        Console.ReadKey();
        i--;
    }
}





Console.WriteLine("La suma de los diez números es: ");

double suma = 0;

//Esto es hace la sumatoría de los diez números ingresados
for (int i = 0; i < numero.Length; i++)
{
    suma = suma + numero[i];

}
Console.WriteLine(suma);


//Obtener el mayor


int numeroMaximo = numero[0];
for (int i = 0; i < numero.Length; i++)
{
    if (numeroMaximo < numero[i])
    {
        numeroMaximo = numero[i];
    }
}
Console.WriteLine("El número máximo es: " + numeroMaximo);

//Obtener el menor
int numeroMinimo = numero[0];
for (int i = 0; i < numero.Length; i++)
{
    if (numeroMinimo > numero[i])
    {
        numeroMinimo = numero[i];
    }
}
Console.WriteLine("El número minimo es: " + numeroMinimo);

double promedio = suma / numero.Length;
Console.WriteLine("El promedio total es: " + promedio);


for (int i = 0; i < numero.Length; i++)
{
    Console.WriteLine(numero[i]);
}


string welcomeLogoAsciis =
@"                                        
                 ░█▀▀░░▀░░█▀▀▄░░░█▀▄░█▀▀░█░░░░▄▀▀▄░█▀▀▄░▄▀▀▄░█▀▀▀░█▀▀▄░█▀▀▄░█▀▄▀█░█▀▀▄
                 ░█▀░░░█▀░█░▒█░░░█░█░█▀▀░█░░░░█▄▄█░█▄▄▀░█░░█░█░▀▄░█▄▄▀░█▄▄█░█░▀░█░█▄▄█
                 ░▀░░░▀▀▀░▀░░▀░░░▀▀░░▀▀▀░▀▀░░░█░░░░▀░▀▀░░▀▀░░▀▀▀▀░▀░▀▀░▀░░▀░▀░░▒▀░▀░░▀


";
Console.WriteLine(welcomeLogoAsciis);
Console.ResetColor();
