// dash symbol is calculated based on the width of each field
// in this case Type(10), Bytes of memory(30), Min(45), Max(45) = 130 + 3 do make it aligned 

WriteLine(new string('-', 133));
WriteLine(format: "{0, -10} {1,-30} {2, 45} {3, 45}",
"Type", "Byte(s) of memory", "Min", "Max");
WriteLine(new string('-', 133));
WriteLine(format: "{0, -10} {1,-30} {2, 45} {3, 45}",
 "sbyte", sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
WriteLine(format: "{0, -10} {1,-30} {2, 45} {3, 45}",
 "byte", sizeof(byte), byte.MinValue, byte.MaxValue);
WriteLine(format: "{0, -10} {1,-30} {2, 45} {3, 45}",
 "short", sizeof(short), short.MinValue, short.MaxValue);
WriteLine(format: "{0, -10} {1,-30} {2, 45} {3, 45}",
 "ushort", sizeof(ushort), ushort.MinValue, ushort.MaxValue);
WriteLine(format: "{0, -10} {1,-30} {2, 45} {3, 45}",
 "int", sizeof(int), int.MinValue, int.MaxValue);
WriteLine(format: "{0, -10} {1,-30} {2, 45} {3, 45}",
 "uint", sizeof(uint), uint.MinValue, uint.MaxValue);
WriteLine(format: "{0, -10} {1,-30} {2, 45} {3, 45}",
 "long", sizeof(long), long.MinValue, long.MaxValue);
WriteLine(format: "{0, -10} {1,-30} {2, 45} {3, 45}",
 "ulong", sizeof(ulong), ulong.MinValue, ulong.MaxValue);


unsafe {
    WriteLine(format: "{0, -10} {1,-30} {2, 45} {3, 45}",
 "Int128", sizeof(Int128), Int128.MinValue, Int128.MaxValue);
    WriteLine(format: "{0, -10} {1,-30} {2, 45} {3, 45}",
 "UInt128", sizeof(UInt128), UInt128.MinValue, UInt128.MaxValue);
    WriteLine(format: "{0, -10} {1,-30} {2, 45} {3, 45}",
    "Half", sizeof(Half), Half.MinValue, Half.MaxValue);
}

WriteLine(format: "{0, -10} {1,-30} {2, 45} {3, 45}",
 "float", sizeof(float), float.MinValue, float.MaxValue);
WriteLine(format: "{0, -10} {1,-30} {2, 45} {3, 45}",
 "double", sizeof(double), double.MinValue, double.MaxValue);
WriteLine(format: "{0, -10} {1,-30} {2, 45} {3, 45}",
"decimal", sizeof(decimal), decimal.MinValue, decimal.MaxValue);
