using System;
using System.Collections.Generic;

public class Program
{
    //Fields
    private static Dictionary<string, List<int>> stacks = new Dictionary<string, List<int>>()
    {
        { "a", new List<int>() {4, 3, 2, 1} },
        { "b", new List<int>() {} },
        { "c", new List<int>() {} }
    };
    //proporties
    //...


    //Methods
    public static void Main()
    {
        while (!GameOver())
        {
            Console.Clear();

            printStacks();

            Console.WriteLine("Enter Starting Stack ");
            string start = Console.ReadLine();

            Console.WriteLine("Enter finishing Stack ");
            string finish = Console.ReadLine();

            if (isLegal(start, finish) == true)
            {
                movePiece(start, finish);
            }
            else

            {
                Console.WriteLine("Move is invalid!");

            }



        }
    }

    public static bool GameOver()
    {
        if (stacks["b"].Count == 4 || stacks["c"].Count == 4)
        {
            return true;
        }
        return false;
   
    }

    public static void movePiece(string start, string finish)
    {
        //int movingPiece = stacks[start].Remove()
        List<int> startStack = stacks[start];
        int movingBlock = startStack[startStack.Count - 1];
        List<int> finishStack = stacks[finish];
        finishStack.Add(movingBlock);
        startStack.Remove(movingBlock);


    }

    public static bool isLegal(string start, string finish)
    {
        if (stacks[finish].Count == 0)
        {
            Console.WriteLine("Stack is empty");
            return true;
        }

        List<int> startStack = stacks[start];
        int movingBlock = startStack[startStack.Count - 1];
        List<int> finishStack = stacks[finish];
        int finishBlock = finishStack[finishStack.Count - 1];

      if (movingBlock < finishBlock)
        {
            return true;

        }
        return false;
    }
    public static void printStacks()
    {
        string[] letters = new string[] { "a", "b", "c" };
        for (var i = 0; i < letters.Length; i++)
        {
            List<string> blocks = new List<string>();
            for (var j = 0; j < stacks[letters[i]].Count; j++)
            {
                blocks.Add(stacks[letters[i]][j].ToString());
            }
            Console.WriteLine(letters[i] + ": " + String.Join("|", blocks));

            

        }
    }
}
