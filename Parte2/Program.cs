static void ImprimirParalelos(string[] nombres, int[] edades)
{
    for (int i = 0; i < nombres.Length; i++)
    {
        Console.WriteLine($"{nombres[i]} -> {edades[i]} años");
    }
}

static int BuscarEdad(string[] nombres, int[] edades, string buscado)
{
    for (int i = 0; i < nombres.Length; i++)
    {
        if (nombres[i].ToLower() == buscado.ToLower())
        {
            return edades[i];
        }
    }
    return -1;
}

Console.WriteLine("PARTE 2: ARREGLOS PARALELOS");
string[] listaNombres = { "Ana", "Luis", "Carla", "Pedro" };
int[] listaEdades = { 20, 25, 19, 30 };

ImprimirParalelos(listaNombres, listaEdades);

Console.Write("\nEscribe el nombre a buscar: ");
string buscado = Console.ReadLine();
int edad = BuscarEdad(listaNombres, listaEdades, buscado);

if (edad == -1)
{
    Console.WriteLine("No se encontró a esa persona");
}
else
{
    Console.WriteLine($"{buscado} tiene {edad} años");
}
