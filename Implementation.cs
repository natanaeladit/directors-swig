namespace example
{
    public class Implementation
    {
        public static void Main()
        {
            Caller myCaller = new Caller();

            // Test pure C++ class
            using (Base myBase = new Base())
            {
                makeCalls(myCaller, myBase);
            }

            // Test director / C# derived class
            using (Base myBase = new CSharpDerived())
            {
                makeCalls(myCaller, myBase);
            }
        }

        static void makeCalls(Caller myCaller, Base myBase)
        {
            myCaller.set(myBase);
            myCaller.UIntMethodCall(123);
            myCaller.reset();
        }
    }
}