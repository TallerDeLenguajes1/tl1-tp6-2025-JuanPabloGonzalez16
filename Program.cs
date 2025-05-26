int op;
double a;
do
{
    Console.WriteLine("Escriba el número a");
    string? texta = Console.ReadLine();
    bool resultaa = double.TryParse(texta, out a);
    Console.WriteLine("Elija la opción");
    Console.WriteLine("1)Valor Absoluto");
    Console.WriteLine("2)El cuadrado");
    Console.WriteLine("3)La raiz cuadrada");
    Console.WriteLine("4)El Seno");
    Console.WriteLine("5)El Coseno");
    Console.WriteLine("6)La parte entera del numero");
    Console.WriteLine("0)Salir");
    string? texOpc = Console.ReadLine();
    bool resultadoOp = int.TryParse(texOpc, out op);

    double resultado;

    switch (op)
    {
        case 1:
            if (a < 0)
            {
                resultado = -a;
                Console.WriteLine("El valor absoluto de " + a + "es " + resultado);
            }else
            {
                Console.WriteLine("El valor absoluto de " + a + "es " + a);
            }
            break;
        case 2:
            resultado = a * a;
            Console.WriteLine("El cuadrado de " + a + "es " + resultado);
            break;
        case 3:
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
        case 4:
            resultado = Math.Sin(a);
            Console.WriteLine("El seno de " + a + "es " + resultado);
            break;
        case 5:
            resultado = Math.Cos(a);
            Console.WriteLine("El Coseno de " + a + "es " + resultado);
            break;
        case 6:
            resultado = Math.Truncate(a);
            Console.WriteLine("La parte entera de " + a + "es " + resultado);
            break;
    }

} while (op != 0);
