
using System;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Builder Pattern
            Director director = new Director();
            IBuilder builderA = new BuilderA();
            director.Constractor(builderA);

            //Singleton Pattern
            SingletonData singletonData = SingletonData.Instance();
            SingletonData singletonData2 = SingletonData.Instance();

            //Factory Pattern
            var position = Factory.Get(1);
            Console.WriteLine(position.Title);


            //Facade Pattern
            var shapeCreator = new ShapeCreatorFacade();
            shapeCreator.DrawCircle();
            shapeCreator.DrawRectangle();
            shapeCreator.DrawSquare();

            Console.ReadKey();
        }
    }
}
