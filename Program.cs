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

    switch (op)
    {
        case 1:
            resultado = a + b;
            Console.WriteLine(resultado);
            break;
        case 2:
            resultado = a - b;
            Console.WriteLine(resultado);
            break;
        case 3:
            resultado = a * b;
            Console.WriteLine(resultado);
            break;
        case 4:
            if (b != 0)
            {
                resultado = a / b;
                Console.WriteLine(resultado);
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
                Console.WriteLine("El valor absoluto de " + a + "es " + resultado);
            }
            else
            {
                Console.WriteLine("El valor absoluto de " + a + "es " + a);
            }
            break;
        case 6:
            resultado = a * a;
            Console.WriteLine("El cuadrado de " + a + "es " + resultado);
            break;
        case 7:
            if (a >= 0)
            {
                resultado = Math.Sqrt(a);
                Console.WriteLine("La raiz cuadrada de " + a + "es " + resultado);
            }
            else
            {
                Console.WriteLine("No se puede sacar la raiz cuadrada de un numero negativo");
            }
            break;
        case 8:
            resultado = Math.Sin(a);
            Console.WriteLine("El seno de " + a + "es " + resultado);
            break;
        case 9:
            resultado = Math.Cos(a);
            Console.WriteLine("El Coseno de " + a + "es " + resultado);
            break;
        case 10:
            resultado = Math.Truncate(a);
            Console.WriteLine("La parte entera de " + a + "es " + resultado);
            break;
        case 0:
            Console.WriteLine("Saliendo del programa...");
            break;
    }

} while (op != 0);

