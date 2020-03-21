{-# OPTIONS -Wall #-}

module Animal
  ( Animal(..)
  , Dog(..)
  , Cat(..)
  , Goose(..)
  , MakeNoise(..)
  , CanFly(..)
  ) where

class MakeNoise a where
  makeNoise :: a -> String

class CanFly a where
  fly :: a -> String

data Animal
  = Dog' Dog
  | Cat' Cat
  | Goose' Goose
  deriving (Show)

data Dog =
  Dog
  deriving (Show)

instance MakeNoise Dog where
  makeNoise _ = "Bark"

data Cat =
  Cat
  deriving (Show)

instance MakeNoise Cat where
  makeNoise _ = "Meow"

data Goose =
  Goose
  deriving (Show)

instance MakeNoise Goose where
  makeNoise _ = "Honk"

instance CanFly Goose where
  fly _ = "The goose flies away!"
