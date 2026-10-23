using System.Diagnostics;
using Prueba01;
Console.WriteLine("=== Menú de Ejercicios ===");
Console.Write("Seleccione un ejercicio (1-5): ");
int MenuEjercicios = Convert.ToInt32(Console.ReadLine());
switch (MenuEjercicios)
{
    case 1:
        Ejercicio01 ejercicio01 = new Ejercicio01();
        ejercicio01.Ejecutar();
        break;
    case 2:
        Ejercicio02 ejercicio02 = new Ejercicio02();
        ejercicio02.Ejecutar();
        break;
    case 3:
        Ejercicio03 ejercicio03 = new Ejercicio03();
        ejercicio03.Ejecutar();
        break;
    case 4:
        Ejercicio04 ejercicio04 = new Ejercicio04();
        ejercicio04.Ejecutar();
        break;
    case 5:
        Ejercicio05 ejercicio05 = new Ejercicio05();
        ejercicio05.Ejecutar();
        break;
    default:
        Console.WriteLine("Opción no válida");
        break;
}
// Ejercicio01 ejercicio01 = new Ejercicio01();
// ejercicio01.Ejecutar();
// Ejercicio02 ejercicio02 = new Ejercicio02();
// ejercicio02.Ejecutar();
// Ejercicio03 ejercicio03 = new Ejercicio03();
//  ejercicio03.Ejecutar();
//  Ejercicio04 ejercicio04 = new Ejercicio04();
// ejercicio04.Ejecutar();
// Ejercicio05 ejercicio05 = new Ejercicio05();
// ejercicio05.Ejecutar();
