// ! Understanding iteration statements

// while loop
int x = 0;
while (x < 10){
    WriteLine(x);
    x++;
}

// * do while loop
// string? actualPassword = "Pa$$w0rd";
// string? password;
// int counter = 0;

// do {
//     Write("Enter your password: ");
//     password = ReadLine();
//     counter++;
// } while (password != actualPassword && counter < 3);
// WriteLine("Correct!");

// * for loop
for(int y = 1; y <= 10; y++){
    WriteLine(y);
}

// * foreach loop
string[] names = {"Adam", "Barry", "Charlie"};
foreach(string name in names){
    WriteLine($"{name} has {name.Length} characters.");
}

// ? Technically, the foreach statement will work on any type that follows rules below:
// ! must have a method GetEnumerator that returns an object
// ! returned object must have a property named Current and a method named MoveNext
// ! MoveNext must change the value of Current and return true if there're more items or return false if no more items are present
