using System;

namespace InheritanceBasedPolymorphism
{
    public abstract class Animal
    {
        public abstract string MakeNoise();
        public abstract string Fly();
    }

    public class Dog : Animal
    {
        public override string MakeNoise() => "Bark";

        public override string Fly() => throw new NotImplementedException();
    }

    public class Cat : Animal
    {
        public override string MakeNoise() => "Meow";

        public override string Fly() => throw new NotImplementedException();
    }

    public class Duck : Animal
    {
        public override string MakeNoise() => "Quack";

        public override string Fly() => "The duck flies away!";
    }
}
