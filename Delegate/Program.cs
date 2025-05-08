
using Delegate.Entities;
using Delegate.services;
using System.Linq;

delegate void MyDelegate(double x,double y);

public class Program
{
    public static void Main(string[] args)
    {
        int i = 3;
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
        else if (i == 3) { 
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