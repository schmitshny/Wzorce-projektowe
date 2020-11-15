using System;
using System.Collections.Generic;
using System.Text;

namespace WzorceProjektowe
{
    class Lab7Bridge
    {
        public void Run()
        {
            Shape redSquare = new Square(new Blue());
            redSquare.draw(); 
            /*
            Shape blueTriangle = new Triangle(new Blue());
            blueTriangle.draw();
            */
        }
    }

    abstract class Shape
    {
        protected IColor color;

        public Shape(IColor color)
        {
            this.color = color;
        }

        protected abstract String getShapename();

        public void draw()
        {
            Console.WriteLine(color.getName() +" "+ getShapename());
        }
    }

    class Square : Shape
    {
        public Square(IColor color) : base(color)
        {
 
        }

        protected override String getShapename()
        {
            return "Square";
        }
    }

    interface IColor
    {
        public String getName();
    }

    class Red : IColor
    {
        public String getName()
        { 
            return "Red";
        }
    }

    class Blue : IColor
    {
        public String getName()
        {
            return "Blue";
        }
    }
}
