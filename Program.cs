// See https://aka.ms/new-console-template for more information
/* Console.WriteLine("Hello, World!"); */
using System;
using static System.Console;
using CsBases.Fundamentals;

class Program
{
    static async Task Main()
    {
        // Declaramos Explicita
        // int cantidad = 15;
        // string mensaje = "La cantidad es: ";
        // decimal precio = 19.99m;
        // System.Console.WriteLine($"Cantidad: {cantidad}, mensaje: {mensaje}, precio: {precio}");

        // // Declaracion con var
        // var cantidad1 = 20;
        // var mensaje1 = "La cantidad con var es: ";
        // var precio1 = 29.99m;
        // System.Console.WriteLine($"Cantidad1: {cantidad1}, mensaje1: {mensaje1}, precio1: {precio1}");

        // var laptop = new Product("Laptop", 999.99m);
        // System.Console.WriteLine(laptop.GetDescription());
        // var soporte = new ServiceProduct("Soporte Técnico", 300.99m, 30);
        // System.Console.WriteLine(soporte.GetDescription());

        // var product = new Product("Mouse Gamer", 290.99m);
        // var productDto = ProductAdapter.ToDto(product);
        // System.Console.WriteLine($"Product DTO - Name: {productDto.Name}, Price: {productDto.Price}, Code: {productDto.Code}");

        // // Inyeccion de dependencias
        // ILabelService labelService = new LabelService();
        // var manager = new ProductManager(labelService);
        // var monitor = new Product("Monitor", 199.99m);
        // var installation = new ServiceProduct("Instalación", 50.00m, 30);
        // manager.PrintLabel(monitor);
        // manager.PrintLabel(installation);

        var firstProduct = await new ProductRepositories().GetProduct(1);
        firstProduct.Description = "Este es un producto de prueba";
        AttributeProcessor.ApplyUpperCase(firstProduct);
        System.Console.WriteLine($"Producto obtenido: {firstProduct.Name}, Precio: {firstProduct.Price}, Descripción: {firstProduct.Description}");
    }
}
