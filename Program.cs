//WHILE
/*
Console.WriteLine("Ingrese numero a multiplicar");
int numero = Int32.Parse(Console.ReadLine());
int multiplicador = 1;
while (multiplicador <= 10)
{
    Console.Write($"{numero * multiplicador} ");
    multiplicador++;
}
*/

//DO WHILE
/*
int[] array = new int[4];

Console.WriteLine("Ingrese el primer numero");
array[0] = (Int32.Parse(Console.ReadLine()));
Console.WriteLine("Ingrese el segundo numero");
array[1] = (Int32.Parse(Console.ReadLine()));
Console.WriteLine("Ingrese el tercer numero");
array[2] = (Int32.Parse(Console.ReadLine()));
Console.WriteLine("Ingrese el cuarto y ultimo numero");
array[3] = (Int32.Parse(Console.ReadLine()));

int cantNumerosPositivos = 0;
int cantNumerosNegativos = 0;
int cantCeros = 0;

int i = 0;
do {
    if (array[i] == 0)
    {
        cantCeros++;
    }
    else if (array[i] > 0)
    {
        cantNumerosPositivos++;
    }
    else
    {
        cantNumerosNegativos++;
    }
    i++;
}while (i < array.Length);
Console.WriteLine($"Hay {cantCeros} cero(s), {cantNumerosNegativos} número(s) negativo(s) y {cantNumerosPositivos} número(s) positivo(s)");
*/

//FOR

/*
Console.WriteLine("Introduzca el ancho del cuadrado");
int ancho = Int32.Parse(Console.ReadLine());
Console.WriteLine("Introduzca el alto del cuadrado");
int alto = Int32.Parse(Console.ReadLine());
Console.WriteLine("El cuadrado tiene relleno? Introduzca si o no");
string? relleno = Console.ReadLine();


for (int i = 0; i < alto; i++)
    {
        for (int j = 0; j < ancho; j++)
        {
            if(relleno.ToLower() == "si")
            {
            Console.WriteLine(new string('*', ancho));
            break;
            }
            else
            {            
                Console.WriteLine("*" + new string (' ', ancho - 2) + "*");
                break;
            }
    }
}
*/