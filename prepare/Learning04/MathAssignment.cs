public class MathAssignment : Assignment
{
    string _textbookSection;
    string _problems;

    public MathAssignment(string StudentName, string Topic, string TextBook, string Problems) : base(StudentName,Topic)
    {
        _textbookSection = TextBook;
        _problems = Problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }

}