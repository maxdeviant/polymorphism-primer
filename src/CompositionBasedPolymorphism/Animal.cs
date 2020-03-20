namespace CompositionBasedPolymorphism
{
    public interface IAnimal
    {
    }

    public interface IMakesNoise
    {
        string MakeNoise();
    }

    public interface ICanFly
    {
        string Fly();
    }

    public class Dog : IAnimal, IMakesNoise
    {
        public string MakeNoise() => "Bark";
    }

    public class Cat : IAnimal, IMakesNoise
    {
        public string MakeNoise() => "Meow";
    }

    public class Duck : IAnimal, IMakesNoise, ICanFly
    {
        public string MakeNoise() => "Quack";

        public string Fly() => "The duck flies away!";
    }
}
