int filas = 3;
int columnas = 9;
int espaciosBlanco = 99;


Random random = new Random();

int [,] cartonBingo = new int[filas,columnas];

for (int iColumna = 0; iColumna < columnas; iColumna++)
{
    int filaRandon = random.Next(0, filas);
    int espacioEnBlancoEnLaFila = 0;
    for (int jColumna = 0; jColumna < columnas; jColumna++)
    {
        if (cartonBingo[filaRandon,jColumna] == espaciosBlanco)
        {
            espacioEnBlancoEnLaFila++;
        } 
    }

    if (espacioEnBlancoEnLaFila < 4)
    {
        cartonBingo[filaRandon, iColumna] = espaciosBlanco;
    }
    else
    {
        iColumna--;
    }
}

for (int iFilas = 0; iFilas < filas; iFilas++)
{
    for (int iColumna = 0; iColumna < columnas; iColumna++)
    {
        Console.Write(cartonBingo[iFilas,iColumna] + " " );
    }
        Console.WriteLine();
}

//Matriz2d[F,C]

