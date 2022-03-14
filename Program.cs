using System;

namespace Structs
{
    class Program

    {
        static void Main(string[] args)
        {
            Product mouse = new Product(1, "Mouse Gamer", 200.0, EProductType.Product);
            Product manutencaoEletrica = new Product(2, "Manutenção elétrica residencial", 500, EProductType.Service);
            // mouse.Id = 55; // atribuição substitui o que foi definido anteriormente 

            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Name);
            Console.WriteLine(mouse.Price);
            Console.WriteLine(mouse.Type);

            Console.WriteLine(manutencaoEletrica.Id);
            Console.WriteLine(manutencaoEletrica.Name);
            Console.WriteLine(manutencaoEletrica.Price);
            Console.WriteLine(manutencaoEletrica.Type);
            Console.WriteLine("Number of service: " + (int)manutencaoEletrica.Type);

        }
    }

    struct Product
    {
        public Product(int id, string name, double price, EProductType type)
        {
            Id = id; //propriedade Id recebe parametro Id
            Name = name;
            Price = price;
            Type = type;

        }

        public int Id;
        public string Name;
        public double Price;
        public EProductType Type;

        public double PriceInDolar(double dolar)
        {
            return Price * dolar;
        }
    }

    enum EProductType
    {
        Product = 1,
        Service = 2
    }

}
