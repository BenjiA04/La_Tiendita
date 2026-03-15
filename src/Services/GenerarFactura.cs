

class Generar
{
    public static void GenerarFactura()
    {
        string decicionCompra;
        int index;
        string ProductoComprado;

        do{
            
            // Mostramos los productos al usuario
            Listar.ListarProductos();

            do {

            Console.Write("\n¿Que producto deseas Comprar? ");
            ProductoComprado = Console.ReadLine()!.ToUpper();

            // Buscamos el índice del producto en la lista
            index = Productos.Nombre.IndexOf(ProductoComprado);
            
            if (index == -1)
            {
             Console.WriteLine("Producto no existe...");
            } 

            } while(index == -1);

            int Cantidad_ProductoComprado = VerificarStock.NoseaMayorAlStock(index);

            // Guardamos los productos en la factura
            Factura.ProductoComprado.Add(ProductoComprado);
            Factura.Cantidad_ProductoComprado.Add(Cantidad_ProductoComprado);
            Factura.Precio_ProductoComprado.Add(Productos.Precio[index]);

            // Modificamos la cantidad del producto en la lista
            Productos.Cantidad[index] = Productos.Cantidad[index] - Cantidad_ProductoComprado;
            VerificarStock.CuandoElStockSeaCero();
            GestorArchivos.RegistrarEnArchivo();

            Console.Write("\nDeseas comprar otro articulo? ");
            decicionCompra = Console.ReadLine()!.ToUpper();

        }while(decicionCompra == "SI");
        
        Console.WriteLine("\n===== PRODUCTOS COMPRADOS =====");
        
          for(int i=0; i<Factura.ProductoComprado.Count; i++){ 
           Console.WriteLine($"{i+1}. [Nombre: {Factura.ProductoComprado[i]} - Cantidad: {Factura.Cantidad_ProductoComprado[i]} - Precio C/U: RD${Factura.Precio_ProductoComprado[i]} Pesos - Precio total: RD${Factura.Precio_ProductoComprado[i] * Factura.Cantidad_ProductoComprado[i]}]");
           Factura.TotalCompraPagado += Factura.Cantidad_ProductoComprado[i] * Factura.Precio_ProductoComprado[i];
           Console.WriteLine("=====================");
          }

          Console.WriteLine($"Total a pagar: {Factura.TotalCompraPagado} pesos");

        // Generamos la factura en un txt.
        Guardar.GuardarFactura();

        // Vaciamos la factura al terminar
        Factura.ProductoComprado.Clear();
        Factura.Cantidad_ProductoComprado.Clear();
        Factura.Precio_ProductoComprado.Clear();
        Factura.TotalCompraPagado = 0;
    }
}