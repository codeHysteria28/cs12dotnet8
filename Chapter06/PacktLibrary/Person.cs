﻿namespace Packt.Shared;

public class Person
{
    #region Properties
    public string? Name { get; set; }
    public DateTimeOffset Born {  get; set; }
    public List<Person> Children = new();

    // Allow multiple spouses to be stored for a person
    public List<Person> Spouses = new();
    // A read-only property to show if a person is married to anyone.
    public bool Married => Spouses.Count > 0;
    #endregion

    #region Methods
    public void WriteToConsole()
    {
        WriteLine($"{Name} was born on a {Born:dddd}.");
    }

    public void WriteChildrenToConsole()
    {
        string term = Children.Count == 1 ? "child" : "children";
        WriteLine($"{Name} has {Children.Count} {term}");
    }

    // Static method to marry two people
    public static void Marry(Person p1,  Person p2)
    {
        ArgumentNullException.ThrowIfNull(p1);
        ArgumentNullException.ThrowIfNull(p2);

        if(p1.Spouses.Contains(p2))
        {
            throw new ArgumentException(
                string.Format("{0} is already married to {1}",
                arg0: p1.Name, arg1: p2.Name));
        }

        p1.Spouses.Add(p2);
        p2.Spouses.Add(p1);
    }

    // Instance method to marry another person.
    public void Marry(Person partner)
    {
        Marry(this, partner); // "this" is the current person
    }

    public void OutputSpouses()
    {
        if (Married)
        {
            string term = Spouses.Count == 1 ? "person" : "people";
            WriteLine($"{Name} is married to {Spouses.Count} {term}");

            foreach(Person spouse in Spouses)
            {
                WriteLine($"  {spouse.Name}");
            }

        }else
        {
            WriteLine($"{Name} is a singleton");
        }
    }

    public static Person Procreate(Person p1, Person p2)
    {
        ArgumentNullException.ThrowIfNull(p1);
        ArgumentNullException.ThrowIfNull(p2);

        if(!p1.Spouses.Contains(p2) && !p2.Spouses.Contains(p1))
        {
            throw new ArgumentException(string.Format(
                "{0} must be married to {1} to procreate with them.",
                arg0: p1.Name, arg1: p2.Name));
        }

        Person baby = new()
        {
            Name = $"Baby of {p1.Name} and {p2.Name}",
            Born = DateTimeOffset.Now
        };

        p1.Children.Add(baby);
        p2.Children.Add(baby);

        return baby;
    }

    // Instance method to multiply
    public Person ProcreateWith(Person partner)
    {
        return Procreate(this, partner);
    }
    #endregion
}