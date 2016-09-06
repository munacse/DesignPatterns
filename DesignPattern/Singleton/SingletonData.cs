using System;

namespace DesignPattern
{
    public class SingletonData
    {
        //The Mutex type ensures blocks of code are executed only once at a time
        public static readonly object mutex = new object();
        private static SingletonData _instance;

        public SingletonData()
        {
            Console.WriteLine("Instance is crated");
        }

        public static SingletonData Instance()
        {
            if(_instance == null)
            {
                lock(mutex)
                {
                    if(_instance == null)
                    {
                        _instance = new SingletonData();
                    }
                }
                
            }
            return _instance;
        }
    }
}
