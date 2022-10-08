Alumno fede = new Alumno("Federico Riesgo", 28, "Argentina", "Desarrollador", true );
fede.consultarEdad();


public class Alumno : Persona
{
    public Alumno(string nombre, int edad, string nacionalidad, string profesion, bool trabaja) : base(nombre, edad, nacionalidad, profesion, trabaja)
    {
    }

    public override void consultarEdad()
    {
        Console.WriteLine($"El alumno {nombre} tiene {edad} años y es de nacionalidad {nacionalidad}. Trabaja como {profesion}");
        if (trabaja)
        {
            Console.WriteLine("Actualmente trabaja");
        }
        else
        {
            Console.WriteLine("Actualmente no trabaja");
        }
    }
}