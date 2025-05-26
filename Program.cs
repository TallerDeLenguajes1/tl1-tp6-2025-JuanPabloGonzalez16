Console.WriteLine("Ingrese el numero");
int a;
string? texto;
texto = Console.ReadLine();
bool resultado = int.TryParse(texto, out a);
if (resultado)
{
    while (a > 0)
    {
        Console.Write(a % 10);
        a /= 10;
    }
}