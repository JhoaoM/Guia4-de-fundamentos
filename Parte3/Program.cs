static void ListarUsuarios(Usuario[] usuarios)
{
    for (int i = 0; i < usuarios.Length; i++)
    {
        Console.WriteLine($"{usuarios[i].Nombre} | {usuarios[i].Email} | {usuarios[i].Ciudad}");
    }
}

static int BuscarPorCiudad(Usuario[] usuarios, string ciudad)
{
    int contador = 0;
    for (int i = 0; i < usuarios.Length; i++)
    {
        if (usuarios[i].Ciudad.ToLower() == ciudad.ToLower())
        {
            Console.WriteLine($"- {usuarios[i].Nombre} ({usuarios[i].Email})");
            contador++;
        }
    }
    return contador;
}

Console.WriteLine("PARTE 3: ARREGLO DE OBJETOS");
Usuario[] usuarios = new Usuario[5];
usuarios[0] = new Usuario("Ana", "ana@gmail.com", "Lima");
usuarios[1] = new Usuario("Luis", "luis@gmail.com", "Cusco");
usuarios[2] = new Usuario("Carla", "carla@gmail.com", "Lima");
usuarios[3] = new Usuario("Pedro", "pedro@gmail.com", "Arequipa");
usuarios[4] = new Usuario("Beto", "beto@gmail.com", "Cusco");

ListarUsuarios(usuarios);

Console.Write("\nEscribe la ciudad a buscar: ");
string ciudad = Console.ReadLine();
Console.WriteLine($"Usuarios en {ciudad}:");
int encontrados = BuscarPorCiudad(usuarios, ciudad);

if (encontrados == 0)
{
    Console.WriteLine("No hay usuarios en esa ciudad");
}

class Usuario
{
    public string Nombre;
    public string Email;
    public string Ciudad;

    public Usuario(string nombre, string email, string ciudad)
    {
        Nombre = nombre;
        Email = email;
        Ciudad = ciudad;
    }
}
