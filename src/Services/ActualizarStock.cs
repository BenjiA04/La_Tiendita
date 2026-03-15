

class Actualizar
{
    public static void ActualizarProducto()
    {

        string ProductoActualizar;
        int index;

        do {
        Console.Write("\n¿Que producto deseas Actualizar? ");
        ProductoActualizar = Console.ReadLine()!.ToUpper();

        // Buscamos el índice del producto en la lista
        index = Productos.Nombre.IndexOf(ProductoActualizar);

        if (index == -1)
        {
        Console.WriteLine("Producto no existe...");
        }
        }while(index == -1);

        // Modificamos el producto usando el mismo índice
        Console.WriteLine("\n===== Productos =====");
          for(int i=0; i<Productos.Nombre.Count; i++){ 
            if(Productos.Nombre[i] == ProductoActualizar){
             Console.WriteLine($"{i+1}. [Nombre: {Productos.Nombre[i]} - Precio: RD${Productos.Precio[i]} Pesos - Cantidad: {Productos.Cantidad[i]}]");
             Console.WriteLine("=====================\n");
            }
          }

        Console.WriteLine("¿Que deseas modificar? ");
        Console.WriteLine("1. Nombre");
        Console.WriteLine("2. Precio");
        Console.WriteLine("3. Cantidad");

        Console.Write("Opcion: ");
        int OpcionModificacion = int.Parse(Console.ReadLine()!);

            // Actualizar Nombre
            if(OpcionModificacion == 1)
            {
               Console.Write("\nIngrese el nuevo nombre: ");
               string modificacion = Console.ReadLine()!.ToUpper().Trim();

               Productos.Nombre[index] = modificacion;
            }

            //Actualizar Precio
            else if(OpcionModificacion == 2)
            {
               Console.Write("\nIngrese el nuevo precio: ");
               double modificacion;
               while (!double.TryParse(Console.ReadLine(), out modificacion))
               {
                  Console.WriteLine("\nMonto inválido. Intente otra vez.");
                  Console.Write("Ingrese el nuevo precio: ");
               }
               Productos.Precio[index] = modificacion;
            }

            // Actualizar Cantidad
            else if(OpcionModificacion == 3)
            {
               Console.Write("\nIngrese la nueva cantidad: ");
               int modificacion;
               while (!int.TryParse(Console.ReadLine(), out modificacion))
               {
                  Console.WriteLine("\nCantidad inválida. Intente otra vez.");
                  Console.Write($"Ingrese la nueva cantidad: ");
               }

               Productos.Cantidad[index] = modificacion;
            }

        GestorArchivos.RegistrarEnArchivo();
        Console.WriteLine("Producto modificado correctamente.");
    }
}