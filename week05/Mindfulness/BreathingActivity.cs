public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 0)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        int duration = GetDuration();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);
        
        while(DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in... ");
            ShowCountDown(4);
            Console.WriteLine();
            Console.WriteLine("Breathe out... ");
            ShowCountDown(6);
            Console.WriteLine();
                  
        }

        DisplayEndingMessage();
    }
}