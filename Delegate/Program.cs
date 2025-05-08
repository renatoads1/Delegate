
using Delegate.Entities;
using Delegate.services;
using System.Linq;

delegate void MyDelegate(double x,double y);

public class Program
{
    public static void Main(string[] args)
    {
        int i = 4;
        if (i == 1)
        {

            MyDelegate myDelegate = CalculationServices.ShowMax;
            myDelegate += CalculationServices.ShowMin;
            myDelegate += CalculationServices.ShowSum;
            myDelegate(10, 20);
        }
        else if (i == 2)
        {
            List<Product> prod = new List<Product>();
            prod.Add(new Product("TV", 900.00));
            prod.Add(new Product("Mouse", 50.00));
            prod.Add(new Product("Tablet", 350.50));
            prod.Add(new Product("HD Case", 80.90));

            prod.RemoveAll(RemoveValorMaiorQue);
            //usando action
            prod.ForEach(UpdatePreceo);
            //delegate Func
            List<string> list = prod.Select(UpdateNome).ToList();
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
            //
        }
        else if (i == 3)
        {
            //fonte de dados 
            IEnumerable<int> nums = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //query expreção
            //var result = from n in nums
            //                 where n % 2 == 0
            //                 select n;
            //expressão lambda
            var result = nums.Where(n => n % 2 == 0).ToList();

            foreach (int n in result) { Console.WriteLine(n); };
        }
        else if (i == 4) {
            //linq com lambda
            Category c1 = new Category(1,"Electronics", 1);
            Category c2 = new Category(2,"Computers", 2);
            Category c3 = new Category(3,"TV", 3);
            List<Product> products = new List<Product>();
            products.Add(new Product(1, "TV", 900.00, 1000.00) { Category = c1 });
            products.Add(new Product(2, "Mouse", 50.00, 100.00) { Category = c2 });
            products.Add(new Product(3, "Tablet", 350.50, 500.00) { Category = c3 });
            products.Add(new Product(4, "HD Case", 80.90, 100.00) { Category = c1 });
            products.Add(new Product(5, "Monitor", 300.00, 400.00) { Category = c2 });
            products.Add(new Product(6, "Printer", 200.00, 300.00) { Category = c3 });

            var resp = products.Where(p => p.Price < 500).Select(p=>p.Nome);
            Printer("Produtos com preço menor que 500", resp);
            var resp2 = products.Where(p => p.Category.Tier == 1).Select(p => new { p.Nome, p.Price });
            Printer("Produtos com categoria 1", resp2);
            var resp3 = products.Where(p => p.Category.Tier == 1).Select(p => new { p.Nome, p.Price }).OrderByDescending(p => p.Price);
            Printer("Produtos com categoria 1 ordenados por preço decrescente", resp3);
            var resp4 = products.Where(p => p.Category.Tier == 1).Select(p => new { p.Nome, p.Price }).OrderByDescending(p => p.Price).FirstOrDefault();
            Console.WriteLine(resp4);
            var resp5 = products.Max(p => p.Price);
            Console.WriteLine("Maior preço: " + resp5);

        }
    }
    private static void Printer<T>(string msg,IEnumerable<T> colection) {
        Console.WriteLine(msg);
        foreach (T obj in colection)
        {
            Console.WriteLine(obj);
        }
    }
    private static bool RemoveValorMaiorQue(Product p)
    {
        return p.Valor > 100;
    }

    private static void UpdatePreceo(Product p)
    {
        p.Valor += p.Valor * 0.1;
    }
    private static string UpdateNome(Product p)
    {
        return p.Nome.ToUpper();
    }
}