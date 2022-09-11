using DesignPatterns.AbstractFactory;
using DesignPatterns.Factory;
using DesignPatterns.Strategy;
using System;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContextStrategy cnt = new ContextStrategy(new Zip());
            cnt.CreateArchive("hello from main1");

            cnt.SetStrategy(new rar());
            cnt.CreateArchive("hello from main2");
        }
    }
   
}
