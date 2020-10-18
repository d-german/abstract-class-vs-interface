namespace AbstractClassVsInterface
{
    internal class Program
    {
        private static void Main()
        {
           IBase b = new BaseImpl();

           b.MethodA();
           b.MethodB();
        }
    }
}
