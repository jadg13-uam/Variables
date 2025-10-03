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

        public static int GetEdadMinima()
        {
            int edadMin = edades[0];
            for(int i = 1; i < pos; i++)
            {
                if (edades[i] < edadMin) edadMin = edades[i];
            }
            return edadMin;

        }
        public static int GetMayores()
        {
            int edadMayor = 0;
            foreach (int edad in edades)
            {
                if (edad >= 18 && edad < 120)
                {
                    edadMayor++ ;
                }
            }
            return edadMayor;
        }

        public static int GetMenores()
        {
            int edadMenores = 0;
            foreach (int edad in edades)
            {
                if (edad > 0 && edad < 18)
                {
                    edadMenores++ ;
                }
            }
            return edadMenores;
        }
        

    }
}
