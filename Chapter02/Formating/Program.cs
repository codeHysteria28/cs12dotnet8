// one way of generating formatted strings is to use numbered positional arguments
// supported by Write and WriteLine methods

int numberOfApples = 12;
decimal pricePerApple = 0.35M;

WriteLine(
    format: "{0} apples cost {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples    
);

string formatted = string.Format(
    format: "{0} apples cost {1:C}",
    arg0: numberOfApples,
    arg1: pricePerApple * numberOfApples 
);

// format methods can have up to three numbered args
WriteLine(
    "{0} {1} lived in {2}",
    arg0: "Roger", arg1: "Cevung", arg2: "Stockholm"
);

// four or more parameter values cannot use named args
WriteLine(
    "{0} {1} liven in {2} and worked in the {3} team at {4}.",
    "Roger", "Cevung", "Stockholm", "Education", "Optimizely"
);

// ? Interpolated string
WriteLine($"{numberOfApples} apples cost {pricePerApple * numberOfApples:C}");

// Understanding string formats
// * syntax: { index, [, alignment ] [ : formatString] }

string applesText = "Apples";
int applesCount = 1234;
string bananasText = "Bananas";
int bananasCount = 56789;

WriteLine();
WriteLine(format: "{0, -10} {1,6}",
    arg0: "Name", arg1: "Count");
WriteLine(format: "{0, -10} {1,6:N0}",
    arg0: applesText, arg1: applesCount);
WriteLine(format: "{0, -10} {1,6:N0}",
    arg0: bananasText, arg1: bananasCount);

// * Getting and input from a user
WriteLine("Type your first name and press ENTER:");
// ! "question mark = ?" tells the compiler that we're expecting a possible
// ! null value, so it does not need to tell us
string? firstName = ReadLine();
WriteLine("Type your age and press ENTER:");
// ! exclamation mark is called "null-forgiving operator", it tells the compiler
// ! that ReadLine will not return null in this case
string age = ReadLine()!;
WriteLine($"Hello {firstName}, you look good for {age}."); 

// * Getting key input
Write("Press any key combination: ");
ConsoleKeyInfo key = ReadKey();
WriteLine();
WriteLine("Key: {0}, Char: {1}, Modifiers: {2}",
    arg0: key.Key, arg1: key.KeyChar, arg2: key.Modifiers);