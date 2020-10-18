namespace AbstractClassVsInterface
{
    internal class Program
    {
        private static void Main()
        {
           Base b = new BaseImpl();

           b.MethodA();
           b.MethodB();
        }
    }
}
