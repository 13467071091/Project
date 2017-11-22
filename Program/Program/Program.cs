using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            Fu[] arr = { new Circle(5),new Rect(3,4),new Square(5)};
            foreach (Fu ele in arr)
            {
                ele.Jisuan();
            }
        }
    }

    abstract class Fu
    {
        protected float length;

        public Fu(float num)
        {
            length = num;
        }

        public abstract void Jisuan(); 

    }

    class Circle : Fu
    {
        public Circle(float length) : base(length) { }       

        public override void Jisuan()
        {
            Console.WriteLine("圆形周长为"+length*2*Math.PI);
            Console.WriteLine("圆形面积为" + length*length*Math.PI);
        }
    }

    class Rect : Fu
    {
        float width;
        public Rect(float length,float width) : base(length)
        {
            this.width = width;
        }

        public override void Jisuan()
        {
            Console.WriteLine("矩形周长为" + (length+width) * 2 );
            Console.WriteLine("矩形面积为" + length * width);
        }
    }

    class Square : Fu
    {       
        public Square(float length) : base(length){}

        public override void Jisuan()
        {
            Console.WriteLine("正方形周长为" + length * 4);
            Console.WriteLine("正方形面积为" + length * length);
        }
    }

}
