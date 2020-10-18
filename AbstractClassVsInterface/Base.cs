using System;

namespace AbstractClassVsInterface
{
    public abstract class Base
    {
        public abstract void MethodA();

        public virtual void MethodB()
        {
            Console.WriteLine($"{nameof(MethodB)} implementation");
        }
    }

    public class BaseImpl : Base
    {
        public override void MethodA()
        {
            Console.WriteLine($"{nameof(MethodA)} implementation");
        }
    }
}