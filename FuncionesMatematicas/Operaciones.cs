using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncionesMatematicas
{
    class Operaciones
    {
        //sumar
        public int sumar(int a, int b) {
            return a + b;
        }
        //restar
        public int restar(int a, int b)
        {
            return a - b;
        }
        //multiplicar
        public int multiplicar(int a, int b)
        {
            return a * b;
        }
        //dividir
        public float dividir(int a, int b)
        {
            return (float)a / (float)b;
        }

    }
}
