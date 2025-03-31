
using System;
using System.Collections.Generic;
using System.Linq;
public class Assignment9
{
    public static void Main(string[] args)
    {
        List<string> words = new List<string>()  {   "This", "is",   "a",    "sample",   "sentence"
};
        //	LINQ	to	concatenate	strings	using	Aggregate
        string sentence = words.Aggregate(
                        (current, next) => current + ",	" + next
        ) + ".";
        Console.WriteLine($"The	sentence	is:	{sentence}");
    }
}
