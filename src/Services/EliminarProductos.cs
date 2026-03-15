
class Eliminar
{
    public static void EliminarProducto()
    {
        string ProductoEliminar;
        int index;

        do {
        Console.Write("\n¿Que producto deseas eliminar? ");
        ProductoEliminar = Console.ReadLine()!.ToUpper();

        // Buscamos el índice del producto en la lista
        index = Productos.Nombre.IndexOf(ProductoEliminar);

        if (index == -1)
         {
         Console.WriteLine("Producto no existe...");
         }
        }while(index == -1);

        // Eliminamos el producto de todas las listas usando el mismo índice
        Productos.Nombre.RemoveAt(index);
        Productos.Precio.RemoveAt(index);
        Productos.Cantidad.RemoveAt(index);

        GestorArchivos.RegistrarEnArchivo();
        Console.WriteLine($"Producto: {ProductoEliminar}, eliminado correctamente.");
        }
}