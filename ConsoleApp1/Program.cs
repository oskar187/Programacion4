// See https://aka.ms/new-console-template for more information

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Creator> lista = new List<Creator>();

            lista.Add(new CreateProductA("Empacador"));
            lista.Add(new CreateProductA("Gerente"));
            lista.Add(new CreateProductB("X85K | 4K Ultra HD | Alto rango dinámico (HDR) | Smart TV"));
            lista.Add(new CreateProductB("X90K | BRAVIA XR | Full Array LED | 4K Ultra HD | Alto rango dinámico (HDR) | Smart TV"));
            lista.Add(new CreateProductB("A80K | BRAVIA XR | OLED | 4K Ultra HD | Alto Rango Dinámico (HDR) | Smart TV"));

            foreach(Creator creator in lista)
            {
                creator.SomeOperation();
            }
        }
    }

}




