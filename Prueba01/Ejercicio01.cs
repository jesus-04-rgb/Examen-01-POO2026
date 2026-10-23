namespace Prueba01
{
    public class Ejercicio01
    {
        public void Ejecutar()
        {
            //Aquí declaramos nuestras variables para almacenar los datos del cliente y del paquete
            string nombreCliente;
            int zona;
            double peso;
            int tipoServicio;
            double valorDeclarado;

         //Solicitamos los datos al usuario
        Console.WriteLine("==Empresa de Mensajería==");

        Console.Write("Ingrese el nombre del cliente: ");

        nombreCliente = Console.ReadLine() ?? string.Empty; 

        Console.Write("Ingrese la zona (1 = local, 2 = departamental, 3 = nacional): ");

        zona = int.Parse(Console.ReadLine() ?? string.Empty);

        zona = (zona >= 1 && zona <= 3) ? zona : throw new ArgumentException("Zona no válida");

        Console.Write("Ingrese el peso en kilogramos: ");

        peso = double.Parse(Console.ReadLine() ?? string.Empty);
        peso = (peso > 0) ? peso : throw new ArgumentException("Peso no válido");

        Console.Write("Ingrese el tipo de servicio (1 = estándar, 2 = express, 3 = mismo día): ");

        tipoServicio = int.Parse(Console.ReadLine() ?? string.Empty);
        tipoServicio = (tipoServicio >= 1 && tipoServicio <= 3) ? tipoServicio : throw new ArgumentException("Tipo de servicio no válido");

        Console.Write("Ingrese el valor declarado del paquete: ");
        
        valorDeclarado = double.Parse(Console.ReadLine() ?? string.Empty);
        valorDeclarado = (valorDeclarado >= 0) ? valorDeclarado : throw new ArgumentException("Valor declarado no válido");
         
         //Aquí se calculará el costo del envío según las tarifas y reglas especificadas
         double costoBase = 0;
         switch (zona)
         { 
            // Determinamos el costo base según la zona
             case 1: costoBase = 60; break;
             case 2: costoBase = 100; break;
             case 3: costoBase = 150; break;
         }
      //aquí determinamos el recargo por peso
         double recargoPeso = 0;
         if (peso > 10) recargoPeso = 140;
         else if (peso > 5) recargoPeso = 80;
         else if (peso > 1) recargoPeso = 40;

         double subtotal = costoBase + recargoPeso; //formula para calcular el subtotal antes del servicio, seguro y descuento
         switch (tipoServicio)
         {
             case 2: subtotal *= 1.25; break;
             case 3: subtotal *= 1.5; break;
         }
             // Aquí se calcula el seguro si aplica
         double seguro = (valorDeclarado > 5000) ? valorDeclarado * 0.02 : 0;
         subtotal += seguro;
         double descuento = (subtotal > 700) ? subtotal * 0.05 : 0;
         double total = subtotal - descuento;

         Console.WriteLine($"Envío {(seguro > 0 ? "asegurado" : "sin seguro")}");
         Console.WriteLine($"Costo base: {costoBase:C2}");
         Console.WriteLine($"Recargo por peso: {recargoPeso:C2}");
         Console.WriteLine($"Subtotal: {subtotal:C2}");
         Console.WriteLine($"Seguro: {seguro:C2}");
         Console.WriteLine($"Descuento: {descuento:C2}");
         Console.WriteLine($"Total a pagar: {total:C2}");

            }
        private void validarZona(int zona) // Valida que la zona sea 1, 2 o 3
        {
            if (zona < 1 || zona > 3)
            {
                throw new ArgumentException("Zona inválida. Debe ser 1, 2 o 3.");
            }
        }

        private void validarPeso(double peso) // Valida que el peso sea mayor que cero
        {
            if (peso <= 0)
            {
                throw new ArgumentException("Peso inválido. Debe ser mayor que cero.");
            }
        }

        private void validarTipoServicio(int tipoServicio) // Valida que el tipo de servicio sea 1, 2 o 3
        {
            if (tipoServicio < 1 || tipoServicio > 3)
            {
                throw new ArgumentException("Tipo de servicio inválido. Debe ser 1, 2 o 3.");
            }
        }

        private void validarValorDeclarado(double valorDeclarado) // Valida que el valor declarado sea mayor o igual que cero
        {
            if (valorDeclarado < 0)
            {
                throw new ArgumentException("Valor declarado inválido. Debe ser mayor o igual que cero.");
            }
        }
        
        }
    }

