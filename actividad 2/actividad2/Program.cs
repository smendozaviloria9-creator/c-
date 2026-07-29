//ejer 1 
//Console.Write("Escribe un número entero: ");

//if (int.TryParse(Console.ReadLine(), out int numero))
//{
    //if (numero % 2 == 0)
    //{
       // Console.WriteLine($"El número {numero} es par.");
  //  }
   // else
   // {
    //    Console.WriteLine($"El número {numero} es impar.");
   // }
//}
//else
//{
  //  Console.WriteLine("Por favor, ingrese un número entero.");
//}
//ejer 2
//Console.Write("ingrse su nombre:");
//string nombre = Console.ReadLine();
//if (!string.IsNullOrWhiteSpace(nombre))
//{
  //  Console.WriteLine($"¡bienvenido,{nombre.Trim()}!");
//
//}   
//else 
//{
  //  Console.WriteLine("error : el nombre ingresado  no es validoo esta vacio");
//}
//ejer 3
//Console.Write("su edad:");
//string entrada = Console.ReadLine();
//if (int.TryParse(entrada, out int edad) && edad >= 0)
//if (edad >= 18)
//{
  //  Console.WriteLine("eres mayor");
//}
//else 
//{
  //  Console.WriteLine(" eres menor ");
//}
//ejer 4 
Console.Write("igrese un numero del 1 al 7:");
string entrada = Console.ReadLine() ??"";

if (int.TryParse(entrada, out int dia ))

switch (dia)
{
    case 1:
        Console.WriteLine("lunes:");
        break;
    case 2:
        Console.WriteLine("martes");
        break;
    case 3:
        Console.WriteLine("miercoles");
        break;
    case 4:
        Console.WriteLine("jueves");
        break;
    case 5:
        Console.WriteLine("viernes");
        break;
    case 6:
        Console.WriteLine("sabado");
        break;
    case 7:
        Console.WriteLine("domingo");
        break;
    default:
        Console.WriteLine("ingrese un numero que sea del 1 al 7");  
        break;
}
//ejer 5

Console.Write("¿Cuál es tu país de nacionalidad?: ");
string nacionalidad = Console.ReadLine()?.Trim().ToLower() ?? "";      
string mensaje = (nacionalidad == "colombiana" || nacionalidad == "colombia")
? "Eres nativo del país."
: "Eres extranjero.";

Console.WriteLine(mensaje);
//EJER 6
Console.Write("Ingresa el primer número: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingresa el segundo número: ");
double num2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingresa el tercer número: ");
double num3 = Convert.ToDouble(Console.ReadLine());
double mayor;
if (num1 >= num2 && num1 >= num3)
{
    mayor = num1;
}
else if (num2 >= num1 && num2 >= num3)
{
    mayor = num2;
}
else
{
    mayor = num3;
}

Console.WriteLine($"El número mayor es: {mayor}");
//ejer 7

Console.Write("Ingresa tu contraseña: ");
string password = Console.ReadLine() ??"";


if (!string.IsNullOrEmpty(password))
{
    Console.WriteLine("La contraseña es aceptada.");
}
else
{
    Console.WriteLine("La contraseña no puede estar en blanco.");
}
//ejer 8 
Console.Write("ingrese un numero del 1 al 12: "); 
string Entrada = Console.ReadLine() ?? "" ;
if (int.TryParse(Entrada, out int mes))
{ 
    switch (mes)
    {
        case 1:
            Console.WriteLine("enero"); 
            break;
        case 2:
            Console.WriteLine("febrero");
            break;
        case 3:
            Console.WriteLine("marzo");
            break;
        case 4:
            Console.WriteLine("abril");
            break;
        case 5:
            Console.WriteLine("mayo");
            break;
        case 6:
            Console.WriteLine("junio");
            break;
        case 7:
            Console.WriteLine("julio");
            break;
        case 8:
            Console.WriteLine("agosto");
            break;
        case 9:
            Console.WriteLine("septiembre");
            break;
        case 10:
            Console.WriteLine("octubre");
            break;
        case 11:
            Console.WriteLine("noviembre"); 
            break;
        case 12:
            Console.WriteLine("diciembre");
            break;
        default:
            Console.WriteLine("ingrese un numero que sea del 1 al 12");  
            break;
    }
} 
//ejer 9
Console.Write("Ingresa la calificación numérica (0-100): ");
if (double.TryParse(Console.ReadLine(), out double nota))
{
if (nota >= 90 && nota <= 100)
  Console.WriteLine("Letra correspondiente: A");
else if (nota >= 80 && nota < 90)
    Console.WriteLine("Letra correspondiente: B");
else if (nota >= 70 && nota < 80)
    Console.WriteLine("Letra correspondiente: C");
else if (nota >= 60 && nota < 70)
      Console.WriteLine("Letra correspondiente: D");
else if (nota >= 0 && nota < 60)
      Console.WriteLine("Letra correspondiente: F");
else
    Console.WriteLine("Calificación fuera de rango.");
}
//ejer 10
Console.Write("Ingresa un carácter: ");
char caracter = char.ToLower(Console.ReadKey().KeyChar);
    Console.WriteLine();
 if (char.IsLetter(caracter))
{
    switch (caracter)
    {
        case 'a':
        case 'e':
        case 'i':
        case 'o':
        case 'u':
            Console.WriteLine("Es una vocal.");
            break;
        default:
            Console.WriteLine("Es una consonante.");
            break;
    }
}
//ejer 11
Console.Write("Ingresa el primer número: ");
double numero1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingresa el segundo número: ");

