class Listar
{
    public static void ListarProductos()
    {
            Console.WriteLine("\n===== PRODUCTOS =====");
        
            if(Productos.Nombre.Count() == 0){ Console.WriteLine("No hay productos...");}
        
            else {
              for(int i=0; i<Productos.Nombre.Count; i++){ 
                 Console.WriteLine($"{i+1}. [Nombre: {Productos.Nombre[i]} - Precio: RD${Productos.Precio[i]} Pesos - Cantidad: {Productos.Cantidad[i]}]");
                 Console.WriteLine("=====================");
              }
            }
    }
}