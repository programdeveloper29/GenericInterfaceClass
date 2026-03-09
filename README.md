# Generic Vehicles Demo (C#)

## Project Description

This is a **C# Console Application** created to practice several Object-Oriented Programming concepts while learning C#.

The program allows the user to create and display information for different vehicle types such as **Car** and **Train** using **Generics**.

## Concepts Practiced

* Classes
* Interfaces
* Generics
* Generic Constraints (`where`)
* User Input Validation
* Basic OOP Design

## Program Features

The user can choose between:

1 → Car
2 → Train
Other → Both

The program then asks the user to enter the required information such as:

* Passengers
* Brand (for Car)
* Speed (for Train)

## Class Structure

### Interface

`Ipassangers<T>`

Contains a common property:

* Passengers

### Classes

`Car<T,V>`

* Passengers
* Brand

`Train<T,V>`

* Passengers
* Speed

Both classes implement the `Ipassangers<T>` interface.

## Generics Usage

Generic methods are used to create objects of different types dynamically:

* `Print<C,T,V>()` for Car
* `Printt<C,T,V>()` for Train

This helps demonstrate how **generic constraints** work in C#.

## Technologies Used

* C#
* .NET Console Application
* Visual Studio

## Output
1=>Car
2=>Train
Other=>Both:3

Car Passengers: 4

Car Brand: Toyta

Passengers: 4
Brand: Toyota

Train Passengers: 200

Train Speed: 100

Passengers: 200
Speed: 100

Repeat('y'/'n'?:y
1=>Car
2=>Train
Other=>Both:1

Car Passengers: 3

Car Brand: Ford

Passengers: 3
Brand: Ford


## Educational Purpose

This project was created as part of learning **Object-Oriented Programming and Generics in C#**.
## Author
H.Ahmed
