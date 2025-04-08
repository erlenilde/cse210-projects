public class MathAssignment : Assignment
{
    private string _textbooksection;
    private string _problems;

    public MathAssignment(string studentname, string topic, string textbooksection, string problems) : base(studentname, topic)
    {
        _textbooksection = textbooksection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textbooksection} Problems {_problems}";
    }
}