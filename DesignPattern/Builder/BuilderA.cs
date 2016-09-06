
using System;

namespace DesignPattern
{
    class BuilderA : IBuilder
    {
        public void Make()
        {
            Console.WriteLine("Builder A Call");
        }
    }
}
