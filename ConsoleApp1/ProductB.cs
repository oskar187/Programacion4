using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ProductB : IProduct
    {
        public String Nombre { get; set; }
        public String Marca { get; set; }
        public int Año { get; set; }

        public ProductB(String Marca, int Año)
        {
            this.Marca = Marca;
            this.Año = Año;
        }

        public void doStuf()
        {
            Console.WriteLine(" - Estoy en ProductB / doStuf()");
            Console.WriteLine(" - - - Nombre Producto: " + this.Nombre);
            Console.WriteLine(" - - - Año: " + this.Año);
            Console.WriteLine(" - - - Marca: " + this.Marca);
        }
    }
}