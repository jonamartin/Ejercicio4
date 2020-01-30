using System;
using System.Collections.Generic;

namespace Ejercicio_4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero para apostar de 0 a 36");
            SumarOSacar var1 = new SumarOSacar();
            GenerarGanador var2 = new GenerarGanador();
            var1.agregarosacar(Convert.ToInt16(Console.ReadLine()));
            List<int> listapuestas = var1.apuestas;
            int ganad = var2.generarganador(listapuestas);
            Console.WriteLine("_______________________________");
            Console.WriteLine("|La cantidad de ganadores es {0}|",ganad);
            Console.WriteLine("________________________________");
            Console.WriteLine("|La cantidad de perdedores es {0}|",GenerarGanador.calcperd(listapuestas,ganad));
            Console.WriteLine("________________________________");
            Console.WriteLine("|    El numero ganador fue {0}  |",GenerarGanador.ran);
            Console.WriteLine("________________________________");
        }
    }
}

