// ejer 1
for (int i = 1; i <= 100; i++)
{
    Console.WriteLine(i);
}
// ejer 2
Console.Write("Introduce un número entero positivo: ");
if (int.TryParse(Console.ReadLine(),out int numero ) &&numero > 0)
{
    Console.WriteLine($"ingrese el nuemro del 1 al {numero}:");
    for (int i = 1; i <= numero;i++)
    {
        if (i % 2 ==0 )
        {
            Console.WriteLine(i);
        }
    }
}
// ejer 3
Console.Write("Introduce un número entero positivo: ");
if (int.TryParse(Console.ReadLine(), out int numeroTabla) && numeroTabla > 0)
{
    Console.WriteLine($"\nTabla de multiplicar del {numeroTabla}:");
    for (int i = 1; i <= 10; i++)
    {
        int resultado = numeroTabla * i;
        Console.WriteLine($"{numeroTabla} x {i} = {resultado}");
    }
}
//ejer 4
Random random = new Random();
int numeroSecreto = random.Next(1, 101);
int intento = 0;
Console.WriteLine("¡He pensado en un número entre 1 y 100!");
Console.WriteLine("¿Puedes adivinar cuál es?\n");
while (intento != numeroSecreto)
{
    if (intento < numeroSecreto)
    {
        Console.WriteLine("Demasiado bajo. Intenta de nuevo.\n");
    }
    else if (intento > numeroSecreto)
    {
        Console.WriteLine("Demasiado alto. Intenta de nuevo.\n");
    }
    else 
    {
        Console.WriteLine($"\n¡Felicidades! ¡Adivinaste el número secreto ({numeroSecreto})!");
    }
    
}
// ejer 5
Console.Write("Introduce un número entero positivo: ");
if (int.TryParse(Console.ReadLine(), out int numerop) && numerop > 0)
{
    Console.WriteLine($"Números impares desde {numerop} hasta 1:");
    int i = numerop;
    while (i >= 1)
    {
        if (i % 2 != 0)
        {
            Console.WriteLine(i);
        }
        i--;
    }
}
// ejer 6
string contraseña= "";
while (contraseña != "secreta")
{
    Console.WriteLine("introduce la contraseña ");
    contraseña  = Console.ReadLine();
    if (contraseña != "secreta")
    {
        Console.WriteLine("Contraseña incorrecta. Inténtalo de nuevo.\n");
    }

}
// ejer 7
Console.Write("Introduce un número entero positivo: ");
if (int.TryParse(Console.ReadLine(), out int limite) && limite > 0)
{
    Console.WriteLine($"\nSecuencia de Fibonacci hasta {limite}:");
    long a = 0;
    long b = 1;
    for (int i = 0; a <= limite; i++)
    {
        Console.Write(a + " ");
        long siguiente = a + b;
        a=b;
        b=siguiente;
    }
    Console.WriteLine();
}
//ejer 8
Console.Write("Introduce un número entero positivo: ");
if (int.TryParse(Console.ReadLine(), out int numero1) && numero1 > 0)
{
    if (numero1 == 1)
    {
        Console.WriteLine($"El número 1 no es primo ni compuesto.");
        return;
    }
    bool esPrimo = true;
    for (int i = 2; i * i <= numero1; i++)
    {
        if (numero1 % i == 0)
        {
            esPrimo = false;
            break;
        }
    }
    if (esPrimo)
    {
        Console.WriteLine($"¡El número {numero1} es primo!");
    }
    else
    {
        Console.WriteLine($"El número {numero1} no es primo.");
    }
}
//ejer 9
Console.Write("Introduce una palabra: ");
string palabra = Console.ReadLine();
if (!string.IsNullOrWhiteSpace(palabra))
{
    Console.WriteLine("\nLetras de la palabra:");
    foreach (char letra in palabra)
    {
        Console.WriteLine(letra);
    }
}
//ejer 10
Console.Write("Introduce un número entero positivo: ");
if (int.TryParse(Console.ReadLine(), out int numeroSuma) && numeroSuma > 0)
{
    int suma = 0;
    for (int i = 1; i <= numeroSuma; i++)
    {
        suma += i;
    }
    Console.WriteLine($"La suma de todos los números del 1 al {numeroSuma} es: {numeroSuma}");
}
// end