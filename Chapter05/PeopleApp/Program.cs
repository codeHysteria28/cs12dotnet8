﻿using Packt.Shared; // to use Person

ConfigureConsole(); // sets current culture to EU English

// Alternatives:

// ConfigureConsole(useComputerCulture: true); // Use your culture
// ConfigureConsole(culture: "fr-FR"); // use French culture
Person bob = new();

bob.Name = "Bob Smith";
bob.Born = new DateTimeOffset(
    year: 1965, month: 12, day: 22,
    hour: 16, minute: 28, second: 0,
    offset: TimeSpan.FromHours(-5)); // US Eastern Standard Time
bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
bob.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;// bob.BucketList = (WondersOfTheAncientWorld)18;

WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}");

WriteLine(format: "{0} was born on {1:D}.", // long date
arg0: bob.Name, arg1: bob.Born);

WriteLine(format: "{0}'s favorite wonder is {1}. It's integer is {2}",
arg0: bob.Name, arg1: bob.FavoriteAncientWonder, arg2: (int)bob.FavoriteAncientWonder);

Person alice = new()
{
    Name = "Alice Jones",
    Born = new (1998, 3, 7, 16, 28, 0,
    // this is a optional offset from UTC time zone 
    TimeSpan.Zero)
};

WriteLine(format: "{0} was born on {1:d}.", // short date
arg0: alice.Name, arg1: alice.Born);

// Works with all C# versions
Person alfred = new Person();
alfred.Name = "Alfred";
bob.Children.Add(alfred);
// works with C# 3 and later
bob.Children.Add(new Person { Name = "Bella" });
// works with C# 9 and later
bob.Children.Add(new(){Name = "Zoe"});

WriteLine($"{bob.Name} has {bob.Children.Count} children");

for(int childIndex = 0; childIndex < bob.Children.Count; childIndex++){
    WriteLine($"> {bob.Children[childIndex].Name}");
}

// BankAccount
BankAccount.InterestRate = 0.012M; // store a shared value in static field
BankAccount jonesAccount = new();
jonesAccount.AccountName = "Mrs.Jones";
jonesAccount.Balance = 2400;

WriteLine(format: "{0} earned {1:C} of interest",
    arg0: jonesAccount.AccountName,
    arg1: jonesAccount.Balance * BankAccount.InterestRate
);

BankAccount gerrierAccount = new();
gerrierAccount.AccountName = "Ms.Gerrier";
gerrierAccount.Balance = 98;

WriteLine(format: "{0} earned {1:C} of interest",
    arg0: gerrierAccount.AccountName,
    arg1: gerrierAccount.Balance * BankAccount.InterestRate
);

// Constant fields are accessible via the type
WriteLine($"{bob.Name} is a {Person.Species}");

// Read-only fields are accesible via the variable
WriteLine($"{bob.Name} was bor on {bob.HomePlanet}");

// required
// Book book = new()
// {
//     Isbn = "978-1803237800",
//     Title = "C# 12 and .NET 8 - Modern Cross-Platform Development Fundamentals"
// };

Book book = new(isbn: "978-1803237800", title: "C# 12 and .NET 8 - Modern Cross-Platform Development Fundamentals")
{
    Author = "Mark J.Price", 
    PageCount = 821
};

WriteLine("{0}: {1} written by {2} has {3:N0} pages",
book.Isbn, book.Title, book.Author, book.PageCount
);

// constructors

Person blankPerson = new();
WriteLine(format:
"{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
arg0: blankPerson.Name,
arg1: blankPerson.HomePlanet,
arg2: blankPerson.Instantiated
);

Person gunny = new(initialName: "Gunny", homePlanet: "Mars");
WriteLine(format:
"{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
arg0: gunny.Name,
arg1: gunny.HomePlanet,
arg2: gunny.Instantiated
);

// methods

bob.WriteToConsole();
WriteLine(bob.GetOrigin());
WriteLine(bob.SayHello());
WriteLine(bob.SayHelloTo("Emily"));