static string ExtraerSubcadena(string cadena, int inicio, int largo)
{
    return cadena.Substring(inicio, largo);
}

Console.WriteLine("PARTE 1: CADENAS");
string texto = "C# es un lenguaje fácil de aprender y muy usado";
Console.WriteLine($"Texto original: {texto}");

string sub = ExtraerSubcadena(texto, 0, 2);
Console.WriteLine($"Subcadena (posición 0, largo 2): {sub}");
