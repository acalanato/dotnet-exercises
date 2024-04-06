using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int i = 1;
        do{
            Console.WriteLine(i);
            i = i+2;
        }
        while(i < 40);
    }
}
