using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo = new Triangulo();
            triangulo.color = "Azulita";
            Console.WriteLine(triangulo.ToString());
            Console.Read();
        }
    }
}
