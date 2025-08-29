using System;

class Program
{
    static void Main()
    {
        // Matriz de precios (producto x tamaño)
        string[] productos = { "NARANJA", "FRESAS", "LUCUMA", "PAPAYA", "SURTIDO", "PIÑA" };
        double[,] precios = {
         {15.50, 12.00, 10.50},
         {17.00, 13.70, 11.50},
         {12.00,  9.50,  7.50},
         {10.00,  8.50,  6.50},
         {20.00, 17.00, 15.00},
         {11.50,  9.40,  7.20}
     };

        // Entrada de producto
        Console.WriteLine("Productos: 1=NARANJA, 2=FRESAS, 3=LUCUMA, 4=PAPAYA, 5=SURTIDO, 6=PIÑA");
        Console.Write("Elija producto: ");
        if (!int.TryParse(Console.ReadLine(), out int prod) || prod < 1 || prod > productos.Length)
        {
            Console.WriteLine("? Producto inválido");
            return;
        }
        prod--; // ajustar índice

        // Entrada de tamaño
        Console.WriteLine("Tamaño: 1=Large, 2=Medium, 3=Small");
        Console.Write("Elija tamaño: ");
        if (!int.TryParse(Console.ReadLine(), out int tam) || tam < 1 || tam > 3)
        {
            Console.WriteLine("? Tamaño inválido");
            return;
        }
        tam--;

        double precio = precios[prod, tam];
        Console.WriteLine($"\nProducto: {productos[prod]} - Precio base: S/ {precio}");

        // Método de pago
        Console.WriteLine("\nMétodo de pago: 1=Efectivo (10% desc), 2=Electrónico (5% recargo)");
        if (!int.TryParse(Console.ReadLine(), out int pago) || (pago != 1 && pago != 2))
        {
            Console.WriteLine("? Método de pago inválido");
            return;
        }

        double ajuste = (pago == 1) ? -precio * 0.10 : precio * 0.05;
        double total = precio + ajuste;

        Console.WriteLine($"Ajuste: S/ {ajuste:F2}");
        Console.WriteLine($"? Total a pagar: S/ {total:F2}");
    }
}