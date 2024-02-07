using System;

public class Assignment
{
    private string _studentName;
    private string _topic;
    
    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }

    public string GetSummary() 
    {
        return $"{_studentName} - {_topic}";
    }
    public string GetStudentName()
    {
        return _studentName;
    }
    
public class MathAssignment : Assignment
{

    private string _textbookSection;
    private string _problems;

    public MathAssignment(string name, string topic, string section, string problems) : base(name, topic)
    {
        _textbookSection = section;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}
public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string name, string topic, string title) : base(name, topic)
    {
        _title = title;
    }

    public string GetWritingInformation(Assignment assignment)
    {
        string name = assignment.GetStudentName();
        return $"{_title} by {name}";
    }
}


}


class Program
{
    static void Main(string[] args)
    {
        string name = "Roberto Rodrigues";
        string topic = "Fractions";
        string section = "7.3";
        string problems = "8-19";

        Assignment.MathAssignment mathAssignment = new Assignment.MathAssignment(name, topic, section, problems);
        
        string summary = mathAssignment.GetSummary();
        string homeWork = mathAssignment.GetHomeworkList();
        Console.WriteLine(summary);
        Console.WriteLine(homeWork);

        name = "Mary Waters";
        topic = "European History";
        string title = "The Causes of World War II";

        Assignment.WritingAssignment writingAssignment = new Assignment.WritingAssignment(name, topic, title);
        
        summary = writingAssignment.GetSummary();
        Assignment assignment = new Assignment(name, topic);
        string book = writingAssignment.GetWritingInformation(assignment);
        Console.WriteLine();
        Console.WriteLine(summary);
        Console.WriteLine(book);
    }
}