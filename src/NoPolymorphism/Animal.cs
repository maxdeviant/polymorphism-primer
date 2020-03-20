using System;

namespace NoPolymorphism
{
    public enum AnimalKind
    {
        Dog,
        Cat,
        Duck
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

                case AnimalKind.Duck:
                    return "Quack";

                default:
                    throw new ArgumentOutOfRangeException(nameof(Kind));
            }
        }

        public string Fly()
        {
            switch (Kind)
            {
                case AnimalKind.Duck:
                    return "The duck flies away!";

                case AnimalKind.Dog:
                case AnimalKind.Cat:
                    throw new NotImplementedException();

                default:
                    throw new ArgumentOutOfRangeException(nameof(Kind));
            }
        }
    }
}
