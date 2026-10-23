namespace Prueba01
{
    public class Ejercicio03
    {
        public void Ejecutar()
        {
            Console.WriteLine("==INTAO LA ENTRADA COPAN==");
            
            //declaramos arreglo de cadenas de 10 participantes
            string[] participantes = new string[10];
            for (int i = 0; i < participantes.Length; i++)
            {
                Console.WriteLine($"Ingrese el nombre del participante {i + 1}: ");
                participantes[i] = Console.ReadLine() ?? string.Empty;
            }
            Console.WriteLine("Lista de participantes:");
            for (int i = 0; i < participantes.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {participantes[i]}");
            }
            
            //arreglo booleano de asistencia true = asistió false = falto
            bool[] asistencia = new bool[10];
            for (int i = 0; i < asistencia.Length; i++)
            {
                Console.WriteLine($"¿El participante {participantes[i]} asistió? (s/n): ");
                string respuesta = Console.ReadLine() ?? string.Empty;
                asistencia[i] = respuesta.ToLower() == "s";
            }
            Console.WriteLine("Lista de asistencia:");
            for (int i = 0; i < asistencia.Length; i++)
            {
                string estado = asistencia[i] ? "Asistió" : "Faltó";
                Console.WriteLine($"{participantes[i]}: {estado}");
            }

        }
    }
}