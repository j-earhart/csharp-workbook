using System;

public class Program
{
    public static string _command;

    public static void Main()
    {
        var newPost = new BlogPost
        {
            Title = "New Post",
            Description = "New Post Description."
        };
        Console.WriteLine("-------------------------");
        Console.WriteLine(newPost.Title);
        Console.WriteLine(newPost.Description);
        Console.WriteLine(newPost.CreationDateTime);
        Console.WriteLine("-------------------------");

        do
        {
            //Console.WriteLine("Number of votes: " + newPost.DisplayVotes());
            Console.WriteLine("Please Type Upvote or Downvote to vote on Blog");
            _command = Console.ReadLine().ToLower();

            switch (_command)
            {
                case "upvote":
                    newPost.UpVote();
                    Console.WriteLine("You have " + newPost.DisplayVotes() + " votes");
                    break;

                case "downvote":
                    newPost.DownVote();
                    Console.WriteLine("You have " + newPost.DisplayVotes() + " votes");
                    break;

                default:
                    Console.WriteLine("Please enter a valid command");
                    break;

            }
        } while (_command != "exit");

    }
}

class BlogPost
{
    public string Title { get; set; }
    public string Description { get; set; }
    public readonly DateTime CreationDateTime = DateTime.Now;
    private int _votes = 0;

    public int DisplayVotes()
    {
        return _votes;
    }

    public void UpVote()
    {
        _votes++;
    }

    public void DownVote()
    {
        _votes--;
    }
}