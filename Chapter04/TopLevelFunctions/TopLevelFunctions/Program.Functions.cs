partial class Program
{
    static void WhatsMyNamespace() // define a static function
    {
        Console.WriteLine("Namespace of Program class: {0}",
            arg0: typeof(Program).Namespace ?? "null");
    }
}