
using Delegate.Entities;
using Delegate.services;

delegate void MyDelegate(double x,double y);

public class Program
{
    public static void Main(string[] args)
    {
        int i = 2;
        if (i == 1)
        {

            MyDelegate myDelegate = CalculationServices.ShowMax;
            myDelegate += CalculationServices.ShowMin;
            myDelegate += CalculationServices.ShowSum;
            myDelegate(10, 20);
        }
        else if (i == 2) { 
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