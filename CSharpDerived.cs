namespace example
{
    public class CSharpDerived : Base
    {
        public override uint UIntMethod(uint x)
        {
            Console.WriteLine("CSharpDerived - UIntMethod({0})", x);
            return x;
        }
    }
}