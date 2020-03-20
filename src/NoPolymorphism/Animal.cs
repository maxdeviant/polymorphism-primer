using System;

namespace NoPolymorphism
{
    public enum AnimalKind
    {
        Dog,
        Cat,
        Goose
    }

    public class Animal
    {
        public AnimalKind Kind { get; }

        public Animal(AnimalKind kind)
        {
            Kind = kind;
        }

        public string MakeNoise()
        {
            switch (Kind)
            {
                case AnimalKind.Dog:
                    return "Bark";

                case AnimalKind.Cat:
                    return "Meow";

                case AnimalKind.Goose:
                    return "Honk";

                default:
                    throw new ArgumentOutOfRangeException(nameof(Kind));
            }
        }

        public string Fly()
        {
            switch (Kind)
            {
                case AnimalKind.Goose:
                    return "The goose flies away!";

                case AnimalKind.Dog:
                case AnimalKind.Cat:
                    throw new NotImplementedException();

                default:
                    throw new ArgumentOutOfRangeException(nameof(Kind));
            }
        }
    }
}
