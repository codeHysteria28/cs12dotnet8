using System.Reflection; // to use Asembly, TypeName, and so on.
/*
Declare some unused variables using types in addtional
assemblies to make them load too.
*/

System.Data.DataSet ds = new();
HttpClient client = new();

// get Assembly that is the entry point for this app.
Assembly? myApp = Assembly.GetEntryAssembly();

// if the previous line returned nothing then end the app.
if(myApp is null) return;

// loop through the assemblies that my app references.
foreach(AssemblyName name in myApp.GetReferencedAssemblies()){
    // load Assembly so we can read the details
    Assembly a = Assembly.Load(name);
    // declare a variable to count the number of methods
    int methodCount = 0;
    // loop through all the types in the Assembly
    foreach (TypeInfo t in a.DefinedTypes){
       // add up the counts of all the methods
       methodCount += t.GetMethods().Length; 
    }

    // output the count of types and their methods
    WriteLine("{0:N0} types with {1:N0} methods in {2} Assembly",
    arg0: a.DefinedTypes.Count(),
    arg1: methodCount,
    arg2: name.Name);
}