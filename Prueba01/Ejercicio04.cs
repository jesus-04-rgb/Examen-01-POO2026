using System.ComponentModel;

namespace Prueba01
{
    public class Ejercicio04
    {
      public void Ejecutar()
      {  
        //aquí inicia la ejecución del programa del centro médico
          Console.WriteLine("===CENTRO MEDICO===");
          List<string> urgentes = new List<string>();
          List<string> normales = new List<string>();
          while (true)
          {
              Console.WriteLine("1. Registrar paciente");
              Console.WriteLine("2. Atender siguiente");
              Console.WriteLine("3. Mostrar fila");
              Console.WriteLine("4. Buscar paciente");
              Console.WriteLine("5. Mostrar cantidad");
              Console.WriteLine("6. Salir");
              Console.Write("Seleccione una opción: ");
              string opción = Console.ReadLine() ?? string.Empty;
              switch (opción)
              {
                  case "1":
                      Console.Write("Ingrese el nombre del paciente: ");
                      string nombre = Console.ReadLine() ?? string.Empty;
                      Console.Write("Es urgente? (s/n): ");
                      string urgente = Console.ReadLine() ?? string.Empty;
                      if (urgente.ToLower() == "s")
                      {
                          AddPaciente(urgentes, nombre);
                      }
                      else
                      {
                          AddPaciente(normales, nombre);
                      }
                      break;
                  case "2":
                      AtenderSiguiente(urgentes, normales);
                      break;
                  case "3":
                      MostrarFila(urgentes, normales);
                      break;
                  case "4":
                      Console.Write("Ingrese el nombre del paciente a buscar: ");
                      string nombreBuscar = Console.ReadLine() ?? string.Empty;
                      BuscarPaciente(urgentes, normales, nombreBuscar);
                      break;
                  case "5":
                      MostrarCantidad(urgentes, normales);  
                      break;
                  case "6":
                      return;
                  default:
                      Console.WriteLine("Opción no válida");
                      break;

              }
          }  
      }

        private void MostrarCantidad(List<string> urgentes, List<string> normales)
        {
            throw new NotImplementedException();
        }

        private void BuscarPaciente(List<string> urgentes, List<string> normales, string nombreBuscar)
        {
            throw new NotImplementedException();
        }

        //método Add paciente a la lista correspondiente
        public static void AddPaciente(List<string> lista, string nombre)
      {
          lista.Add(nombre);
           if (lista.Contains("Juan"))
           {
               int posición = lista.IndexOf("Juan") + 1;
               int pacientesDelante = posición - 1;
               Console.WriteLine($"Paciente 'Juan' en posición {posición}, con {pacientesDelante} pacientes delante");
           }
      }
      //método remover paciente y Atender siguiente
       public static void AtenderSiguiente(List<string> urgentes, List<string> normales)
      {
          if (urgentes.Count > 0)
          {
              Console.WriteLine($"Atendiendo paciente urgente: {urgentes[0]}");
              urgentes.RemoveAt(0);
          }
          else if (normales.Count > 0)
          {
              Console.WriteLine($"Atendiendo paciente normal: {normales[0]}");
              normales.RemoveAt(0);
          }
          else
          {
              Console.WriteLine("No hay pacientes en espera");
          }
           // aquí se utilizo Contains, IndexOf y Count se pueden usar para verificar si un paciente está en la lista y su posición
           if (urgentes.Contains("Juan"))
           {
               int posición = urgentes.IndexOf("Juan") + 1;
               int pacientesDelante = posición - 1;
               Console.WriteLine($"Paciente urgente 'Juan' en posición {posición}, con {pacientesDelante} pacientes delante");
           }
           if (normales.Contains("Juan"))
           {
               int posición = normales.IndexOf("Juan") + 1;
               int pacientesDelante = posición - 1;
               Console.WriteLine($"Paciente normal 'Juan' en posición {posición}, con {pacientesDelante} pacientes delante");
           }
      }
        //creamos un método para mostrar la fila de pacientes
      public static void MostrarFila(List<string> urgentes, List<string> normales)
      {
          Console.WriteLine("Pacientes urgentes:");
          MostrarLista(urgentes);
          Console.WriteLine("Pacientes normales:");
          MostrarLista(normales);
      }

//creamos un método para mostrar la lista de pacientes
      private static void MostrarLista(List<string> pacientes)
      {
          if (pacientes.Count == 0)
          {
              Console.WriteLine("No hay pacientes en espera");
              return;
          }

          for (int i = 0; i < pacientes.Count; i++)
          {
              Console.WriteLine($"{i + 1}. {pacientes[i]}");
          }
      }
   }
}

