using System.IO;

class Guardar
{
    public static void GuardarFactura()
    {
        // Crea la carpeta si no existe
        if (!Directory.Exists("data"))
        {
            Directory.CreateDirectory("data");
        }

        int contador = 1;
        string rutaCompleta;

        do
        {
         // Generamos el nombre con la fecha actual y un numero
         rutaCompleta = Path.Combine("data", $"Factura{contador}-{DateTime.Now.ToString("(yyyy-MMMM-dd)")}.text");
         contador++;
    
         // Si el archivo existe, el ciclo continúa buscando el siguiente número
        } while (File.Exists(rutaCompleta));

        using (StreamWriter sw = new StreamWriter(rutaCompleta, true))
        {
            sw.WriteLine("\n--- PRODUCTOS COMPRADOS ---");
            sw.WriteLine($"Usuario: Usuario{contador} | Fecha: {DateTime.Now.ToString("dd/MM/yyyy")} | Hora: {DateTime.Now.ToString("hh:mm:ss")}");
            for(int i=0; i<Factura.ProductoComprado.Count; i++){         
                 sw.WriteLine($"{i+1}. [Nombre: {Factura.ProductoComprado[i]} - Cantidad: {Factura.Cantidad_ProductoComprado[i]} - Precio C/U: RD${Factura.Precio_ProductoComprado[i]} Pesos - Precio total: RD${Factura.Precio_ProductoComprado[i] * Factura.Cantidad_ProductoComprado[i]}]");
                 Factura.TotalCompraPagado += Factura.Cantidad_ProductoComprado[i] * Factura.Precio_ProductoComprado[i];
                 sw.WriteLine("=====================");
            }
            sw.WriteLine($"Total a pagar: {Factura.TotalCompraPagado} pesos");
         // Al salir de aquí, el archivo se guarda y se cierra.
        }

        Console.WriteLine($"\nArchivo creado en: {rutaCompleta}");
    }
}