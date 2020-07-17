using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory standardFactory=new StandardFactory();
            OnlineStore onlineStore=new OnlineStore(standardFactory);
        }
    }
}
