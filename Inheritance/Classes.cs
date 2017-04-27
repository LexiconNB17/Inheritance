namespace Inheritance
{
    interface Interface1
    {
        string I1();
    }
    interface Interface2
    {
        int I1();
        string I2();
    }

    abstract class AbstractClass {
        public int AProp { get; set; }
        public AbstractClass() { AProp = 1; }
        public AbstractClass(int prop) { AProp = prop; }

        public abstract string Abstract();
        public virtual string Concrete() => "Abstract:Concrete";
    }

    class AClass : AbstractClass, Interface1
    {
        public AClass(int prop) : base(prop) { }

        public virtual string Override() => "A:Override";
        public string Hidden() => "A:Hidden";
        public override string Abstract() => "A:Abstract";
        public virtual string I1() => "A:I1";
    }

    class BClass : AClass, Interface2
    {
        public BClass() : base(3) { }

        public override string Override() => "B:Override";
        public new string Hidden() => "B:Hidden";
        public override string Concrete() => "B:Concrete";
        public string I2() => "B:I2";
        public override string I1() => "B:I1";
        int Interface2.I1() => 1;
    }
}
