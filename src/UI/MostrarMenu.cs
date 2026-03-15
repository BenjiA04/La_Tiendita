
class Menu
{
    public static void MostrarMenu()
    {  
        int Opcion;

        do {  
        Console.WriteLine("\n===== Menu =====");
        Console.WriteLine("1. Registrar Productos");
        Console.WriteLine("2. Actualizar Productos");
        Console.WriteLine("3. Eliminar Productos");
        Console.WriteLine("4. Listar Productos");
        Console.WriteLine("5. Generar Factura");
        Console.WriteLine("6. Salir\n");

        Console.Write("Opcion: ");
        Opcion = int.Parse(Console.ReadLine()!);

        switch (Opcion)
        {
            case 1:
            Registrar.RegistrarProductos();
            Opcion = Menu.RepetirBucle(Opcion);
            break;

            case 2:
            Actualizar.ActualizarProducto();
            Opcion = Menu.RepetirBucle(Opcion);
            break;

            case 3:
            Eliminar.EliminarProducto();
            Opcion = Menu.RepetirBucle(Opcion);
            break;

            case 4:
            Listar.ListarProductos();
            Opcion = Menu.RepetirBucle(Opcion);
            break;

            case 5:
            Generar.GenerarFactura();
            Opcion = Menu.RepetirBucle(Opcion);
            break;

            case 6:
            Console.WriteLine("Saliendo del sistema....");
            break;

            default:
            Console.WriteLine("Opcion Invalida.....");
            break;
        }

        }while(Opcion != 6);
    }

    public static int RepetirBucle(int Opcion)
    {
        
        Console.Write("\n¿Quieres regresar al menu? ");
        string Condicion = Console.ReadLine()!.ToUpper();

        if(Condicion == "SI") {Opcion = 7;}
        else if(Condicion == "NO"){Console.WriteLine("Muchas gracias...."); Opcion = 6;}

        return Opcion;
    }
}