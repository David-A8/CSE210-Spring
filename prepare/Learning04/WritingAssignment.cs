public class WritingAssignment : Assignment
{
    string _title;

    public WritingAssignment(string StudentName, string Topic, string Title) : base(StudentName, Topic)
    {
        _title = Title;
    }

    public string GetWritingInformation()
    {
        return $"{_title} by {_studentName}";
    }
}