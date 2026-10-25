static void ListarUsuarios(Usuario[] usuarios)
{
    for (int i = 0; i < usuarios.Length; i++)
    {
        Console.WriteLine($"{usuarios[i].Nombre} | {usuarios[i].Email} | {usuarios[i].Ciudad}");
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
