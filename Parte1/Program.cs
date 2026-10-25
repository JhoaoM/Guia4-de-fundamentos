static string ExtraerSubcadena(string cadena, int inicio, int largo)
{
    return cadena.Substring(inicio, largo);
}

static int BuscarPalabra(string cadena, string palabra)
{
    return cadena.IndexOf(palabra);
}

static string ReemplazarPalabra(string cadena, string vieja, string nueva)
{
    return cadena.Replace(vieja, nueva);
}

Console.WriteLine("PARTE 1: CADENAS");
string texto = "C# es un lenguaje fácil de aprender y muy usado";
Console.WriteLine($"Texto original: {texto}");

string sub = ExtraerSubcadena(texto, 0, 2);
Console.WriteLine($"Subcadena (posición 0, largo 2): {sub}");

int posicion = BuscarPalabra(texto, "lenguaje");
Console.WriteLine($"La palabra 'lenguaje' empieza en la posición: {posicion}");

string textoNuevo = ReemplazarPalabra(texto, "fácil", "divertido");
Console.WriteLine($"Texto con reemplazo: {textoNuevo}");
