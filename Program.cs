Console.WriteLine("Introduce tu nombre");

string Nombre = Console.ReadLine();
string HoraActual = DateTime.Now.ToString("h:mm:ss tt");

Console.WriteLine("Hola " + Nombre + ", Bienvenido.");
Console.WriteLine("La hora actual es: " + HoraActual);