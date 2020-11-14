using System;

namespace WzorceProjektowe
{
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
            ITable table = roomFactory.createTable();
            Console.WriteLine(table.show());
            Console.WriteLine();
        }
    }

    interface IRoomFactory
    {
        public IChair createChair();
        public ISofa createSofa();
        public ITable createTable();
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
        public ITable createTable()
        {
            return new MarcinTable();
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
    interface ITable
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
    class MarcinTable : ITable
    {
        public String show()
        {
            return "Marcin table";
        }
    }
}
