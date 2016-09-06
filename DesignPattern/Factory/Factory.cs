
namespace DesignPattern
{
    static class Factory
    {
        public static Position Get(int position)
        {
            switch (position)
            {
                case 0:
                    return new Manager();
                case 1:
                case 2:
                    return new Clerk();
                default:
                    return new Programmer();
            }
        }
    }
}
