

class Program
{
    static void Main()
    {
        Console.WriteLine("\nBIENVENIDOS AL LA TIENDA");
        GestorArchivos.CargarDesdeArchivo();
        Menu.MostrarMenu();
    }
}
