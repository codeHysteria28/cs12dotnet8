#region
// !postfix
int a = 3;
int b = a++;
WriteLine($"a is {a}, b is {b}");

// ! prefix
int c = 3;
int d = ++c;
WriteLine($"c is {c},d is {d}"); 
#endregion

// ! binary arithemetic operators
int e = 11;
int f = 3;
WriteLine($"e is {e}, f is {f}");
WriteLine($"e + f = {e + f}");
WriteLine($"e - f = {e - f}");
WriteLine($"e * f = {e * f}");
WriteLine($"e / f = {e / f}");
WriteLine($"e % f = {e % f}");

double g = 11.0;
WriteLine($"g is {g:N1}, f is {f}");
WriteLine($"g / f = {g / f}");

// ! assignment operators

int p = 6;
p += 3; // eq to: p = p + 3
p -= 3; // eg to: p = p - 3
p *= 3; // eg to: p = p * 3
p /= 3; // eg to: p = p / 3

// ! null-coalescing operators
string? authorName = ReadLine(); // prompt user to enter an author name
// the maxLength variable will  be the length of authorName if it is
// not null, or 30 if authorName is null
int maxLength = authorName?.Length ?? 30;
// the authorName variable will be "unknown" if authorName was null
authorName ??= "unknown";

// ! conditional logical operators
bool s = true;
bool q = false;
static bool DoStuff() {
    WriteLine("I am doing some stuff");
    return true;
}

WriteLine();
// ? Note that DoStuff() returns true;
WriteLine($"s & DoStuff() = {s & DoStuff()}");
WriteLine($"q & DoStuff() = {q & DoStuff()}");

WriteLine();
WriteLine($"s && DoStuff() = {s && DoStuff()}");
WriteLine($"q && DoStuff() = {q && DoStuff()}");