double numero2 = Convert.ToDouble(Console.ReadLine());

if (numero1 == numero2)
{
  Console.WriteLine("Los números son iguales.");
}
else
{
  Console.WriteLine("Los números son diferentes.");
}
// ejer 12
Console.Write("Ingresa tu dirección: ");
string direccion = Console.ReadLine()??"";
if (!string.IsNullOrWhiteSpace(direccion))
{
  Console.WriteLine("Dirección válida. Confirmación exitosa.");
}
else
{
  Console.WriteLine("Error: La dirección no puede estar vacía ni contener solo espacios.");
}
//ejer 13
Console.Write("Ingresa un número: ");
if (double.TryParse(Console.ReadLine(), out double numero))
{
  if (numero > 0)
    Console.WriteLine("El número es positivo.");
  else if (numero < 0)
    Console.WriteLine("El número es negativo.");
  else
    Console.WriteLine("El número es cero.");
}
else
{
  Console.WriteLine("Entrada no válida.");
}
//ejer 14
Console.Write("Ingresa una letra: ");
char letra = char.ToLower(Console.ReadKey().KeyChar);
Console.WriteLine();

if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
{
  Console.WriteLine("Es una vocal.");
}
else
{
   Console.WriteLine("No es una vocal.");
}
//ejer 15
Console.Write("Ingresa la temperatura en grados Celsius: ");
if (double.TryParse(Console.ReadLine(), out double temp))
{
  if (temp > 30)
    Console.WriteLine("La temperatura es caliente.");
  else if (temp >= 10 && temp <= 30)
    Console.WriteLine("La temperatura es templada.");
  else
    Console.WriteLine("La temperatura es fría.");
}
else
{
  Console.WriteLine("Por favor, ingresa un valor numérico válido.");
}
// ejer 16
Console.WriteLine("ingresa un año");
if (int.TryParse(Console.ReadLine(), out int  año))

{
  if ((año % 4 == 0 && año % 100 != 0) || (año % 400 == 0))
  {
    Console.WriteLine($"El año {año} es bisiesto.");
  }
  else
  {
    Console.WriteLine($"El año {año} no es bisiesto.");
  }
}
else
  {
    Console.WriteLine("Año inválido.");
  }
// ejer 17
string valor = "";
while (string.IsNullOrWhiteSpace(valor))
{
  Console.Write("Ingresa un valor: ");
  valor = Console.ReadLine() ??"usuario";
  if (string.IsNullOrWhiteSpace(valor))
  {
    Console.WriteLine("Entrada no válida. Por favor, ingresa un valor válido.\n");
  }
}  
Console.WriteLine($"¡Entrada aceptada! El valor ingresado es: {valor}");
//ejer 18
Console.Write("Ingresa un número del 1 al 7: ");
if (int.TryParse(Console.ReadLine(), out int Dia))
{
  switch (Dia)
  {
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:
        Console.WriteLine("Es un día laborable.");
        break;
    case 6:
    case 7:
        Console.WriteLine("Es fin de semana.");
        break;
  }
}
else
{
  Console.WriteLine("Por favor, ingresa un número entero.");
}
//fin