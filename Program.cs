using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.calcule_las_funciones_trigonométricas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seleccione una función trigonométrica:"); //Aqui establecemos para que el usuario eliga, la figura que desea calcular.
            Console.WriteLine("1. Seno");
            Console.WriteLine("2. Coseno");
            Console.WriteLine("3. Secante");
            Console.WriteLine("4. Cosecante");
            Console.WriteLine("5. Tangente");
            Console.WriteLine("6. Cotangente");
            int option = int.Parse(Console.ReadLine()); //Convierte la representación en forma de cadena de un número en el entero de 32 bits con signo equivalente.

            Console.WriteLine("Ingrese el ángulo en grados:");
            double angle = double.Parse(Console.ReadLine()); //Convierte la representación en forma de cadena de un número en el número de punto flotante de precisión doble equivalente.

            double radians = angle * (Math.PI / 180); //variable local 

            if (option == 1) //selecciona una instrucción que se va a ejecutar en función del valor de una expresión booleana
            {
                Console.WriteLine("El seno de " + angle + " grados es: " + Math.Sin(radians));
                Console.ReadLine();//para imprimir en pantalla el resultado de la operación.
            }
            else if (option == 2) //para elegir dos rutas de acceso distintas en función de la expresión booleana. 
            {
                Console.WriteLine("El coseno de " + angle + " grados es: " + Math.Cos(radians));
                Console.ReadLine();//para imprimir en pantalla el resultado de la operación.
            }
            else if (option == 3)
            {
                Console.WriteLine("La secante de " + angle + " grados es: " + (1 / Math.Cos(radians)));
                Console.ReadLine();//para imprimir en pantalla el resultado de la operación.
            }
            else if (option == 4)
            {
                Console.WriteLine("La cosecante de " + angle + " grados es: " + (1 / Math.Sin(radians)));
                Console.ReadLine();//para imprimir en pantalla el resultado de la operación.
            }
            else if (option == 5)
            {
                Console.WriteLine("La tangente de " + angle + " grados es: " + Math.Tan(radians));
                Console.ReadLine();//para imprimir en pantalla el resultado de la operación.
            }
            else if (option == 6)
            {
                Console.WriteLine("La cotangente de " + angle + " grados es: " + (1 / Math.Tan(radians)));
                Console.ReadLine();//para imprimir en pantalla el resultado de la operación.
            }
            else
            {
                Console.WriteLine("Opción inválida.");
                Console.ReadLine();//para imprimir en pantalla el resultado de la operación.
            }
        }
    }
}
