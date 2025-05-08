
using Delegate.services;

delegate void MyDelegate(double x,double y);

public class Program
{
    public static void Main(string[] args)
    {
        MyDelegate myDelegate = CalculationServices.ShowMax;
        myDelegate += CalculationServices.ShowMin;
        myDelegate += CalculationServices.ShowSum;
        myDelegate(10, 20);
    }
}