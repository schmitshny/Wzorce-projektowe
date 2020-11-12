using System;

namespace labs 
{

    class Program
    { static void Main(string[] args)
        {
            new Lab6AbstractFactory().Run();
        }

    }

    class Lab6AbstractFactory
    {
        public void Run()
        {
            Console.WriteLine("Witamy w salonie z meblami");
            ShowRoomProject(new IkeaFactory());
        }
        void ShowRoomProject(IRoomFactory roomFactory)
        {
            Console.WriteLine();
            Console.WriteLine("Budujemy pokoj w stylu " + roomFactory.GetType().Name);
            Console.WriteLine("Pokoj będzię się składał z:");
            IChair chair = roomFactory.createChair();
            Console.WriteLine(chair.show());
            ISofa sofa = roomFactory.createSofa();
            Console.WriteLine(sofa.show());
            Console.WriteLine();
        }
    }

    interface IRoomFactory
    {
        public IChair createChair();
        public ISofa createSofa();
    }

    class IkeaFactory : IRoomFactory
    {
        public IChair createChair()
        {
            return new MarkusChair();
        }
        public ISofa createSofa()
        {
            return new HemnesSofa();
        }
    }

    interface IChair
    {
        public String show();
    }
    interface ISofa
    {
        public String show();
    }

    class MarkusChair : IChair
    {
        public String show()
        {
            return ("Markus chair");
        }
    }

    class HemnesSofa : ISofa
    {
        public String show()
        {
            return "Hemnes sofa";
        }
    }
}
