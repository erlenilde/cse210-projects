public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0)
    {
        _prompts = new List<string> {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        string prompt = GetRandomPrompt();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"---{prompt}---");
        Console.WriteLine("You may begin in: ");
        ShowCountDown(5);
       
        //int duration = GetDuration();
        //DateTime startTime = DateTime.Now;
        //DateTime endTime = startTime.AddSeconds(duration);
        
        
        //while(DateTime.Now < endTime)
        //{       
        //    Console.ReadLine();
        //   _count ++;                  
        //}

        List<string> responses = GetListFromUser();
        _count = responses.Count;
        
        Console.WriteLine();
        Console.WriteLine($"You listed {_count} items!");

        DisplayEndingMessage();

    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
        
    }

    public List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        while(DateTime.Now < endTime)
        {
            string input = Console.ReadLine();
            responses.Add(input);

        }

        return responses;

    }


}