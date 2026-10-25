static void ListarUsuarios(Usuario[] usuarios)
{
    for (int i = 0; i < usuarios.Length; i++)
    {
        Console.WriteLine($"{usuarios[i].Nombre} | {usuarios[i].Email} | {usuarios[i].Ciudad}");
    }
}

Console.WriteLine("PARTE 3: ARREGLO DE OBJETOS");
Usuario[] usuarios = new Usuario[5];
usuarios[0] = new Usuario("Ana", "ana@correo.com", "Lima");
usuarios[1] = new Usuario("Luis", "luis@correo.com", "Cusco");
usuarios[2] = new Usuario("Carla", "carla@correo.com", "Lima");
usuarios[3] = new Usuario("Pedro", "pedro@correo.com", "Arequipa");
usuarios[4] = new Usuario("Beto", "beto@correo.com", "Cusco");

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
