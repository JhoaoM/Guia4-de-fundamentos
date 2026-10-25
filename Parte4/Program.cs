static void ListarUsuarios(Usuario[] usuarios)
{
    for (int i = 0; i < usuarios.Length; i++)
    {
        Console.WriteLine($"{usuarios[i].Nombre} | {usuarios[i].Email} | {usuarios[i].Ciudad}");
    }
}

static void OrdenarPorNombre(Usuario[] usuarios)
{
    int n = usuarios.Length;
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < n - 1 - i; j++)
        {
            if (string.Compare(usuarios[j].Nombre, usuarios[j + 1].Nombre, true) > 0)
            {
                Usuario temporal = usuarios[j];
                usuarios[j] = usuarios[j + 1];
                usuarios[j + 1] = temporal;
            }
        }
    }
}

Console.WriteLine("PARTE 4: ORDENAMIENTO ALFABÉTICO");
Usuario[] usuarios = new Usuario[5];
usuarios[0] = new Usuario("Pedro", "pedro@gmail.com", "Arequipa");
usuarios[1] = new Usuario("Luis", "luis@gmail.com", "Cusco");
usuarios[2] = new Usuario("Carla", "carla@gmail.com", "Lima");
usuarios[3] = new Usuario("Beto", "beto@gmail.com", "Cusco");
usuarios[4] = new Usuario("Ana", "ana@gmail.com", "Lima");

Console.WriteLine("Antes de ordenar:");
ListarUsuarios(usuarios);

OrdenarPorNombre(usuarios);

Console.WriteLine("\nDespués de ordenar:");
ListarUsuarios(usuarios);

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
