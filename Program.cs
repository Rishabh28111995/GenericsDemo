namespace GenericsDemo;
class Program
{
    static void Main(string[] args)
    {
        Generics<int> generics = new Generics<int>(34);
        Generics<string> generics1 = new Generics<string>("Rishabh");
        Generics<double> generics2 = new Generics<double>(3.3444);
        Generics<char> generics3 = new Generics<char>('a');
        Generics<bool> generics4 = new Generics<bool>(true);
        Generics<float> generics5 = new Generics<float>(3.48F);
        generics.GetMethod(34);
        generics1.GetMethod("Sharma");
        generics2.GetMethod(29.39);
        generics3.GetMethod('r');
        generics4.GetMethod(false);
        generics5.GetMethod(3.432F);

        Generic generic = new Generic();
        generic.GenericMethod<int>(324);
        generic.GenericMethod<string>("Rishi");
        generic.GenericMethod<double>(23.678);
        generic.GenericMethod<char>('x');
        generic.GenericMethod<bool>(true);
        generic.GenericMethod<float>(3.678F);

    }
}

