namespace FSharpPolymorphism

type Animal =
    | Dog
    | Cat
    | Goose

module Animal =
    let makeNoise animal =
        match animal with
        | Dog -> "Bark"
        | Cat -> "Meow"
        | Goose -> "Honk"

    let fly animal =
        match animal with
        | Goose -> Some "The goose flies away!"
        | Dog
        | Cat -> None
