// ejer 1
Console.WriteLine("soy yo");

// ejer 2
//int age = 18;
//string name  = "sebastian";
//Console.WriteLine($"name:{name},age :{age}");
// ejer 3
//string texto = "HOLA MUNDO";
//string textoMinusculas = texto.ToLower();
//Console.WriteLine(textoMinusculas);
//string textoMayusculas = texto.ToUpper();
//Console.WriteLine(textoMayusculas);   
// ejer 4

//Console.Write("Ingresa el primer número entero: ");
//int numero1 = Convert.ToInt32(Console.ReadLine());
//Console.Write("Ingresa el segundo número entero: ");
//int numero2 = Convert.ToInt32(Console.ReadLine());

//int suma = numero1 + numero2;
//int resta = numero1 - numero2;
//int multiplicacion = numero1 * numero2;
//int division = numero1 / numero2;
           
//Console.WriteLine($"Suma: {suma}");
//Console.WriteLine($"Resta: {resta}");
//Console.WriteLine($"Multiplicación: {multiplicacion}");
//Console.WriteLine($"División: {division}");
// ejer 5
//int numero1 = 10;
//int numero2 = 10;
//Console.WriteLine($"numero1:{numero1}");
//Console.WriteLine($"numero2:{numero2}");
//bool esIgual = (numero1 == numero2);
//bool esDiferente = (numero1 != numero2);
//bool esMayor = (numero1 > numero2);
//bool esMenor = (numero1 < numero2);
//Console.WriteLine($"{numero1} == {numero2} (son iguales :{esIgual})");
//Console.WriteLine($"{numero1} != {numero2} (son diferente :{esDiferente})");
//Console.WriteLine($"{numero1} > {numero2} (es mayor: {esMayor})");
//Console.WriteLine($"{numero1} < {numero2} (es menor : {esMenor})");
// ejer 6
//string texto ="el gato negro y el gato blanco";
//string resultado = texto.Replace("gato","perro");
//Console.WriteLine(texto);
//Console.WriteLine(resultado);
// ejer 7
//Console.Write("tu nombre: ");
//string nombre = Console.ReadLine();
//Console.Write(" tu edad: ");
//string edadTexto = Console.ReadLine();
//Console.WriteLine($"Hola {nombre}, tienes {edadTexto} años.");
// ejer 8
//int numero = 10 ;
//bool esMayor = numero > 10 ;
//bool esMenor = numero < 10;
//bool esIgual = numero == 10;
//Console.WriteLine($"{numero} > {10} (es mayor : {esMayor})");
//Console.WriteLine($"{numero} < {10} (es menor: {esMenor})");
//Console.WriteLine($"{numero} == {10}(es igual:{esIgual})");
//ejer 9 
//double num1 = 20;
//double num2 = 4;

//double suma = num1 + num2;
//double resta = num1 - num2;
//double multiplicacion = num1 * num2;
//double division = num1 / num2;

//Console.WriteLine($"Suma: {suma}");
//Console.WriteLine($"Resta: {resta}");
//Console.WriteLine($"Multiplicación: {multiplicacion}");
//Console.WriteLine($"División: {division}");
// ejer 10
//string texto1 = "bienvenido a ";
//string texto2 = "clase";
//string resultado = texto1 +texto2;
//Console.WriteLine(resultado);
// ejer 11
//int myInt = 10;
//double myDouble =myInt;
//Console.WriteLine(myDouble);
//ejer 12
  // Solicitar entrada al usuario
//{Console.Write("Introduce un número: ");
//string entrada = Console.ReadLine();

        
//if (double.TryParse(entrada, out double numero))
//{
//if (numero > 0)
//{
//Console.WriteLine("El número es positivo.");
//}
//else if (numero < 0)
//{
//Console.WriteLine("El número es negativo.");
//}
//else
//{
//Console.WriteLine("El número es cero.");
//}
//}
//else
//{
//Console.WriteLine("Error: Por favor, introduce un número válido.");}
//}
// ejer 13
//for (int i = 1; i <=10;i++)
//{
//  Console.WriteLine(i);
//}
//ejer 14
string texto = "  hOLA mUNDO  ";
string resultado = char.ToUpper(texto.Trim()[0]) + texto.Trim().Substring(1).ToLower();
Console.WriteLine(resultado);   
// ejer 15
 