using Packt.Shared; // to use Person

ConfigureConsole(); // sets current culture to EU English

// Alternatives:

// ConfigureConsole(useComputerCulture: true); // Use your culture
// ConfigureConsole(culture: "fr-FR"); // use French culture
Person bob = new();
WriteLine(bob);