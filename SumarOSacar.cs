using System;
using System.Collections.Generic;
using Ejercicio_4;

public class SumarOSacar : Program
{
    public SumarOSacar()
    {
    }
    public List<int> apuestas = new List<int>();
    public List<int> agregarosacar(int num)
        {
            
              while(num<37 & num >=0) 
                        {
                        apuestas.Add(num);
                        num = Convert.ToInt16(Console.ReadLine());
                        }

             return apuestas;

        }
    
}
