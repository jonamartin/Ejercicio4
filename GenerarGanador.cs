using System;
using System.Collections.Generic;
using Ejercicio_4;

public class GenerarGanador : SumarOSacar
{
   public GenerarGanador()
    {

    }
    public static int cantidadganadores;
    public static int perdedores;
    public static Random random = new Random();
    public static int ran = random.Next(0,37);
    public int generarganador(List<int> lista)
    
        {
            foreach (var li in lista)
            {
                if(li == ran)
                    {
                     cantidadganadores++;
                    }
            }
            return cantidadganadores;
        }
    public static int calcperd(List<int> listados,int num)
        {
           int total = listados.Count;
           perdedores = total-num;
           return perdedores;
        }
}