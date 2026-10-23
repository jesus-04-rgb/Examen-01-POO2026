namespace Prueba01
{
    public class Ejercicio02
    {
        public void Ejecutar()
        {
            //aquí inicia la ejecución del programa de la estación de servicio
            Console.WriteLine("==Estación de servicio LA RACHA==");

            Console.WriteLine("Ingrese el tipo de combustible que desea echarle (1 = Regular, 2 = Premium, 3 =Diesel): ");
            int tipoCombustible = int.Parse(Console.ReadLine() ?? string.Empty);
            tipoCombustible = (tipoCombustible >= 1 && tipoCombustible <= 3) ? tipoCombustible : throw new ArgumentException("Tipo de combustible no válido");
            
            //valida que el tipo de combustible ingresado sea correcto
            Console.WriteLine("Ingrese la cantidad de litros que desea echarle (60 litros máximo): ");
            double cantidadLitros = double.Parse(Console.ReadLine() ?? string.Empty);
            cantidadLitros = (cantidadLitros > 0 && cantidadLitros <= 60) ? cantidadLitros : throw new ArgumentException("Cantidad de litros no válida");
            double precioPorLitro;
            switch (tipoCombustible)
            {
                case 1:
                    precioPorLitro = 28.50;
                    break;
                case 2:
                    precioPorLitro = 32.00;
                    break;
                case 3:
                    precioPorLitro = 26.75;
                    break;
                default:
                    throw new ArgumentException("Tipo de combustible no válido");
            }
            double total = cantidadLitros * precioPorLitro;
            Console.WriteLine($"Total a pagar: {total:C}");
            Console.WriteLine($"Precio por litro: {precioPorLitro:C}");

            //bomba carga en bloques de 5L
            while (cantidadLitros % 5 != 0)
            {
                Console.WriteLine("La cantidad de litros debe ser un múltiplo de 5. Ingrese nuevamente: ");
                cantidadLitros = double.Parse(Console.ReadLine() ?? string.Empty);
                cantidadLitros = (cantidadLitros > 0 && cantidadLitros <= 60) ? cantidadLitros : throw new ArgumentException("Cantidad de litros no válida");
            }
            total = cantidadLitros * precioPorLitro;
            Console.WriteLine($"Total a pagar actualizado: {total:C}");
            Console.WriteLine($"Precio por litro: {precioPorLitro:C}");

            //mostrar cuantos litros se han cargado
            Console.WriteLine($"Litros cargados: {cantidadLitros}");

            //calculo del subtotal
            double subtotal = cantidadLitros * precioPorLitro; //subtotal = litros cargados * precio por litro
            Console.WriteLine($"Subtotal: {subtotal:C}");

            //aquí se aplica el descuento según el subtotal
            double descuento = 0;
            if (subtotal >= 1500)
            {
                descuento = subtotal * 0.05;
            }
            else if (subtotal >= 1000)
            {
                descuento = subtotal * 0.03;
            }
            double totalConDescuento = subtotal - descuento;
            Console.WriteLine($"Descuento: {descuento:C}");
            Console.WriteLine($"Total con descuento: {totalConDescuento:C}");
            
            //mostrar total litros, subtotal y total con descuento
            Console.WriteLine($"Total litros: {cantidadLitros}");
            Console.WriteLine($"Subtotal: {subtotal:C}");
            Console.WriteLine($"Total con descuento: {totalConDescuento:C}");
        }

    }
}