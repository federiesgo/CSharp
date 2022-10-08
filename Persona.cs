public class Persona
{
    public string nombre;
    public int edad;
    public string nacionalidad;
    public string profesion;
    public bool trabaja;

    public Persona (string nombre, int edad, string nacionalidad, string profesion, bool trabaja)
    {
        this.nombre = nombre;
        this.edad = edad;
        this.nacionalidad = nacionalidad;
        this.profesion = profesion;
        this.trabaja = trabaja;
    }

    public virtual void consultarEdad()
    {
        Console.Write($"La persona tiene {edad} años y es {profesion}");
    }
}