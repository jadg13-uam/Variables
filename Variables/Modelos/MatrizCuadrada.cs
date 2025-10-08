using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables.Modelos
{
    public class MatrizCuadrada
    {
        public int Tamaño { set; get; }
        int[,] matrizC;
       
        public  int f { set { f = Tamaño; } get { return f; } } 
        public int c { set { c = Tamaño; } get { return c; } }

        public MatrizCuadrada(int tamaño)
        {
            this.Tamaño = tamaño;
            matrizC = new int[f, c];
        }

    }
}
