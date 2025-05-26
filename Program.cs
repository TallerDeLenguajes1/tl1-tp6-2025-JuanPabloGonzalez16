/*string? cadena;
Console.WriteLine("Ingrese la cadena");
cadena = Console.ReadLine();
int longitud = cadena.Length;*/

//Apartado I
Console.WriteLine("Ingrese la operacion simple Ejemplo(582+2)");
string? textoOperacion;
textoOperacion = Console.ReadLine();
char operador = ' ';
int posicion = -1;
char[] posibles = { '+', '-', '*', '/' };
foreach (char op in posibles)
{
    posicion = textoOperacion.IndexOf(op);
    if (posicion != -1)
    {
        operador = op;
    }
}
string?[] numeros = textoOperacion.Split(operador);
string? numero1 = numeros[0];
string? numero2 = numeros[1];
double num1Conv;
double num2Conv;
bool conversion1 = double.TryParse(numero1, out num1Conv);
bool conversion2 = double.TryParse(numero2, out num2Conv);
Console.WriteLine("El operador encontrado fue " + operador);
double resultado;
switch (operador)
{
    case '+':
        resultado = (num1Conv + num2Conv);
        Console.WriteLine("La suma de " + num1Conv + "y " + num2Conv + "es igual a " + resultado);
        break;
    case '-':
        resultado = (num1Conv - num2Conv);
        Console.WriteLine("La resta de " + num1Conv + "y " + num2Conv + "es igual a " + resultado);
        break;
    case '*':
        resultado = (num1Conv * num2Conv);
        Console.WriteLine("La multiplicacion de " + num1Conv + "y " + num2Conv + "es igual a " + resultado);
        break;
    case '/':
        if (num2Conv != 0)
        {
            resultado = (num1Conv / num2Conv);
            Console.WriteLine("La division de "  +  num1Conv + "y " + num2Conv + "es igual a " + resultado);
        }
        else
        {
            Console.WriteLine("No puede dividirse por cero");
        }
        break;
}
//Apartado B

/*
string? cadena2;
Console.WriteLine("Ingrese la cadena 2");
cadena2 = Console.ReadLine();
string? cadenaResultado = string.Concat(cadena, cadena2);
Console.WriteLine(cadenaResultado);

*/

/*
//Apartado C//
Console.WriteLine("La longitud de su cadena es " + longitud);
Console.WriteLine("Ingrese la posicion desde la que quiere empezar su subcadena");
int posicionInicial;
    string? num;
    num = Console.ReadLine();
    bool resultado = int.TryParse(num, out posicionInicial);
    Console.WriteLine("Ingrese la posicion en la que quiere terminar su subcadena");
    int posicionFinal;
    string? num2;
    num2 = Console.ReadLine();
    bool resultado2 = int.TryParse(num2, out posicionFinal);
    if (resultado && resultado2)
    {
        string? cadenaAux = cadena.Substring(posicionInicial, posicionFinal);
        Console.WriteLine(cadenaAux);

    }*/
/*
int op;
double a;
double b;
do
{
    Console.WriteLine("Escriba el número a");
    string? texta = Console.ReadLine();
    bool resultaa = double.TryParse(texta, out a);
    Console.WriteLine("Escriba el número b");
    string? textb = Console.ReadLine();
    bool resultab = double.TryParse(textb, out b);
    Console.WriteLine("Elija la opción");
    Console.WriteLine("1)Sumar");
    Console.WriteLine("2)Restar");
    Console.WriteLine("3)Multiplicar");
    Console.WriteLine("4)Dividir");
    Console.WriteLine("5)Valor Absoluto");
    Console.WriteLine("6)El cuadrado");
    Console.WriteLine("7)La raiz cuadrada");
    Console.WriteLine("8)El Seno");
    Console.WriteLine("9)El Coseno");
    Console.WriteLine("10)La parte entera del numero");
    Console.WriteLine("0)Salir");
    string? texOpc = Console.ReadLine();
    bool resultadoOp = int.TryParse(texOpc, out op);

    double resultado;
    string? resultCadena;
    switch (op)
    {
        case 1:
            resultado = (a + b);
            resultCadena = resultado.ToString();
            Console.WriteLine("La suma de" + a + "y " + b + "es igual a "+ resultCadena);
            break;
        case 2:
            resultado = a - b;
            resultCadena = resultado.ToString();
            Console.WriteLine("La resta de" + a + "y " + b + "es igual a "+ resultCadena);
            break;
        case 3:
            resultado = a * b;
            resultCadena = resultado.ToString();
            Console.WriteLine("La multiplicacion de" + a + "y " + b + "es igual a "+ resultCadena);
            break;
        case 4:
            if (b != 0)
            {
                resultado = a / b;
                resultCadena = resultado.ToString();
                Console.WriteLine("La division de" + a + "y " + b + "es igual a "+ resultCadena);
            }
            else
            {
                Console.WriteLine("No puede dividirse por cero");
            }
            break;
        case 5:
            if (a < 0)
            {
                resultado = -a;
                resultCadena = resultado.ToString();
                Console.WriteLine("El valor absoluto de " + a + "es " + resultCadena);
            }
            else
            {
                Console.WriteLine("El valor absoluto de " + a + "es " + a);
            }
            break;
        case 6:
            resultado = a * a;
            resultCadena = resultado.ToString();
            Console.WriteLine("El cuadrado de " + a + "es " + resultCadena);
            break;
        case 7:
            if (a >= 0)
            {
                resultado = Math.Sqrt(a);
                resultCadena = resultado.ToString();
                Console.WriteLine("La raiz cuadrada de " + a + "es " + resultCadena);
            }
            else
            {
                Console.WriteLine("No se puede sacar la raiz cuadrada de un numero negativo");
            }
            break;
        case 8:
            resultado = Math.Sin(a);
            resultCadena = resultado.ToString();
            Console.WriteLine("El seno de " + a + "es " + resultCadena);
            break;
        case 9:
            resultado = Math.Cos(a);
            resultCadena = resultado.ToString();
            Console.WriteLine("El Coseno de " + a + "es " + resultCadena);
            break;
        case 10:
            resultado = Math.Truncate(a);
            resultCadena = resultado.ToString();
            Console.WriteLine("La parte entera de " + a + "es " + resultCadena);
            break;
        case 0:
            Console.WriteLine("Saliendo del programa...");
            break;
    }

} while (op != 0);
*/

/*Mostrar letra por letra
foreach (char letra in cadena)
{
    Console.WriteLine(letra);
}*/
/*Apartado G
Console.WriteLine("Convierto la cadena a mayusculas");
string mayusculas = cadena.ToUpper();
Console.WriteLine(mayusculas);
Console.WriteLine("Convierto la candena a minusculas");
string minusculas = cadena.ToLower();
Console.WriteLine(minusculas);
*/

/*Apartado H
Console.WriteLine("Ingrese el caracter para separarla");
string? caracter;
caracter = Console.ReadLine();
string[] palabras = cadena.Split(caracter);
foreach(string palabra in palabras)
{
    Console.WriteLine(palabra);
}
*/
