
int op;
int a; 
int b;

do
{
     Console.WriteLine("Escriba el número a");
    string? texta = Console.ReadLine();
    bool resultaa = int.TryParse(texta, out a);
    Console.WriteLine("Escriba el número b");
    string? textb = Console.ReadLine();
    bool resultab = int.TryParse(textb, out b);
     Console.WriteLine("Elija la opción");
    Console.WriteLine("1) Sumar");
     Console.WriteLine("2) Restar");
    Console.WriteLine("3) Multiplicar");
     Console.WriteLine("4) Dividir");
    Console.WriteLine("0) Salir");
    string? texOpc = Console.ReadLine();
    bool resultadoOp = int.TryParse(texOpc, out op);
     int resultado;
    switch (op) {
        case 1: resultado = a + b; Console.WriteLine(resultado);
           
            break;
        case 2: resultado = a - b;
            Console.WriteLine(resultado);
            break;
        case 3: resultado = a * b;
            Console.WriteLine(resultado);
            break;
        case 4:
            if (b != 0)  {
                resultado = a / b;
                Console.WriteLine(resultado);
            }
            else
            { Console.WriteLine("No puede dividirse por cero");
            } break;
        case 0:
            Console.WriteLine("Saliendo del programa...");
            break;
        default:
            Console.WriteLine("Opción no válida");
            break;
    }
} while (op != 0);