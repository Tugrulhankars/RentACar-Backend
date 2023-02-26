using Business.Concrete;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.BrandName);
            }
        }
    }
}