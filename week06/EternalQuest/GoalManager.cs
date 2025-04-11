public class GoalManager
{
    private List<Goal> _goals;
    private int _score = 0;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        
        string userChoice1 = "";
        

        DisplayPlayerInfo();


        while (userChoice1 != "6")
            {
                Console.Clear();

                DisplayPlayerInfo();
                Console.WriteLine("Menu Options:");
                Console.WriteLine(" 1. Create a New Goal");
                Console.WriteLine(" 2. List Goals");
                Console.WriteLine(" 3. Save Goals");
                Console.WriteLine(" 4. Load Goals");
                Console.WriteLine(" 5. Record Event");
                Console.WriteLine(" 6. Quit");
                Console.Write("Select a choice from the menu: ");
                userChoice1 = Console.ReadLine();
                
                Console.Clear();

                if (userChoice1 == "1")
                {
                    CreateGoal();
                }

                else if (userChoice1 == "2")
                {
                    ListGoalDetails();
                }

                else if (userChoice1 == "3")
                {
                    SaveGoals();
                }

                else if (userChoice1 == "4")
                {
                    LoadGoals();
                }

                else if (userChoice1 == "5")
                {
                    RecordEvent();
                }

                else if (userChoice1 == "6")
                {
                    Console.WriteLine("Thank you for using the App. Goodbye!");
                }

                else
                {
                    Console.WriteLine("Invalid option. Please select a number between 1 and 6.");
                }

                if (userChoice1 != "6")
                {
                    Console.WriteLine("\nPress Enter to return to the menu...");
                    Console.ReadLine();
                }


            }
        
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");

    }

    public void ListGoalNames()
    {
        Console.WriteLine($"Your goals are:");
        int index = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{index}. {goal.GetName()}");
            index++;
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("Your goals are:");
        int index = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{index}. {goal.GetDetailsString()}");
            index++;
        } 
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine(" 1. Simple Goal");
        Console.WriteLine(" 2. Eternal Goal");
        Console.WriteLine(" 3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string goalType = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        Goal newGoal = null;

        if (goalType == "1")
        {
            newGoal = new SimpleGoal(name, description, points);
        }
        else if (goalType == "2")
        {
            newGoal = new EternalGoal(name, description, points);
        }
        else if (goalType == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            newGoal = new ChecklistGoal(name, description, points, target, bonus);
        }

        if (newGoal != null)
        {
            _goals.Add(newGoal);
            Console.WriteLine("Goal created successfully!");
        }
        else
        {
            Console.WriteLine("Invalid goal type. Goal not created.");
        }



    }

    public void RecordEvent()
    {
        ListGoalNames();

        Console.Write("Which goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine());

        int goalIndex = choice - 1;
        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
        Goal selectedGoal = _goals[goalIndex];

        selectedGoal.RecordEvent();

        int pointsEarned = selectedGoal.GetPoints();

        if (selectedGoal is ChecklistGoal checklist)
        {
            if (checklist.IsComplete() && checklist.GetAmountCompleted() == checklist.GetTarget())
            {
                pointsEarned += checklist.GetBonus();
            }
        }
        _score += pointsEarned;
        Console.WriteLine($"Congratulations! You earned {pointsEarned} points!");
        
        }
        else
        {
            Console.WriteLine("Invalid goal selection.");
        }
    }
    

    public void SaveGoals()
    {
        Console.Write("Enter the filename to save goals (e.g., goals.txt): ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine($"Saved in: {Path.GetFullPath(filename)}");
        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals()
    {
        Console.Write("Enter the filename to load goals from: ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        string[] lines = File.ReadAllLines(filename);
        _goals.Clear();

        
        _score = int.Parse(lines[0]);

    
        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(":");
            string goalType = parts[0];
            string[] data = parts[1].Split(",");

            if (goalType == "SimpleGoal")
            {
                var goal = new SimpleGoal(data[0], data[1], int.Parse(data[2]));
                if (bool.Parse(data[3])) goal.RecordEvent(); 
                _goals.Add(goal);
            }
            else if (goalType == "EternalGoal")
            {
                var goal = new EternalGoal(data[0], data[1], int.Parse(data[2]));
                _goals.Add(goal);
            }
            else if (goalType == "ChecklistGoal")
            {
                var goal = new ChecklistGoal(
                    data[0],
                    data[1],
                    int.Parse(data[2]),
                    int.Parse(data[3]),
                    int.Parse(data[4])
                );

                int completions = int.Parse(data[5]);
                for (int j = 0; j < completions; j++)
                {
                    goal.RecordEvent();
                }

                _goals.Add(goal);
            }
        }

        Console.WriteLine("Goals loaded successfully!");
        }
}