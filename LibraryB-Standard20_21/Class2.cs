using System;

namespace LibraryB_Standard20_21;

#if !NETSTANDARD2_1_OR_GREATER

public static class Class2
{
    public static void WriteLine()
    {
        Console.WriteLine("LibraryB-Standard20_21/Class2.cs");
    }
}

#endif