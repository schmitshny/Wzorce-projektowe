using System;
using System.Numerics;

namespace factory
{
    class Program
    {
        static void Main(string[] args)
        {
            new Lab5FactoryMethod().Run();
        }
    }

    class Lab5FactoryMethod
    {
        public void Run()
        {
            Console.WriteLine("Witamy na targach samochodowych");
            MakeCarShow(new BmwFactory());
            MakeCarShow(new SkodaFactory());
        }
        void MakeCarShow(CarFactory carFactory)
        {
            carFactory.PresentBrandNewCar();
        }
    }

    abstract class CarFactory
    {
       public void PresentBrandNewCar()
        {
            ICar car = FactoryMethodMakeCar();
            Console.WriteLine("Witamy na pokazie samochodów " + car.GetType().Name);
            Console.WriteLine("Teraz zobaczmy jak działają kierunkowskazy");
            car.ShowTurnSignal();
            Console.WriteLine("Koniec pokazu.");
            Console.WriteLine();
        }
        public abstract ICar FactoryMethodMakeCar();
    }

    class BmwFactory : CarFactory
    {
        public override ICar FactoryMethodMakeCar()
        {
            return new BMW();
        }
 
    }

    class SkodaFactory : CarFactory
    {
        public override ICar FactoryMethodMakeCar()
        {
            return new Skoda();
        }

    }

    interface ICar
    {
        public void ShowTurnSignal();
    }
    class BMW : ICar
    {
        public void ShowTurnSignal()
        {
            Console.WriteLine("Kierowcy i tak ich nie uzywają, więc w tym modelu nie dodaliśmy kierunkowskazów");
        }
    }

    class Skoda : ICar
    {
        public void ShowTurnSignal()
        {
            Console.WriteLine("Zobaczcie pięknie migające migacze");
        }
    }
}

