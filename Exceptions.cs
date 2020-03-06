//are what happens when things at run time 
//And they give us a way of handling/dealing with unexpected (or exceptional behavior)

public class StringReverser
{
    public string ReverseString(string input)
    {
        //guard for nulls here
        if(string.IsNullOrEmpty(input))
        {
            return "";
        }

        //string are immutable in c#
        //so every time you change a string it actually creates a new string
        //string builder class lets build out strings without creating a new one each time
        var sb = new StringBuilder();
        for(var i = input.Length -1; i => 0; i--)
        {
            sb.Append(input[i]);
        }
        return sb.ToString();
    }
}

public class Program {
    public static void Main(string[] args)
    {
        Console.WriteLine("enter a string");
        var reverser = new StringReverser();
        //null is the absence of a value
        //throws a null reference exception because it can't access the Length property of a null
        var reversedString = reverser.ReverseString(null);
    }
}