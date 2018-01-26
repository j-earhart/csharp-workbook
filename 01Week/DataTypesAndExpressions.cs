using System;

public class Program
{
    public static void Main()
    {
        bool isHuman = true;

        bool f = false;

        decimal num = 9.99m;

        decimal total = num * num;

        string firstName = "jackie";
        string lastName = "earhart";
        int age = 34;
        string job = "photographer";
        string favoriteBand = "AC/DC";
        string favoriteSportsTeam = "Boston Red Sox";

        Console.WriteLine("First Name:" + firstName);
        Console.WriteLine("Last Name:" + lastName);
        Console.WriteLine("Age:" + age);
        Console.WriteLine("Job:" + job);
        Console.WriteLine("Favorite Band:" + favoriteBand);
        Console.WriteLine("Favorite Sports Team:" + favoriteSportsTeam);

        int myInterger = (int)num;
        Console.WriteLine("My Interger:" + num);




        // your code goes here


        // leave this command at the end so your program does not close automatically
        Console.ReadLine();
    }
}
