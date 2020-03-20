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

    public class Goose : Animal
    {
        public override string MakeNoise() => "Honk";

        public override string Fly() => "The goose flies away!";
    }
}
