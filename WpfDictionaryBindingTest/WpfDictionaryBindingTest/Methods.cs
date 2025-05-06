namespace WpfDictionaryBindingTest
{
    public abstract class BaseMethod
    {
        public string Name
        { get; protected set; } = "";

        public abstract int Execute(int n1, int n2);
    }

    public class Add : BaseMethod
    {
        public Add()
        {
            Name = "AddMethod";
        }

        public override int Execute(int n1, int n2)
        {
            return n1 + n2;
        }
    }

    public class Sub : BaseMethod
    {
        public Sub()
        {
            Name = "SubMehtod";
        }

        public override int Execute(int n1, int n2)
        {
            return n1 - n2;
        }
    }

    public class Mul : BaseMethod
    {
        public Mul()
        {
            Name = "MulMethod";
        }

        public override int Execute(int n1, int n2)
        {
            return n1 * n2;
        }
    }
}
