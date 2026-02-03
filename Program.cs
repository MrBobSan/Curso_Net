// See https://aka.ms/new-console-template for more information
/* Console.WriteLine("Hello, World!"); */
class Program
{
    static void Main(string[] args)
    {
        // Declaramos Explicita
        int cantidad = 15;
        string mensaje = "La cantidad es: ";
        decimal precio = 19.99m;
        System.Console.WriteLine($"Cantidad: {cantidad}, mensaje: {mensaje}, precio: {precio}");

        // Declaracion con var
        var cantidad1 = 20;
        var mensaje1 = "La cantidad con var es: ";
        var precio1 = 29.99m;
        System.Console.WriteLine($"Cantidad1: {cantidad1}, mensaje1: {mensaje1}, precio1: {precio1}");
    }
}
