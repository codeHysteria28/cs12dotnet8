// WriteLine($"There're {args.Length} arguments.");

// foreach(string arg in args){
//     WriteLine(arg);
// }

if(args.Length < 3){
    WriteLine("You must specify two colors and cursor size e.g.");
    WriteLine("dotnet run red yellow 50");
    return; // stop running
}

ForegroundColor = (ConsoleColor)Enum.Parse(
    enumType: typeof(ConsoleColor),
    value: args[0], ignoreCase: true
);

BackgroundColor = (ConsoleColor)Enum.Parse(
    enumType: typeof(ConsoleColor),
    value: args[1], ignoreCase: true
);

// macOS cannot change the cursor size so it will complain at compile time
CursorSize = int.Parse(args[2]);

// handling platforms that do not support an API
try {
    CursorSize = int.Parse(args[2]);
}catch(PlatformNotSupportedException) {
    WriteLine("The current platform does not support chaning the size of the cursor.");
}

// another way will be to use OperatingSysten class in System namespace
// or to use conditional compilation statements
// #define MYSYMBOL;