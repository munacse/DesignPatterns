using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Builder
{
    class BuilderB : IBuilder
    {
        public void Make()
        {
            Console.WriteLine("Builder B Call");
        }
    }
}
