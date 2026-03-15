using System.IO;

public class Registrar
{
    public static void RegistrarProductos()
    {
        string IngresarMasProductos;
        
        do {
        Console.WriteLine("\n-------------------------");
        Console.WriteLine("Introduce el producto: \n");

        Console.Write("Nombre: ");
        string nombre = Console.ReadLine()!.ToUpper().Trim();

        Console.Write("Monto: ");
        double precio;
        while (!double.TryParse(Console.ReadLine(), out precio))
        {
            Console.WriteLine("\nMonto inválido. Intente otra vez.");
            Console.Write("Monto: ");
        }

        Console.Write($"Cantidad: ");
        int cantidad;
        while (!int.TryParse(Console.ReadLine(), out cantidad))
        {
            Console.WriteLine("\nCantidad inválida. Intente otra vez.");
            Console.Write($"Cantidad: ");
        }

        Console.WriteLine("-------------------------");
        
        Productos.Nombre.Add(nombre);
        Productos.Precio.Add(precio);
        Productos.Cantidad.Add(cantidad);

        GestorArchivos.RegistrarEnArchivo();
        Console.WriteLine($"\nProducto guardado correctamente.");

        Console.Write("\n¿Quieres ingresar mas productos? ");
        IngresarMasProductos = Console.ReadLine()!.ToUpper();
        }while(IngresarMasProductos == "SI");
    }
}