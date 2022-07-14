using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CreateProductA : Creator
    {
        public CreateProductA(string Nombre) : base(Nombre)
        {
            this.Nombre = Nombre;
        }
        public override IProduct CreateProduct(String Nombre)
        {
            Console.WriteLine(" - CreateProductA / CreateProduct()");

            ProductA product = new ProductA("Amazon");
            product.Nombre=Nombre;

            return product;
        }
    }
}