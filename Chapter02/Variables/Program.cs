// namespace for working with XML files
using System.Xml;

// ! object can have assigned any type of data to it but it comes with messier code
// ! and performace degradation

object height = 1.88; // storing a double in an object
object name = "Amir"; // storing a string in an object

Console.WriteLine($"{name} is {height} metres tall.");

// int length1 = name.Length; // this give a compiler error
int length2 = ((string)name).Length; // cast name to a string

Console.WriteLine($"{name} has {length2} characters");

// ! dynamics is similar to object, due to it's flexibility it comes at the cost of performance
// ! unlike object, the value stored in the variable can have it's members invoked without an
// ! explicit cast

dynamic something;

// Storing an array of int values in a dynamic object.
// An array of any type has a Length property.
something = new[] { 3, 5, 7 };
// Storing an int in a dynamic object.
// int does not have a Length property.
something = 12;
// Storing a string in a dynamic object.
// string has a Lenght property
something = "Ahmed";
// This compiles but might throw an exception at run-time.
Console.WriteLine($"The Length an of something is {something.Length}");
// Output the type of the something variable.
Console.WriteLine($"Something is a {something.GetType()}");


// ! Local Variables
// int population = 67_000_000; 67 milion in UK
// double weight = 1.88; in kilograms
// decimal price = 4.99M; in pounds sterling
// string fruit = "Apples"; string values use double-quotes;
// char letter = 'Z'; char values use single-quotes
// bool happy = true; Boolenas can only be true or false

// * you can use "var" keyword to declare local variables, compiler will infer the
// * type from the value that is assigned after the = operator
// literal value without decimal point is inferred as an int variable
// L: long, UL: ulong, M: decimal, D: double, F: float

var population = 67_000_000;
var weight = 1.88;
var price = 4.99M;
var fruit = "Apples";
var letter = 'Z';
var happy = true;

// Good use of var because iot avoids the repeated type
// as shown in the more verbose second statement.
var xml1 = new XmlDocument(); // Works with C# 3 and later.
XmlDocument xml2 = new XmlDocument(); // Works with all C# versions.

// Bad use of var because we cannot tell the type,
// so we should use a specific type declarationas show in the
// second statement
var file1 = File.CreateText("something.txt");
StreamWriter file2 = File.CreateText("something2.txt");

// ! default values
Console.WriteLine($"default(int) = {default(int)}");
Console.WriteLine($"default(bool) = {default(bool)}");
Console.WriteLine($"default(DateTime) = {default(DateTime)}");
Console.WriteLine($"default(string) = {default(string)}");

int number = 13;
Console.WriteLine($"number set to: {number}");
number = default;
Console.WriteLine($"number reset to its default: {number}");