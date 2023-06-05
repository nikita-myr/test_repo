using System;

namespace Blank 
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SomeClass someClass = new SomeClass();
            someClass.SomeVoid();




        }
    }

    public abstract class AbstractClass
    {
        public virtual void SomeVoid()
        {
            Console.WriteLine("Hello world");
        }
    }

    class SomeClass : IInterface
    {
        public void 
        
    }

    interface IInterface
    {
        void InterfaceVoid();

    }
    
    
    
}

