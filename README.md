# LA TIENDA 🛒


## Descripcion ✨
Este proyecto consiste en un Sistema de Inventario llamado "La Tiendita", una aplicación de consola en C# que permite gestionar productos (eliminarlos y actualizarlos), 
así como controlar su stock y generar facturas de venta para los clientes.

El proyecto utiliza variables, listas, métodos simples y retornables, así como estructuras de control como if, while, for y switch. Además, el sistema incluye 
validación de entrada de datos, evitando que el usuario introduzca valores incorrectos (por ejemplo, texto en variables numéricas). Para ello se utilizan bucles 
while que verifican la entrada del usuario y vuelven a solicitar el dato hasta que sea válido, evitando que el programa se detenga por errores de ejecución.


## Modularidad 📋
El proyecto está dividido de la siguiente forma:

### Program.cs
Contiene el punto de entrada del programa y controla el flujo principal del sistema.

### UI
Menu.cs: Se encarga de controlar la interacción con el usuario. Contiene el menú principal del sistema y utiliza un bucle que permite al usuario seguir
navegando entre las distintas opciones (registrar productos, listar, actualizar, eliminar, generar facturas, etc.) hasta que decida salir del programa.

### models
Contiene las estructuras de datos (compuestas por listas) donde se almacenan los productos del inventario y las facturas generadas.

### Services
Contiene las funciones principales del programa:

- RegistrarProductos.cs: Permite registrar productos en el inventario y guardarlos en un archivo .txt.
- GestorArchivo: Se encarga de guardar los productos del inventario en un archivo llamado "RegistroProductos.txt" y cargarlos nuevamente al iniciar el sistema.
- VerificarStock.cs: Verifica que el stock de los productos sea mayor a 0. Si el stock llega a 0, el producto se elimina automáticamente del inventario.
También valida que la cantidad solicitada en una venta no exceda el stock disponible.
- ActualizarProductos.cs: Permite actualizar los datos de un producto existente buscándolo por su nombre.
- EliminarProductos.cs: Siguiendo la misma lógica del módulo anterior, permite eliminar productos del inventario buscándolos por su nombre.
- ListarProductos.cs: Recorre todos los productos almacenados y los muestra al usuario.
- GenerarFactura.cs: Se encarga de generar la factura de venta para el cliente al finalizar una compra.
- GuardarFacturaEnUnArchivo.cs: Trabaja junto con el módulo anterior para guardar las facturas en un archivo .txt, usando un orden numérico
seguido de la fecha en que fue creada.
