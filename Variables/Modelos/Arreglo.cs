using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.Modelos
{
    public class Arreglo
    {
        public static int[] edades = new int[10];
        public static int pos = 0;

        public static int GetPromedioI()
        {
            int prom = 0;
            int suma = 0;
            foreach (int edad in edades)
            {
                suma += edad;
            }
            prom = (int) suma / pos;

            return prom;
        }

        public static double GetPromedioD() {
            double prom = 0;
            double suma = 0;
            foreach (int edad in edades)
            {
                suma += edad;
            }
            prom = suma / pos;

            return prom;
        }

        public static int GetEdadMaxima()
        {
            int edadMaxima = 0;
            foreach(int edad in edades)
            {
                if (edad > edadMaxima)
                {
                    edadMaxima = edad;
                }
            }
            return edadMaxima;
        }
    }
}
