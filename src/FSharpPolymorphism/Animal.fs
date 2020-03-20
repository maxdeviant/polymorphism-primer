namespace FSharpPolymorphism

type Animal =
    | Dog
    | Cat
    | Duck

module Animal =
    let makeNoise animal =
        match animal with
        | Dog -> "Bark"
        | Cat -> "Meow"
        | Duck -> "Quack"

    let fly animal =
        match animal with
        | Duck -> Some "The duck flies away!"
        | Dog
        | Cat -> None
