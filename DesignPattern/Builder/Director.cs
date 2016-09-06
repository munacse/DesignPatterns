

namespace DesignPattern
{
    class Director
    {
        public void Constractor(IBuilder builder)
        {
            builder.Make();
        }
    }
}
