Alumno federico = new Alumno("Federico Riesgo", 1515151515, "Calle falsa 123", "lalalala@lalala.com", false);
Console.WriteLine(federico);
public struct Alumno
{
    public Alumno(string nombreCompleto, int telefono, string direccion, string email, Boolean nuevoCliente)
    {
        NombreCompleto = nombreCompleto;
        Telefono = telefono;
        Direccion = direccion;
        Email = email;
        NuevoCliente = nuevoCliente;
    }

    public string NombreCompleto { get; private set; }
    public int Telefono { get; private set; }
    public string Direccion { get; private set; }
    public string Email { get; private set; }
    public Boolean NuevoCliente { get; private set; }

    public override string ToString() => $"Nombre: {NombreCompleto}, Teléfono: {Telefono}, Dirección: {Direccion}, Email:{Email}, Es nuevo cliente? {NuevoCliente}";
}