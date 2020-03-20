namespace CompositionBasedPolymorphism
{
    public interface IAnimal
    {
    }

    public interface IMakeNoise
    {
        string MakeNoise();
    }

    public interface ICanFly
    {
        string Fly();
    }

    public class Dog : IAnimal, IMakeNoise
    {
        public string MakeNoise() => "Bark";
    }

    public class Cat : IAnimal, IMakeNoise
    {
        public string MakeNoise() => "Meow";
    }

    public class Duck : IAnimal, IMakeNoise, ICanFly
    {
        public string MakeNoise() => "Quack";

        public string Fly() => "The duck flies away!";
    }
}
