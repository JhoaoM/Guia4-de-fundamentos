static void ImprimirParalelos(string[] nombres, int[] edades)
{
    for (int i = 0; i < nombres.Length; i++)
    {
        Console.WriteLine($"{nombres[i]} -> {edades[i]} años");
    }
}

Console.WriteLine("PARTE 2: ARREGLOS PARALELOS");
string[] listaNombres = { "Ana", "Luis", "Carla", "Pedro" };
int[] listaEdades = { 20, 25, 19, 30 };

ImprimirParalelos(listaNombres, listaEdades);
