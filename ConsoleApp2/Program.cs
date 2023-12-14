//Задание 1 
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        List<IAnimal> animals = new List<IAnimal>();

        animals.Add(new Dog());
        animals.Add(new Cat());
        animals.Add(new Parrot());
        animals.Add(new Elephant());
        animals.Add(new Snake());

        foreach (var animal in animals)
        {
            animal.Voice();
        }
    }
}

public interface IAnimal
{
    void Voice();
}

public class Dog : IAnimal
{
    public void Voice()
    {
        Console.WriteLine("gav");
    }
}

public class Cat : IAnimal
{
    public void Voice()
    {
        Console.WriteLine("meow");
    }
}

public class Parrot : IAnimal
{
    public void Voice()
    {
        Console.WriteLine("kar kar");
    }
}

public class Elephant : IAnimal
{
    public void Voice()


    {
        Console.WriteLine("UUUUUU");
    }
}

public class Snake : IAnimal
{
    public void Voice()
    {
        Console.WriteLine("Shhhh");
    }
}
//Задание 2 
//using System;

namespace HelloWorld
{

    public interface IHello
    {
        void SayHello();
    }

    class EnglishHello : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Hello!");
        }
    }

    class FrenchHello : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Bonjour!");
        }
    }

    class GermanHello : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Hallo!");
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            List<IHello> greetings = new List<IHello>();
            greetings.Add(new EnglishHello());
            greetings.Add(new FrenchHello());
            greetings.Add(new GermanHello());

            foreach (IHello greeting in greetings)
            {
                greeting.SayHello();
            }
        }
    }
}
//Задание 3
﻿//using System;
//using System.Text.RegularExpressions;

interface IFilter
{
    string Execute(string textLine);
}

class DigitFilter : IFilter
{
    public string Execute(string textLine)
    {
        return Regex.Replace(textLine, "[0-9]", "");
    }
}

class LetterFilter : IFilter
{
    public string Execute(string textLine)
    {
        return Regex.Replace(textLine, "[a-zA-Z]", "");
    }
}

class ava
{
    static void Main()
    {
        DigitFilter digitFilter = new DigitFilter();
        LetterFilter letterFilter = new LetterFilter();

        string input = "a1b2c3d4e5f6";

        Console.WriteLine("Original: " + input);
        Console.WriteLine("Filtered Digits: " + digitFilter.Execute(input));
        Console.WriteLine("Filtered Letters: " + letterFilter.Execute(input));

        Console.ReadKey(true);
    }
}
//Задание 4 
//using System;

interface IShape
{
    void Draw(int size);
}

class VerticalLine : IShape
{
    public void Draw(int size)
    {
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("|");
        }
    }
}

class HorizontalLine : IShape
{
    public void Draw(int size)
    {
        for (int i = 0; i < size; i++)
        {
            Console.Write("-");
        }
        Console.WriteLine();
    }
}

class Square : IShape
{
    public void Draw(int size)
    {
        int side = size;
        for (int i = 1; i <= side * side; i++)
        {
            if (i % side == 0)
                Console.WriteLine();
            else
                Console.Write("*");

        }
    }
}