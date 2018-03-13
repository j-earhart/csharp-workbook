using System;
using System.Collections.Generic;

public class Program
{
    //fields
    private static Stopwatch _stopWatch;
    private static string _command;
    private static TimeSpan _time;

    //Properties


    //constructor

    static Program()
    {
        _stopWatch = new Stopwatch();
    }

    //Methods
    public static void Main()
    {
        Console.WriteLine("Type Start to Start the stopwatch, Stop to end the stopwatch, and Exit to exit the application.");
        while (_command != "exit")

        {

            _command = Console.ReadLine().ToLower();
            if (_command == "start")
            {
                //if start, then start stopwatch
                // if already started give error that time as started
                //if 
                _stopWatch.Start();

            }
            else if (_command == "stop")
            {
                _stopWatch.Stop();

            }
            else if (_command == "laps")
            {
                _stopWatch.PrintLaps();
            }

        }
    }


    class Stopwatch
    {
        //fields
        private DateTime _startDateTime;
        private DateTime _endDateTime;
        private TimeSpan _elapsedTime;

        //properties
        public List<TimeSpan> Laps { get; set; }

        public Stopwatch()
        {
            Laps = new List<TimeSpan>();

        }
        //Methods

        public bool Start()
        {
            Console.WriteLine("STOPWATCH HAS STARTED");
            _startDateTime = DateTime.Now;


            //_command = Console.ReadLine().ToLower();
            return true;

        }
        public bool Stop()
        {
            Console.WriteLine("STOPWATCH HAS STOPPED");
            _endDateTime = DateTime.Now;
            _elapsedTime = _endDateTime - _startDateTime;
            Laps.Add(_elapsedTime);
            Console.WriteLine(_elapsedTime);
            //Console.ReadLine();
            return true;
        }
        public bool PrintLaps()
        {
            foreach (var item in Laps)
            {
                Console.WriteLine(item);

            }
            return true;
        }



    }
}
