
class GestorArchivos
{
    public static void RegistrarEnArchivo()
    {
        string ruta = $"RegistroProductos.text";

        using (StreamWriter sw = new StreamWriter(ruta))
        {
            sw.WriteLine($"--- Reporte de Productos (Ultima Actualizacion: {DateTime.Now.ToString("(yyyy-MM-dd)")}) ---");

            for(int i=0; i<Productos.Nombre.Count(); i++)
            {
                string linea = $"{Productos.Nombre[i]},{Productos.Precio[i]},{Productos.Cantidad[i]}";
                sw.WriteLine(linea);
            }
        }
    }

    public static void CargarDesdeArchivo()
    {
        string ruta = $"RegistroProductos.text";

        if (File.Exists(ruta))
        {
        string[] lineas = File.ReadAllLines(ruta);
        
        foreach (string i in lineas)
        {
            // Dividimos la línea por la coma que usamos al guardar
            string[] partes = i.Split(',');

            if (partes.Length >= 3)
            {
            Productos.Nombre.Add(partes[0]);
            Productos.Precio.Add(double.Parse(partes[1]));
            Productos.Cantidad.Add(int.Parse(partes[2]));
            }
        }
      }
    }
}