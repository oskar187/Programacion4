using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ProductA : IProduct
    {
        public String Nombre { get; set; }
        public String Empresa { get; set; }
        public ProductA(String Empresa)
        {
            this.Empresa = Empresa;
        }

        public void doStuf()
        {
            Console.WriteLine(" - Estoy en ProductA / doStuf()");
            Console.WriteLine(" - Cargo: "+this.Nombre);
            Console.WriteLine(" - - - Empresa: "+this.Empresa);
        }
    }
}
