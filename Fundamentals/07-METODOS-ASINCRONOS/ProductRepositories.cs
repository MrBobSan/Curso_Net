using System;
using CsBases.Fundamentals;

public class ProductRepositories
{
   public async Task<Product> GetProduct(int id)
    {
        // Obtener de una base de datos,
        // una llamada a una API externa,
        // o podria ser cualquier archivo
        Console.WriteLine("Buscando producto...");
        await Task.Delay(2000); // Simula una operación asincrona
        return new Product($"Producto{id}", id * 10.99m);
    }
}