using System;

namespace AbstractClassVsInterface
{
    public interface IBase
    {
        void MethodA();
        void MethodB();
    }

    public class BaseImpl : IBase
    {
        public void MethodA()
        {
            Console.WriteLine($"{nameof(MethodA)} implementation");
        }

        public void MethodB()
        {
            Console.WriteLine($"{nameof(MethodB)} implementation");
        }
    }
}
