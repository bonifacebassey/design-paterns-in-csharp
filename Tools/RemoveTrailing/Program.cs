/* Removing trailing ??value from byte array */
/*-------------------------------------------*/

// Solution 1 : counting in reverse order until the desired byte is encountered
byte[] Decode(byte[] inArray, byte valueToRemove)
{
    var len = inArray.Length - 1;

    while (inArray[len] == valueToRemove)
    {
        --len;
    }

    var outArray = new byte[len + 1];
    Array.Copy(inArray, outArray, len + 1);

    return outArray;
}

// Solution 2 : using trimming 
byte[] TrimEnd(byte[] array, byte valueToRemove)
{
    int lastValidIndex = Array.FindLastIndex(array, value => value != valueToRemove);
    Array.Resize(ref array, lastValidIndex);

    return array;
}


// Solution 3 : using LINQ  
byte[] TrimTailingZeros(byte[] array, byte valueToRemove)
{
    if (array == null || array.Length == 0)
        return array;

    return array.Reverse().SkipWhile(value => value == valueToRemove).Reverse().ToArray();
}


byte[] arr = { 1, 2, 3, 0, 0, 0, };
arr.ToList().ForEach(element => Console.Write($"{element} "));

Console.Write($"\n\tUsing reverse counting: -> ");
Decode(arr, 0).ToList().ForEach(element => Console.Write($"{element} "));

Console.Write($"\n\tusing trimming: -> ");
TrimEnd(arr, 0).ToList().ForEach(element => Console.Write($"{element} "));

Console.Write($"\n\tusing LINQ: -> ");
TrimTailingZeros(arr, 0).ToList().ForEach(element => Console.Write($"{element} "));
