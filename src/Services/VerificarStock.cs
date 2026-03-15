
class VerificarStock
{
    public static void CuandoElStockSeaCero()
    {
        for(int i=0; i<Productos.Nombre.Count; i++)
        {
            if(Productos.Cantidad[i] == 0)
            {
                Productos.Nombre.RemoveAt(i);
                Productos.Precio.RemoveAt(i);
                Productos.Cantidad.RemoveAt(i);
            }
        }
    }
    
    public static int NoseaMayorAlStock(int index)
    {
        int Cantidad_ProductoComprado;

        do
            {
                Console.Write("¿Cuantos deseas comprar? ");
                while (!int.TryParse(Console.ReadLine(), out Cantidad_ProductoComprado))
                {
                    Console.WriteLine("\nCantidad inválida. Intente otra vez.");
                    Console.Write($"¿Cuantos deseas comprar? ");
                }

                if(Cantidad_ProductoComprado > Productos.Cantidad[index])
                {
                    Console.WriteLine("Cantidad insuficiente, ingresar nuevamente\n");
                }

            } while (Cantidad_ProductoComprado > Productos.Cantidad[index]);

            return Cantidad_ProductoComprado;
    }
}