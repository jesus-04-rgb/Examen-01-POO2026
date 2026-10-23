namespace Prueba01
{
    public class Ejercicio03
    {
        public void Ejecutar()
        {
            Console.WriteLine("==INTAO LA ENTRADA COPAN==");

            string[] participantes = new string[10] { "Ana", "Luis", "Carlos", "María", "José", "Elena", "Pedro", "Lucía", "Jorge", "Marta" };
            bool[] asistencia = new bool[10] { true, false, true, true, false, true, false, true, true, false };

            // Muestra lista de participantes con su asistencia
            for (int i = 0; i < participantes.Length; i++)
            {
                string estado = asistencia[i] ? "Asistió" : "Faltó";
                Console.WriteLine($"{participantes[i]}: {estado}");
            }

            // Cuenta y muestra cuántos asistieron y cuántos faltaron
            int totalAsistentes = 0;
            for (int i = 0; i < asistencia.Length; i++)
            {
                if (asistencia[i])
                {
                    totalAsistentes++;
                }
            }
            int totalFaltantes = asistencia.Length - totalAsistentes;
            Console.WriteLine($"Total de asistentes: {totalAsistentes}");
            Console.WriteLine($"Total de ausentes: {totalFaltantes}");

            // Calcula y muestra el porcentaje de asistencia
            double porcentajeAsistencia = (double)totalAsistentes / asistencia.Length * 100;
            Console.WriteLine($"Porcentaje de asistencia: {porcentajeAsistencia}%");

            // Muestra los nombres de quienes faltaron
            Console.WriteLine("Participantes que faltaron:");
            for (int i = 0; i < asistencia.Length; i++)
            {
                if (!asistencia[i])
                {
                    Console.WriteLine(participantes[i]);
                }
            }

            // Solicita un nombre y lo busca
            Console.Write("Ingrese un nombre para buscar: ");
            string nombreBuscado = Console.ReadLine() ?? string.Empty;
            if (!string.IsNullOrWhiteSpace(nombreBuscado))
            {
                bool encontrado = false;
                for (int i = 0; i < participantes.Length; i++)
                {
                    if (participantes[i].Equals(nombreBuscado, StringComparison.OrdinalIgnoreCase))
                    {
                        encontrado = true;
                        string estado = asistencia[i] ? "Asistió" : "Faltó";
                        Console.WriteLine($"Encontrado en la posición {i + 1}: {estado}");
                        break;
                    }
                }
                if (!encontrado)
                {
                    Console.WriteLine("No se encontró el participante.");
                }
            }
            else
            {
                Console.WriteLine("El nombre no puede estar vacío.");
            }

            // Muestra los nombres en orden inverso
            Console.WriteLine("Participantes en orden inverso:");
            for (int i = participantes.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(participantes[i]);
            }
        }
    }
}
